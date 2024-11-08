using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDro
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        public string? Name{ get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Mail alanı gereklidir")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Ad alanı gereklidir")]
        [Compare(nameof(Password),ErrorMessage ="Şifreler uyuşmuyor")]
        public string? ConfirmPassword { get; set; }
        public int WorkLocationID { get; set; }

    }
}
