using System.Threading.Tasks;
using Abp.Application.Services;
using MaAccount.Sessions.Dto;

namespace MaAccount.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
