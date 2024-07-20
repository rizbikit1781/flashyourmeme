using System.Collections.Generic;

namespace flashyourmeme.Models
{
    public class PhotoViewModel
    {
        public List<Photo> Photos { get; set; }
        public PaginationModel Pagination { get; set; }
    }

    public class PaginationModel
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

}
