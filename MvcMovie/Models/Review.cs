using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Review
    { 

        public int ReviewID { get; set; }
    
        public int MovieID { get; set; }

        [Display(Name="Reviewer")]
        public String ReviewerName { get; set; }

        public String Comment { get; set; }
    }
}
