using DataAccessLayer;
using Model;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public class OrderService : Interfaces.IServices<Orders>
  {
    private IOrderRepository<Orders> repository;

    public OrderService()
    {
      repository = new OrderRepository(new DBEntityContext());
    }

    public int Delete(int id)
    {
      return repository.Delete(id);
    }

    public IEnumerable<Orders> Filter(Orders t)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Orders> GetAll()
    {
      return repository.GetAll();
    }

    public Orders GetById(int id)
    {
      return repository.GetById(id);
    }

    public int Insert(Orders t)
    {
      return repository.Insert(t);
    }

    public IEnumerable<Orders> Search(string searchString)
    {
      throw new NotImplementedException();
    }

    public int Update(Orders t)
    {
      return repository.Update(t);
    }
  }
}
