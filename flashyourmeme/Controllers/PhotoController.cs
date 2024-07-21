using flashyourmeme.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace flashyourmeme.Controllers
{
    public class PhotoController : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 12)
        {
            // Mock data
            var photos = new List<Photo>();
            for (int i = 1; i <= 50; i++)
            {
                photos.Add(new Photo
                {
                    Id = i,
                    Date = DateTime.Now.AddDays(-i),
                    Time = DateTime.Now.TimeOfDay,
                    Branch = "Branch " + (i % 3 + 1),
                    PreviewUrl = "#",
                    LinkUrl = "#"
                });
            }

            var pagedPhotos = photos
                .OrderBy(p => p.Date) // Adjust the order by clause based on your requirements
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalPhotos = photos.Count;

            var viewModel = new PhotoViewModel
            {
                Photos = pagedPhotos,
                Pagination = new PaginationModel
                {
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalPhotos / (double)pageSize)
                }
            };

            return View(viewModel);
        }
    }
}
