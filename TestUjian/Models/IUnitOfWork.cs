
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUjian.Models;

namespace TestUjian.Models
{
    public interface IUnitOfWork 
    {
      
        IProductRepository Product { get; }
        void Save();
    }
}
