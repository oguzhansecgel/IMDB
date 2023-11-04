using BusinessLayer.Abstract;
using BusinessLayer.Exceptions;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
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
		private readonly IUnitOfWork _unitOfWork;

		public FilmManager(IFilmDal filmDal, IUnitOfWork unitOfWork)
		{
			_filmDal = filmDal;
			_unitOfWork = unitOfWork;
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
			_unitOfWork.Save();
		}

		public void TInsert(Film t)
		{
			_filmDal.Insert(t);
			_unitOfWork.Save();
		}

		public void TUpdate(Film t)
		{
			_filmDal.Update(t);
			_unitOfWork.Save();
		}
	}
}
