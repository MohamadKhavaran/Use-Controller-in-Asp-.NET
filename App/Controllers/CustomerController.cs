using Microsoft.AspNetCore.Mvc;

namespace App.Controllers 
{
    [Route("[controller]")] 
    public class CustomerController : ControllerBase
    {

    [HttpGet]
    public string get()
    {
        return "Salam Moshtari";
    }
    [HttpGet("@")]
    public string get2()
    {
        return "salam Moshtari 2";
    }
    }
}