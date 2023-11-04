using BusinessLayer.Abstract;
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
	public class DirectorManager : IDirectorService
	{
		private readonly IDirectorDal _directorDal;
		private readonly IUnitOfWork _unitOfWork;
		public DirectorManager(IDirectorDal directorDal, IUnitOfWork unitOfWork)
		{
			_directorDal = directorDal;
			_unitOfWork = unitOfWork;
		}

		public List<Director> TGetAll()
		{
			return _directorDal.GetAll();
		}

		public Director TGetById(int id)
		{
			return _directorDal.GetById(id);
		}

		public void TDelete(Director t)
		{
			var directoyExist = _directorDal.GetById(t.DirectorID);
			if(directoyExist is null)
			{
				throw new Exception($"{t.DirectorID} idli yönetmen bulunamadı");
			}
			_directorDal.Delete(t);
			_unitOfWork.Save();
		}

		public void TInsert(Director t)
		{
			_directorDal.Insert(t);
			_unitOfWork.Save();
		}

		public void TUpdate(Director t)
		{
			_directorDal.Update(t);
			_unitOfWork.Save();
		}
	}
}
