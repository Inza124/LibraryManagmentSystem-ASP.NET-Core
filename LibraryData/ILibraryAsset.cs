﻿using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int id);
        void Add(LibraryAsset asset);
        string GetAuthor(int id);
        string GetBookIndex(int id);
        string GetType(int id);
        string GetTitle(int id);

        LibraryBranch GetCurrentLocation(int id);
    }
}
