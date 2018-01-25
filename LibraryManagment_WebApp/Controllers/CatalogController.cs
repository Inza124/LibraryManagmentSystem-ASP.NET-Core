using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryData;

namespace LibraryManagment_WebApp.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;

        public CatalogController(ILibraryAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();
        }
    }
}
