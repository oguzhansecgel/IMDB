﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ViewModel.FilmVM
{
	public class CreateFilmVM
	{
		public string FilmName { get; set; }
		public string FilmDescription { get; set; }
		public int FilmYear { get; set; }
		public int DirectorId { get; set; }
		public int CategoryId { get; set; }
	}
}
