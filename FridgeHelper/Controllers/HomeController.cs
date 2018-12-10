namespace DrumGenerator.Controllers
{
    using DrumGenerator.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Note note = new Note();

            return View(note);
        }
    }
}