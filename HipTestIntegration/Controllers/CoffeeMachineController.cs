using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HipTestIntegration.Controllers
{
    public class CoffeeMachineController : Controller
    {
        // GET: CoffeeMachine
        //public ActionResult Index()
        //{
            
        //}
        private bool started = false;
        public bool coffeeServed = false;
        public void start()
        {
            started = true;
            
        }
        public void takeCoffee()
        {
            if (started)
            {
                coffeeServed = true;
            }
        }
    }
}