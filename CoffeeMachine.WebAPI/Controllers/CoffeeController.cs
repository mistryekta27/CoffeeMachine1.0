﻿using CoffeeMachine.API.CustomFilter;
using CoffeeMachine.API.Helper;
using CoffeeMachine.API.Interface;
using CoffeeMachine.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService _iCoffeeService;

        public CoffeeController(ICoffeeService iCoffee)
        {
            _iCoffeeService = iCoffee;
        }
        // GET: api/<CoffeeController>
        [Route("brew-coffee")]
        [HttpGet]
        [ServiceFilter(typeof(APICountFilter))]
        public async Task<IActionResult> Get()
        {
            //Check for every 5th call to this API.
            bool isAPIcount = _iCoffeeService.CheckAPICount(APICounter.APICount);
            if (isAPIcount)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable);
            }

            //Compare current date with specific date.
            bool isDateSame = _iCoffeeService.CompareDate(DateTime.Now);
            if (isDateSame)
            {
                return StatusCode(StatusCodes.Status418ImATeapot);
            }

            //Check for weather temperature
            bool isTemperature = await _iCoffeeService.CheckTemperature();
            if (isTemperature)
            {
                return StatusCode(StatusCodes.Status200OK, new { message = Constant.WeatherMessage });
            }

            //Convert current date/time into ISO-8601 format
            string ISODate = DateTime.Now.ToString(Constant.ISODateFormat);
            return StatusCode(StatusCodes.Status200OK, new { message = Constant.CoffeeSuccessMessage, prepared = ISODate });
        }


    }
}
