using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment_WebApp.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexViewModel> Assets { get; set; }
    }
}
