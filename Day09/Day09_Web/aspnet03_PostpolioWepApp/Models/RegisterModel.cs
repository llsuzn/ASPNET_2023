using NuGet.Protocol;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet02_boardapp.Models
{
    //회원가입할 때 데이터 받는 부분
    public class RegisterModel
    {
        [Required(ErrorMessage ="이메일주소는 필수입니다.")]
        [EmailAddress]
        [DisplayName("Email Address")]

        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "비밀번호는 필수입니다.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]

        public string Password { get; set; }

        [Required(ErrorMessage = "패스워드 확인은 필수입니다.")]
        [DataType(DataType.Password)]
        [DisplayName("Password Confirm")]
        [Compare("Password",ErrorMessage ="패스워드가 일치하지 않습니다. 다시 입력하세요.")]
        public string ConfirmPassword { get; set; }

    }
}
