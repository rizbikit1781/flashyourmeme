using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;

namespace flashyourmeme.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 8)
        {
            var branches = new List<BranchModel>
        {
            new BranchModel { No = 1, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch1" },
            new BranchModel { No = 2, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch2" },
            new BranchModel { No = 3, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch3" },
            new BranchModel { No = 4, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch4" },
            new BranchModel { No = 5, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch5" },
            new BranchModel { No = 6, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch6" },
            new BranchModel { No = 7, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch7" },
            new BranchModel { No = 8, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch8" },
            new BranchModel { No = 9, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch9" },
            new BranchModel { No = 10, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch10" },
            new BranchModel { No = 11, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch11" },
            new BranchModel { No = 12, BranchImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", BranchNames = "Branch12" },

        };

            var paginatedBranches = branches.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalPages = (int)Math.Ceiling(branches.Count / (double)pageSize);

            var viewModel = new BranchViewModel
            {
                Branches = paginatedBranches,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }
    }
}
