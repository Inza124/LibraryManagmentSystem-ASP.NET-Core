using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext _context;
        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }
        public void Add(LibraryAsset asset)
        {
            _context.Add(asset);
            _context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(assets => assets.Status)
                .Include(assets => assets.Location);
        }

        public string GetAuthor(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>()
                .Where(asset => asset.Id == id).Any();

            var isComic = _context.LibraryAssets.OfType<Comic>()
                .Where(assets => assets.Id == id).Any();

            var isMagazine = _context.LibraryAssets.OfType<Magazine>()
                .Where(assets => assets.Id == id).Any();

            return isBook ?
                _context.Books.FirstOrDefault(book => book.Id == id).Author :
                _context.Comics.FirstOrDefault(comics => comics.Id == id).Author
                ?? "Unknown";
        }

        public string GetBookIndex(int id)
        {
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books.FirstOrDefault(book => book.Id == id).BookIndex;
            }
            else return "";
        }

        public LibraryAsset GetById(int id)
        {
            return _context.LibraryAssets
                .Include(assets => assets.Status)
                .Include(assets => assets.Location)
                .FirstOrDefault(asset => asset.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(assets => assets.Id == id).Location;
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(assets => assets.Id == id).Title;
        }

        public string GetType(int id)
        {
            throw new NotImplementedException();
        }
    }
}
