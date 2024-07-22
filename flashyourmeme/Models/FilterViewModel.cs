namespace flashyourmeme.Models
{
    public class FilterViewModel
    {
        public List<FilterModel> Filters { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}