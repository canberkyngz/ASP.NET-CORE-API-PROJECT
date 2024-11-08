using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {

        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet İcon linki giriniz")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlık giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklama giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet başlığı en fazla 500 karakter olabilir")]
        public string? Description { get; set; }
    }
}
