using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestUjian.Data;
using TestUjian.Models;

namespace TestUjian.Repository
{
    public class ProductRepository : IProductRepository
    {
        private DBKoneksi _db;
		public ProductRepository(DBKoneksi db)
		{
			_db = db;
		}

		public IEnumerable<Product> GetPermohonanData()
		{
			string sql = @"
            select b.no_pmh, b.mbrg_kemasan, b.kd_satuan, SUM(b.jumlah) AS jumlah from training_permohonan a
			join training_permohonan_d b on a.no_pmh = b.no_pmh
			group by b.no_pmh, b.mbrg_kemasan, b.kd_satuan";

			return _db.Products.FromSqlRaw(sql).ToList();
		}
    }
}
