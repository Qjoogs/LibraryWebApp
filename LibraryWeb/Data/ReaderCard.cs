using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Data
{
    public class ReaderCard
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime GetBookDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnBookDate { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

        public ICollection<Book> Books { get; set; }

        
    }
}
