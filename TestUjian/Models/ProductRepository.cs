using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestUjian.Data;
using TestUjian.Models;

namespace TestUjian.Models
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private DBKoneksi _db;
		public ProductRepository(DBKoneksi db) : base(db)
		{
			_db = db;


		}
	}
}
