namespace SqlCreatTable.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
