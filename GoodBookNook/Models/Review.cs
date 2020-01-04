using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        [StringLength(1000, MinimumLength = 10)]
        public string ReviewText { get; set; }
        public User Reviewer { get; set; }
    }
}
