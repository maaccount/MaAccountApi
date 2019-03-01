FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY ["src/MaAccount.Web.Host/MaAccount.Web.Host.csproj", "src/MaAccount.Web.Host/"]
COPY ["src/MaAccount.Web.Core/MaAccount.Web.Core.csproj", "src/MaAccount.Web.Core/"]
COPY ["src/MaAccount.EntityFrameworkCore/MaAccount.EntityFrameworkCore.csproj", "src/MaAccount.EntityFrameworkCore/"]
COPY ["src/MaAccount.Core/MaAccount.Core.csproj", "src/MaAccount.Core/"]
COPY ["src/MaAccount.Application/MaAccount.Application.csproj", "src/MaAccount.Application/"]
RUN dotnet restore "src/MaAccount.Web.Host/MaAccount.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/MaAccount.Web.Host"
RUN dotnet build "MaAccount.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MaAccount.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MaAccount.Web.Host.dll"]