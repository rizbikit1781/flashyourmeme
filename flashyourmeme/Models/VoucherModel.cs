namespace flashyourmeme.Models
{
    public class VoucherModel
    {
        public int No { get; set; }
        public string ProfileImageUrl { get; set; }
        public string BranchName { get; set; }
    }

    public class VoucherViewModel
    {
        public List<VoucherModel> Vouchers { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

    public class SubItemViewModel
    {
        public int VoucherId { get; set; }
        public string BranchName { get; set; }
        public List<SubItem> SubItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

    public class SubItem
    {
        public int No { get; set; }
        public string EventName { get; set; }
    }
}
