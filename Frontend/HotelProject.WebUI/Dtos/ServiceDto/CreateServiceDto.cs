using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet İcon linki giriniz")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        public string? Description { get; set; }
    }
}
