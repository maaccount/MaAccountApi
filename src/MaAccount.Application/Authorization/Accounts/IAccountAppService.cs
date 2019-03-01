using System.Threading.Tasks;
using Abp.Application.Services;
using MaAccount.Authorization.Accounts.Dto;

namespace MaAccount.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<RegisterOutput> Register(RegisterInput input);
    }
}
