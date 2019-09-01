using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
  public interface IOrderRepository<T> where T : class
  {
    IEnumerable<T> GetAll();
    IEnumerable<T> Search(int id);
    IEnumerable<T> Filter(T t);
    int Insert(T t);
    int Update(T t);
    int Delete(int id);
    T GetById(int id);
    IEnumerable<OrderDetail> GetDetail(int id);

  }
}
