using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapiP.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    public MathController()
    {
    }

    // Add two numbers
    [HttpGet]
    [Route("Add/{number1}/{number2}")]
    public string AddNumbers(int number1, int number2)
    {
        int sum = number1 + number2;
        return $"The sum of {number1} and {number2} is {sum}.";
    }
}

