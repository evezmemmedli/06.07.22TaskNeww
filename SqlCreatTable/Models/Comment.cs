using System;

namespace SqlCreatTable.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public string UserName { get; set; }

        public DateTime Date  { get; set; }

        public string Message { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
