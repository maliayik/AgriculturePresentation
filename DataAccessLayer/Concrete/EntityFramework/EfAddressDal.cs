﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
	public class EfAddressDal : GenericRepository<Address>, IAddressDal
	{
	}
}
