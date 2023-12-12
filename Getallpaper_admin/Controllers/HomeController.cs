using Getallpaper_admin.Models;
using Infrastructure.Implementation;
using Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Generators;
using System.Diagnostics;

namespace Getallpaper_admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAuthService _AuthService;
        private ILeedService _LeedService;
        private IOrderService _OrderService;
        private IRevisionsService _RevisionsService;
        public HomeController(ILogger<HomeController> logger, IAuthService AuthService,ILeedService LeedService,IOrderService OrderService, IRevisionsService RevisionsService)
        {
            _AuthService = AuthService;
            _logger = logger;
            _LeedService = LeedService;
            _OrderService = OrderService;   
            _RevisionsService = RevisionsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public async Task<AsUser> authenticate(AsUser obj)
        //{
        //    return await _AuthService.authenticate(obj);
        //}
        {
            try
            {
                var response = await _AuthService.authenticate(new AsUser
                {
                    Email = obj.Email,
                    Password = obj.Password,
                    

                });
                if (response != null)
                {
                    var verified = BCrypt.Net.BCrypt.Verify(obj.Password, response?.Password);
                    if (verified)
                    {
                        //HttpContext.Session.SetString("CurrentUser", JsonConvert.SerializeObject(response, Formatting.Indented));
                        obj.Email = "success";
                        return obj;
                       
                    }
                    else
                        return obj;
                }
                else
                {
                    return obj;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //////// Operation All Leeds //////////
       [ActionName("leeds")]
        public async Task<IActionResult> GetAllLeed()
        {
            var leeds= await _LeedService.GetAllLeed();
            return View(new { Leeds = leeds });
        }
        [HttpPost]
        public async Task<AsLeed> UpdateLeed(AsLeed obj)
        {
            return await _LeedService.UpdateLeed(obj);
        }
        [HttpPost]
        public async Task<AsLeed> DeleteLeed(AsLeed obj)
        {
            return await _LeedService.DeleteLeed(obj);
        }

        //////// Operation All Orders //////////
        [ActionName("unpaidOrder")]
        public async Task<IActionResult> GetAllUnpaidOrder()
        { 
            var unpaidOrder = await _OrderService.GetAllUnpaidOrder();
            return View(new { Orders = unpaidOrder });
        }
        [HttpPost]
        public async Task<AsOrder> DeleteUnpaidOrder(AsOrder obj)
        {
            return await _OrderService.DeleteUnpaidOrder(obj);
        }
        [HttpPost]
        public async Task<AsOrder> UpdateUnpaidOrder(AsOrder obj)
        {
            return await _OrderService.UpdateUnpaidOrder(obj);
        }
        [ActionName("paidOrder")]
        public async Task<IActionResult> GetAllpaidOrder()
        {
            var paidOrder = await _OrderService.GetAllpaidOrder();
            return View(new { Orders = paidOrder });
        }
        [HttpPost]
        public async Task<AsOrder> DeletepaidOrder(AsOrder obj)
        {
            return await _OrderService.DeletepaidOrder(obj);
        }
        [HttpPost]
        public async Task<AsOrder> UpdatepaidOrder(AsOrder obj)
        {
            return await _OrderService.UpdatepaidOrder(obj);
        }
        [ActionName("allOrders")]
        public async Task<IActionResult> GetAllOrder()
        {
            var paidOrder = await _OrderService.GetAllOrder();
            return View(new { Orders = paidOrder });
        }
        [HttpPost]
        public async Task<AsOrder> DeleteOrder(AsOrder obj)
        {
            return await _OrderService.DeleteOrder(obj);
        }
        [HttpPost]
        public async Task<AsOrder> UpdateOrder(AsOrder obj)
        {
            return await _OrderService.UpdateOrder(obj);
        }
        ////////////////// Revisions ////////////////////////
        ///
        [ActionName("revisions")]
        public async Task<IActionResult> GetAllRevision()
        {
            var revisions = await _RevisionsService.GetAllRevision();
            return View(new { Revisions = revisions });
        }
        [HttpPost]
        public async Task<AsRevision> DeleteRevision(AsRevision obj)
        {
            return await _RevisionsService.DeleteRevision(obj);
        }
        [HttpPost]
        public async Task<AsRevision> UpdateRevision(AsRevision obj)
        {
            return await _RevisionsService.UpdateRevision(obj);
        }
    }
}