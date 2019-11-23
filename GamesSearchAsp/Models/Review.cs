using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [MaxLength(100)]
        [Display(Name = "User email")]
        public string UserEmail { get; set; }
        public int GameId { get; set; }
        public string UserName { get; set; }
    }
}
