using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;

namespace flashyourmeme.Controllers
{
    public class VoucherController : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 8)
        {
            var vouchers = new List<VoucherModel>
        {
            new VoucherModel { No = 1, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch1" },
            new VoucherModel { No = 2, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch2" },
            new VoucherModel { No = 3, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch3" },
            new VoucherModel { No = 4, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch4" },
            new VoucherModel { No = 5, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch5" },
            new VoucherModel { No = 6, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch6" },
            new VoucherModel { No = 7, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch7" },
            new VoucherModel { No = 8, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch8" },
            new VoucherModel { No = 9, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch9" },
            new VoucherModel { No = 10, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch10" },
            new VoucherModel { No = 11, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch11" },
            new VoucherModel { No = 12, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch12" },

        };

            var paginatedVouchers = vouchers.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalPages = (int)Math.Ceiling(vouchers.Count / (double)pageSize);

            var viewModel = new VoucherViewModel
            {
                Vouchers = paginatedVouchers,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }
    }
}
