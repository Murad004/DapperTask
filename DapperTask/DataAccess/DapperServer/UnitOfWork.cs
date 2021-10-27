using DapperTask.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTask.DataAccess.DapperServer
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository bookRepository => new BookRepository();
    }
}
