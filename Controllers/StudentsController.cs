using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace myapiP.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    //We are going to create a Controller with the following routes
    //1 Retreive a list of students. [HttGet] R
    //2 Add Students to list. [HttpPost] C
    //3 Remove a student fro the list [HttpDelete] D
    //4 Edit a student in our list [HttpPut] U

    // [HttpGet]
    // public string JustChecking()
    // {
    //     return "Making sure this endpoint works";
    // }

    public List<string> studentList = new();

    public StudentsController()
    {
        studentList.Add("Hello");
        
        
    }

//Add a student endpoint
[HttpPost]
[Route("AddStudent/{studenName}")]

public List<string> AddToStudentList(string studenName)
    {
        studentList.Add(studenName);
        return studentList;
    }

}