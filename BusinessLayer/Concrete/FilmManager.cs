using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class FilmManager : IFilmService
	{
		private readonly IFilmDal _filmDal;

		public FilmManager(IFilmDal filmDal)
		{
			_filmDal = filmDal;
		}
		public List<Film> TGetAll()
		{
			return _filmDal.GetAll();
		}

		public Film TGetById(int id)
		{
			return _filmDal.GetById(id);
		}

		public void TDelete(Film t)
		{
			var filmExist = _filmDal.GetById(t.FilmId);
			_filmDal.Delete(filmExist);
		}

		public void TInsert(Film t)
		{
			_filmDal.Insert(t);
		}

		public void TUpdate(Film t)
		{
			_filmDal.Update(t);
		}
	}
}
