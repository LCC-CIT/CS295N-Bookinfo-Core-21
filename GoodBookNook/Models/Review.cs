using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string ReviewText { get; set; }
        public User Reviewer { get; set; }
    }
}
