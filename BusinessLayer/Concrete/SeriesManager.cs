using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SeriesManager : ISeriesService
	{
		private readonly ISeriesDal _seriesDal;
		private readonly IUnitOfWork _unitOfWork;

		public SeriesManager(ISeriesDal seriesDal, IUnitOfWork unitOfWork)
		{
			_seriesDal = seriesDal;
			_unitOfWork = unitOfWork;
		}

		public List<Series> TGetAll()
		{
			return _seriesDal.GetAll();
		}

		public Series TGetById(int id)
		{
			return _seriesDal.GetById(id);
		}
		public void TDelete(Series t)
		{
			_seriesDal.Delete(t);
			_unitOfWork.Save();
		}

		public void TInsert(Series t)
		{
			_seriesDal.Insert(t);
			_unitOfWork.Save();
		}

		public void TUpdate(Series t)
		{
			_seriesDal.Update(t);
			_unitOfWork.Save();

		}
	}
}
