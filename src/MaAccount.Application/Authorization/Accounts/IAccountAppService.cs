using System.Threading.Tasks;
using Abp.Application.Services;
using MaAccount.Authorization.Accounts.Dto;

namespace MaAccount.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<RegisterOutput> Register(RegisterInput input);

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ForgetPasswordOutput> ForgetPassword(ForgetPasswordInput input);
    }
}
