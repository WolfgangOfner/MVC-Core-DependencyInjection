using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    public class NoDdependencyInjectionController : Controller
    {
        public string Index()
        {
            var service = (CustomerService) HttpContext.RequestServices.GetService(typeof(CustomerService));

            return service.GetCustomer();
        }
    }
}