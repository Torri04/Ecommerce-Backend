namespace ASP.NET_API.Helpers
{
    public class ProductQuery
    {
        public string? ProductName { get; set; }
        public int? Price { get; set; }
        public string? SortBy { get; set; }
        public bool IsDescending { get; set; } = false;
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; } = 20;
    }
}