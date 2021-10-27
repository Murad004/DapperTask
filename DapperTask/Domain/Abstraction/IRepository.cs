using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTask.Abstraction
{
    public interface IRepository<T>
    {
        ObservableCollection<T> GetAllData();
        T Getdata();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
