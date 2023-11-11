using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ViewModel.FilmVM
{
    public class ResultFilmDto
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmDescription { get; set; }
        public int FilmYear { get; set; }
        public string CategoryName { get; set; }
        public string DirectorName { get; set; }
        public string DirectorSurname { get; set; }

    }
}
