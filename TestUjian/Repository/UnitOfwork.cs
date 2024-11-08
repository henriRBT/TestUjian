using Microsoft.EntityFrameworkCore;
using TestUjian.Data;
using TestUjian.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TestUjian.Repository
{
	public class UnitOfwork : IUnitOfWork
	{
		private DBKoneksi _db;
		public IProductRepository Product { get; private set; }
		public IPemohonanRepository Pemohonan { get; private set; }
		public UnitOfwork(DBKoneksi db)
		{
			_db = db;
			Product = new ProductRepository(_db);
			Pemohonan = new PemohonanRepository(_db);
		}
		
		public IEnumerable<Product> GetPermohonanData()
		{
			return Product.GetPermohonanData();
		}
		public IEnumerable<Permohonan> GetData()
		{
			return Pemohonan.GetData();
		}


		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
