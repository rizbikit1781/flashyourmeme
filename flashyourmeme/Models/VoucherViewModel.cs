namespace flashyourmeme.Models
{
    public class VoucherViewModel
    {
        public List<VoucherModel> Vouchers { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
