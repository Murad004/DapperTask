using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTask.Abstraction
{
    public interface IUnitOfWork
    {
         IBookRepository bookRepository { get; }
    }
}
