using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;

namespace MaAccount.Authorization.Accounts.Dto
{
    public class ForgetPasswordInput
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
        [RegularExpression(@"0?(13|14|15|17|18|19)[0-9]{9}", ErrorMessage = "电话号码不正确")]
        public string UserName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [RegularExpression(@"^(?![a-zA-z]+$)(?!\d+$)(?![!@#$%^&*]+$)[a-zA-Z\d!@#$%^&*]+$", ErrorMessage = "密码必须满足以下规则：最短6位，最长16位\n包含小写大母[a - z]或大写字母[A - Z]\n可以包含数字[0 - 9]\n可以包含下划线[_] 和减号[- ]")]
        [DisableAuditing]
        public string Password { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}