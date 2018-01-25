using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }
        public virtual LibraryBranch LibraryBranch{ get; set; }
    }
}
