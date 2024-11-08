namespace TestUjian.Repository
{
	public interface IUnitOfWork
	{
		IProductRepository Product { get; }
        IPemohonanRepository Pemohonan { get; }
    }
}
