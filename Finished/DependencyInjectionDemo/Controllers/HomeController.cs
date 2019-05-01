using System.Diagnostics;
using DependencyInjectionDemo.Data;
using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _productRepository;
        private readonly WeatherService _weatherService;

        public HomeController(IRepository productRepository, WeatherService weatherService)
        {
            _productRepository = productRepository;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View(_productRepository.Customers);
        }

        public string Weather()
        {
            return _weatherService.GetWeather();
        }

        public string Customer([FromServices]CustomerService customerserverService)
        {
            return customerserverService.GetCustomer();
        }
    }
}