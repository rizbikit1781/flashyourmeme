using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace flashyourmeme.Controllers
{
    [Route("Voucher")]
    public class VoucherController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("Index")]
        public IActionResult Index(int page = 1, int pageSize = 8)
        {
            var vouchers = new List<VoucherModel>
            {
                new VoucherModel { No = 1, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 1" },
                new VoucherModel { No = 2, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 2" },
                new VoucherModel { No = 3, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 3" },
                new VoucherModel { No = 4, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 4" },
                new VoucherModel { No = 5, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 5" },
                new VoucherModel { No = 6, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 6" },
                new VoucherModel { No = 7, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 7" },
                new VoucherModel { No = 8, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 8" },
                new VoucherModel { No = 9, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 9" },
                new VoucherModel { No = 10, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 10" },
                new VoucherModel { No = 11, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 11" },
                new VoucherModel { No = 12, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 12" }
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

        [HttpGet]
        [Route("SubItem/{id}")]
        public IActionResult SubItem(int id, int page = 1, int pageSize = 8)
        {
            var selectedVoucher = GetVouchers().FirstOrDefault(v => v.No == id);
            if (selectedVoucher == null)
            {
                return NotFound();
            }

            var allSubItems = GetSubItems(id);
            var paginatedSubItems = allSubItems.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalPages = (int)Math.Ceiling(allSubItems.Count / (double)pageSize);

            var model = new SubItemViewModel
            {
                SubItems = paginatedSubItems,
                VoucherId = id,
                BranchName = selectedVoucher.BranchName,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(model);
        }

        private List<VoucherModel> GetVouchers()
        {
            return new List<VoucherModel>
            {
                new VoucherModel { No = 1, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 1" },
                new VoucherModel { No = 2, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 2" },
                new VoucherModel { No = 3, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 3" },
                new VoucherModel { No = 4, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 4" },
                new VoucherModel { No = 5, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 5" },
                new VoucherModel { No = 6, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 6" },
                new VoucherModel { No = 7, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 7" },
                new VoucherModel { No = 8, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 8" },
                new VoucherModel { No = 9, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 9" },
                new VoucherModel { No = 10, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 10" },
                new VoucherModel { No = 11, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 11" },
                new VoucherModel { No = 12, ProfileImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchName = "Branch 12" }
            };
        }

        private List<SubItem> GetSubItems(int voucherId)
        {
            // Replace with your data retrieval logic
            return new List<SubItem>
            {
                new SubItem { No = 1, EventName = "Event 1" },
                new SubItem { No = 2, EventName = "Event 2" },
                new SubItem { No = 3, EventName = "Event 3" },
                new SubItem { No = 4, EventName = "Event 4" },
                new SubItem { No = 4, EventName = "Event 5" },
                new SubItem { No = 4, EventName = "Event 6" },
                new SubItem { No = 4, EventName = "Event 7" },
                new SubItem { No = 4, EventName = "Event 8" },
                new SubItem { No = 4, EventName = "Event 9" },
                new SubItem { No = 4, EventName = "Event 10" },
                new SubItem { No = 4, EventName = "Event 11" },
                new SubItem { No = 4, EventName = "Event 12" },

            };
        }
    }
}
