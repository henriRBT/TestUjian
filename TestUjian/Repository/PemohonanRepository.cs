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
    public class PemohonanRepository : IPemohonanRepository
	{
        private DBKoneksi _db;
		public PemohonanRepository(DBKoneksi db)
		{
			_db = db;
		}

		public IEnumerable<Permohonan> GetData()
		{
			string sql = @"
			select b.no_pmh, a.nm_pbm , string_agg( b.mbrg_nama , ' ') as NAMA, SUM(b.jumlah) as jumlah  from training_permohonan a
			join training_permohonan_d b on a.no_pmh = b.no_pmh
			where a.status =1
			group by  b.no_pmh, a.nm_pbm
			order by a.nm_pbm ASC";

			return _db.permohonans.FromSqlRaw(sql).ToList();
		}
    }
}
