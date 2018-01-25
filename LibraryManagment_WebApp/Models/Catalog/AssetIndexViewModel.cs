using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment_WebApp.Models.Catalog
{
    public class AssetIndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        public int NumberOfCopies { get; set; }
        public string Type { get; set; }
        public string BookIndex { get; set; }
    }
}
