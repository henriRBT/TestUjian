

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUjian.Data;


namespace TestUjian.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBKoneksi _db;
        
        public IProductRepository Product { get; private set; }
        public UnitOfWork(DBKoneksi db)
        {
            _db = db;
            Product = new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
