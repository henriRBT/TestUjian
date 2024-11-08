using TestUjian.Models;

namespace TestUjian.Repository
{
	public interface IProductRepository 
	{
		IEnumerable<Product> GetPermohonanData();
    }
}
