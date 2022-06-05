using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SqlCreatTable.DAL;
using SqlCreatTable.Models;
using SqlCreatTable.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SqlCreatTable.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b=>b.Comments).Include(t => t.Tags).ToList();
            return View(blogs);
        }

        public IActionResult Detail(int id)
        {
            if(id == null) return NotFound();

            BlogVM model = new BlogVM
            {
                Blog = _context.Blogs.Include(b => b.Comments).Include(t => t.Tags).FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.Take(4).ToList(),
                BlogsTag = _context.Blogs.Include(t => t.Tags).ToList()

            };
            if(model.Blog==null)return NotFound();
            return View(model);  
        }
    }
}
