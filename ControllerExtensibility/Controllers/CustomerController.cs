﻿using ControllerExtensibility.Models;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", new Result 
            {
                ControllerName = "Customer",
                ActionName = "Index"
            });
        }
        public ViewResult List()
        {
            return View("Result", new Result
                {
                    ControllerName = "Customer",
                    ActionName = "List"
                });
        }

    }
}
