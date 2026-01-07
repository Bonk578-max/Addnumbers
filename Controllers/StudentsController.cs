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
    public int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
}
