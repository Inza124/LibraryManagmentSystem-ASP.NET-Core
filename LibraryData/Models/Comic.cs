using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
    public class Comic : LibraryAsset
    {
        [Required]
        public string Author { get; set; }

        public int Number { get; set; }
    }
}
