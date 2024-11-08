using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestUjian.Models;

namespace TestUjian.Data
{
	public class DBKoneksi:  IdentityDbContext<IdentityUser>
	{
		public DBKoneksi(DbContextOptions<DBKoneksi> options) : base(options)
		{
		}
		public DbSet<Product> Products { get; set; }
	}
}
