using Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Getallpaper_admin.Controllers
{
    public class AuthController : Controller
    {
        private IAuthService _AuthService;

        public AuthController(IAuthService AuthService)
        {
            _AuthService = AuthService;
        }
    }
}
