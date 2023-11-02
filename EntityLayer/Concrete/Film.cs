using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Film
	{
		public int FilmId { get; set; }
		public string FilmName { get; set; }
		public string FilmDescription { get; set;}
		public int FilmYear { get; set; }
		public int DirectorId { get; set; }
		public int CategoryId { get; set; }

		public Director Director { get; set; }
		public Category Category { get; set; }

	}
}
