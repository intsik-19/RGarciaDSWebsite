using Microsoft.AspNetCore.Mvc;
using RGarciaDSWebsite.Models;

namespace RGarciaDSWebsite.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index(string firstName, string lastName, string email)
        {
            RGarciaDrivingSchool rGarciaDS = new RGarciaDrivingSchool();
            Customer newCustomer = new Customer();
            newCustomer.firstName = firstName;
            newCustomer.lastName = lastName;
            newCustomer.email = email;
            rGarciaDS.addCustomerToDB(newCustomer);
            return View();
        }
    }
}