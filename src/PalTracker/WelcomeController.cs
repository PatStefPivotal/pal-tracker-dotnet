using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello() => "Hello Stef and Pat! Update! :)";
    }
}