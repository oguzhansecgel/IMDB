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
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;
		private readonly IUnitOfWork _unitOfWork;
		public CategoryManager(ICategoryDal categoryDal, IUnitOfWork unitOfWork)
		{
			_categoryDal = categoryDal;
			_unitOfWork = unitOfWork;
		}

		public List<Category> TGetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category TGetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public void TDelete(Category t)
		{
			var categoryExist = _categoryDal.GetById(t.CategoryId);
			if(categoryExist is null) 
			{
				throw new Exception($"{t.CategoryId} idli kategori bulunamadı");
			}
			_categoryDal.Delete(t);
			_unitOfWork.Save();
		}

		public void TInsert(Category t)
		{
			_categoryDal.Insert(t);
			_unitOfWork.Save();
		}

		public void TUpdate(Category t)
		{
			_categoryDal.Update(t);
			_unitOfWork.Save();
		}
	}
}
