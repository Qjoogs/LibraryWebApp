using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Data
{
    public class Book
    {
        [Required]
        
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Автор")]
        public string AuthorName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Издателство")]
        public string PublisherName { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Жанр")]
        public string GenreName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата на излизане")]
        public DateTime Date { get; set; }

        
        [Required]
        public bool Taken { get; set; }


    }
}
