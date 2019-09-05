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
  public class OrderDetailService : Interfaces.IServices<OrderDetail>
    {
        private IRepository<OrderDetail> repository;

        public OrderDetailService()
        {
            repository = new OrderDetailRepository(new DBEntityContext());
        }
        public int Delete(int id)
        {
            return repository.Delete(id);
        }

        public IEnumerable<OrderDetail> Filter(OrderDetail t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return repository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return repository.GetById(id);
        }

        public int Insert(OrderDetail t)
        {
            return repository.Insert(t);
        }

        public IEnumerable<OrderDetail> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderDetail t)
        {
            return repository.Update(t);
        }
    }
}
