using System.Threading.Tasks;
using Abp.Configuration;
using Abp.UI;
using Abp.Zero.Configuration;
using MaAccount.Authorization.Accounts.Dto;
using MaAccount.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MaAccount.Authorization.Accounts
{
    public class AccountAppService : MaAccountAppServiceBase, IAccountAppService
    {

        private readonly UserRegistrationManager _userRegistrationManager;

        private readonly IPasswordHasher<User> _passwordHasher;

        public AccountAppService(
            UserRegistrationManager userRegistrationManager, IPasswordHasher<User> passwordHasher)
        {
            _userRegistrationManager = userRegistrationManager;
            _passwordHasher = passwordHasher;
        }

        public async Task<RegisterOutput> Register(RegisterInput input)
        {
            var user = await _userRegistrationManager.RegisterAsync(
                input.UserName,
                input.UserName,
                input.UserName + "@default.com",
                input.UserName,
                input.Password,
                true,// Assumed email address is always confirmed. Change this if you want to implement email confirmation.
                input.Question,
               input.Answer
            );

            var isEmailConfirmationRequiredForLogin = await SettingManager.GetSettingValueAsync<bool>(AbpZeroSettingNames.UserManagement.IsEmailConfirmationRequiredForLogin);

            return new RegisterOutput
            {
                CanLogin = user.IsActive && (user.IsEmailConfirmed || !isEmailConfirmationRequiredForLogin)
            };
        }

        public async Task<ForgetPasswordOutput> ForgetPassword(ForgetPasswordInput input)
        {
            var user = await UserManager.Users.FirstOrDefaultAsync(p => p.UserName == input.UserName);

            if (user == null)
                throw new UserFriendlyException("用户不存在");

            if (user.Question != input.Question || user.Answer != input.Answer)
                throw new UserFriendlyException("密保不正确");

            user.Password = _passwordHasher.HashPassword(user, input.Password);

            await UserManager.UpdateAsync(user);

            var result = await UserManager.SetLockoutEnabledAsync(user, false);

            return new ForgetPasswordOutput();
        }
    }
}
