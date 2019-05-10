using System;
using CIKataBackEnd.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CIKataBackEnd.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private BusinessLogicService _bls = new BusinessLogicService();
        
        // GET api/values/
        [HttpGet]
        public JsonResult Get()
        {
            var returnString = string.Empty;

            try
            {
                returnString = _bls.MakeUpValue();
            }
            catch (Exception e)
            {
                returnString = $"This Is Not a Successful Call Because: {e.Message}";
            }
            
            return new JsonResult(returnString);
        }
    }
}