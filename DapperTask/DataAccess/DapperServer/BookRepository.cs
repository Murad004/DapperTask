using Dapper;
using DapperTask.Abstraction;
using DapperTask.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTask.DataAccess.DapperServer
{
    class BookRepository : IBookRepository
    {
        public void AddData(Book data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Book data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Book> GetAllData()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();
            
            using (var connection=new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                books = connection.Query("select * from Books");
            }
        }

        public Book Getdata()
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Book data)
        {
            throw new NotImplementedException();
        }
    }
}
