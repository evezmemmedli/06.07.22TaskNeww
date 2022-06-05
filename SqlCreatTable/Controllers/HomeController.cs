using Microsoft.AspNetCore.Mvc;
using SqlCreatTable.DAL;
using SqlCreatTable.Models;
using System.Collections.Generic;
using System.Linq;

namespace SqlCreatTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Slider> sliders = _context.Sliders.ToList();

            //List<Slider> sliders = new List<Slider>()
            //{
            //    new Slider
            //    {
            //        Id = 1,
            //        Image = "1.jpg",
            //        Title= "The Best Business Information",
            //        Subtitle = "We're In The Business Of Helping You Start Your Business",
            //        Url = "https://www.google.com",
            //        Order =2
            //    },
            //    new Slider
            //    {
            //        Id = 2,
            //        Image = "2.jpg",
            //        Title= "Temporibus autem quibusdam",
            //        Subtitle = "Beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem",
            //        Url = "https://www.youtube.com",
            //        Order=1
            //    },
            //    new Slider
            //    {
            //        Id = 3,
            //        Image = "3.jpg",
            //        Title= "At vero eos et accusamus",
            //        Subtitle = "Helping Business Security & Peace of Mind for Your Family",
            //        Url = "https://www.instagram.com",
            //        Order=3
            //    }
            //};
            return View(sliders);
        }
    }
}
