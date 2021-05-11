using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
            return View();
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }

        // The URL pattern for routing is generated and added to the domain name
        // ex. domain name is https://localhost:1337
        // Then comes the controller
        // Then the action
        // And finally the id
        // https://localhost:1337/{controller}/{action}/{id}/

    }
}
