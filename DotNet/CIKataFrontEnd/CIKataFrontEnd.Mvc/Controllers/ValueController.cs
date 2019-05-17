using System;
using System.Net.Http;
using CIKataFrontEnd.Mvc.Domain;
using CIKataFrontEnd.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIKataFrontEnd.Mvc.Controllers
{
    public class ValueController : Controller
    {
        readonly ValueService _service = new ValueService();
        
        [HttpGet]
        public IActionResult GetValues()
        {
            // call backend
            var response = _service.GetValueFromApi();
            // create view model
            var model = new ValueViewModel(response);

            return View(model);
        }
    }
}