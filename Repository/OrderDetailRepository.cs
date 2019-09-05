using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public  class OrderDetailRepository : Interfaces.IRepository<OrderDetail>, IDisposable
    {
        private DBEntityContext context;
        public OrderDetailRepository(DBEntityContext context)
        {
            this.context = context;
        }
        public int Delete(int id)
        {
            var item = context.OrderDetails.Where(s => s.OrderId == id).SingleOrDefault();
            if (item != null)
            {
                context.OrderDetails.Remove(item);
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

        public IEnumerable<OrderDetail> Filter(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return context.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            return context.OrderDetails.Where(s => s.OrderId == id).SingleOrDefault();
        }

        public int Insert(OrderDetail t)
        {
            context.OrderDetails.Add(t);
            return context.SaveChanges();
        }

        public IEnumerable<OrderDetail> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderDetail t)
        {
            context.Entry(t).State = EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
