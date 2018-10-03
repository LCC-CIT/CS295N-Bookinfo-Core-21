using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodBookNook.Models
{
    public class Review
    {
        public string ReviewText { get; set; }
        public Book ReviewedBook { get; set; }
        public User Reviewr { get; set; }
    }
}
