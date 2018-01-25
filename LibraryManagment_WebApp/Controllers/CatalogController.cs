using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryData;
using LibraryManagment_WebApp.Models.Catalog;

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
            var listingresult = assetModels
                .Select(result => new AssetIndexViewModel
                {
                    Id = result.Id,
                    Title = result.Title,
                    Author = _assets.GetAuthor(result.Id),
                    NumberOfCopies = result.NumberOfCopies,
                    BookIndex = _assets.GetBookIndex(result.Id),
                    ImageUrl = result.ImageUrl,
                    Type = _assets.GetType(result.Id),
                });

            var model = new AssetIndexModel()
            {
                Assets = listingresult
            };
        return View(model);
        }
    }
}
