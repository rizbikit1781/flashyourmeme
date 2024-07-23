namespace flashyourmeme.Models
{
    public class BranchViewModel
    {
        public List<BranchModel> Branches { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
