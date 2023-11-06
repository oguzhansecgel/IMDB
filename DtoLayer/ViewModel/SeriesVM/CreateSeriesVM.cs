using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ViewModel.SeriesVM
{
	public class CreateSeriesVM
	{
        [Required(ErrorMessage = "Ürün Adı Boş Bırakılamaz.")]
        public string SeriesName { get; set; }
		public string SeriesDescription { get; set; }
		public int SeriesYear { get; set; }
		public int CategoryId { get; set; }
		public int DirectorId { get; set; }
	}
}
