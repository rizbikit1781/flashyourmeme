using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Route("filters")]
public class FilterController : Controller
{
    private const int PageSize = 6;

    [HttpGet("")]
    public IActionResult Index(int page = 1)
    {
        var filters = new List<FilterModel>
        {
            new FilterModel { No = 1, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file1.txt" },
            new FilterModel { No = 2, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file2.txt" },
            new FilterModel { No = 3, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file3.txt" },
            new FilterModel { No = 4, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file4.txt" },
            new FilterModel { No = 5, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file5.txt" },
            new FilterModel { No = 6, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file6.txt" },
            new FilterModel { No = 7, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file7.txt" },
            new FilterModel { No = 8, FilterImageUrl = "https://www.svgrepo.com/show/508699/landscape-placeholder.svg", FileName = "file8.txt" },
            // Add more filter models here
        };

        var paginatedFilters = filters.Skip((page - 1) * PageSize).Take(PageSize).ToList();
        var totalPages = (int)Math.Ceiling(filters.Count / (double)PageSize);

        var viewModel = new FilterViewModel
        {
            Filters = paginatedFilters,
            CurrentPage = page,
            TotalPages = totalPages
        };

        return View(viewModel);
    }
}