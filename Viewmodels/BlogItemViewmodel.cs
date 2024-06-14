namespace PortfolioHarlod.Viewmodels
{
    public class BlogItemViewmodel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public string Url { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime updatedDate { get; set; }
    }

    public class BlogItemListViewmodel
    {
        public List<BlogItemViewmodel> blogItems { get; set; }
    }
}
