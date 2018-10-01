namespace VirtualscrollerSample.Model
{
    public class SearchRequest
    {
        public string SortBy { get; set; }

        public bool? IsDesc { get; set; }

        public int? PageSize { get; set; }

        public int? PageIndex { get; set; }
    }
}
