using DataAccessLayer;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
 public class OrderRepository :IOrderRepository<Orders>, IDisposable
  {
    private DBEntityContext context;
    public OrderRepository(DBEntityContext context)
    {
      this.context = context;
    }
    public int Delete(int id)
    {
      var item = context.Order.Where(s => s.OrderId == id).SingleOrDefault();
      if (item != null)
      {
        context.Order.Remove(item);
        return context.SaveChanges();
      }
      return 0;
    }
    private bool disposed = false;
    public void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          context.Dispose();
        }
      }
      this.disposed = true;
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    public IEnumerable<Orders> Filter(Orders t)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Orders> GetAll()
    {
      return context.Order.ToList();
    }

    public Orders GetById(int id)
    {
      return context.Order.Where(s => s.OrderId == id).SingleOrDefault();
    }

    public IEnumerable<OrderDetail> GetDetail(int id)
    {
      //return context.OrderDetails.Where(s => s.OrderId == id).SingleOrDefault();
      throw new NotImplementedException();
    }
    public int Insert(Orders t)
    {
      context.Order.Add(t);
      return context.SaveChanges();
    }

    public IEnumerable<Orders> Search(int id) {

      throw new NotImplementedException();


    }

    public int Update(Orders t)
    {
     context.Entry(t).State = EntityState.Modified;
      return context.SaveChanges();
    }
  }
}
