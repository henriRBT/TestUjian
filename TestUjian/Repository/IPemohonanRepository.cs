using TestUjian.Models;

namespace TestUjian.Repository
{
	public interface IPemohonanRepository
	{
        IEnumerable<Permohonan> GetData();
    }
}
