using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class OrderDetailService : Interfaces.IServices<OrderService>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderService> Filter(OrderService t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderService> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderService GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(OrderService t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderService> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderService t)
        {
            throw new NotImplementedException();
        }
    }
}
