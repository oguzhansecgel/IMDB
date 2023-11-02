using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Director
	{
		public int DirectorID { get; set; }	
		public string DirectorName { get; set; }
		public string DirectorSurname { get; set; }

		public ICollection<Film> FilmId { get; set; }

	}
}
