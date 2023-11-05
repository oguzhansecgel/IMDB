using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ViewModel.SeriesVM
{
	public class UpdateSeriesVM
	{
		public int SeriesId { get; set; }
		public string SeriesName { get; set; }
		public string SeriesDescription { get; set; }
		public int SeriesYear { get; set; }
		public int CategoryId { get; set; }
		public int DirectorId { get; set; }
	}
}
