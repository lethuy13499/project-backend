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
 public  class ProductService : Interfaces.IServices<Product>
  {
    private IRepository<Product> repository;
    public ProductService()
    {
      repository = new ProductRepository(new DBEntityContext());
    }
    public int Delete(int id)
    {
      return repository.Delete(id);
    }

    public IEnumerable<Product> Filter(Product t)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll()
    {
      return repository.GetAll();
    }

    public Product GetById(int id)
    {
      return repository.GetById(id);
    }

    public int Insert(Product t)
    {
      return repository.Insert(t);
    }

    public IEnumerable<Product> Search(string searchString)
    {
      return repository.Search(searchString);
    }

    public int Update(Product t)
    {
      return repository.Update(t);
    }
  }
}
