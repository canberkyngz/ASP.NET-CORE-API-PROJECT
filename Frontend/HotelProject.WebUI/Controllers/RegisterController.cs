using HotelProject.EntityLayer;
using HotelProject.WebUI.Dtos.RegisterDro;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManageer;
        public RegisterController(UserManager<AppUser> userManageer)
        {
            _userManageer = userManageer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                WorkLocationID=1 //Kullanıcının WorkLocationId değerini default olarak 1 verdik yani Bostancı-İstanbul olacak.
                
            };
            var result=await _userManageer.CreateAsync(appUser,createNewUserDto.Password!);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
