using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieDetailsModel
    {
        public Movie movie;
		
		public List<Review> reviews;
    }
}
