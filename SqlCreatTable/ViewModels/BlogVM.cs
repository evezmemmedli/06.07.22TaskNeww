using SqlCreatTable.Models;
using System;
using System.Collections.Generic;

namespace SqlCreatTable.ViewModels
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Blog> BlogsTag { get; set; }




    }
}
