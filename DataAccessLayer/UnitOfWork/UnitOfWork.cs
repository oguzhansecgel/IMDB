﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly Context _context;

		public UnitOfWork(Context context)
		{
			_context = context;
		}

		public void Save()
		{
			_context.SaveChanges();
			
		}
	}
}
