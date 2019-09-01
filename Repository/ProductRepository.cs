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
  public class ProductRepository : Interfaces.IRepository<Product>, IDisposable
  {
    private DBEntityContext context;
    public ProductRepository(DBEntityContext context)
    {
      this.context = context;
    }
    public int Delete(int id)
    {
      var item = context.Products.Where(s => s.ProductId == id).SingleOrDefault();
      if (item != null)
      {
        context.Products.Remove(item);
        return context.SaveChanges();
      }
      return 0;
    }

    public void Dispose()
    {
     
    }

    public IEnumerable<Product> Filter(Product t)
    {
      throw new NotImplementedException();
    }


    public IEnumerable<Product> GetAll()
    {
      return context.Products.ToList();
    }

    public Product GetById(int id)
    {
      return context.Products.Where(s => s.ProductId == id).SingleOrDefault();
    }

    public int Insert(Product t)
    {
      context.Products.Add(t);
      return context.SaveChanges();
    }

    public IEnumerable<Product> Search(string searchString)
    {
      if (!string.IsNullOrEmpty(searchString))
      {
        return context.Products.Where(s => s.ProductName.Contains(searchString)).ToList();
      }
      return context.Products.ToList();
    }

    public int Update(Product t)
    {
      context.Entry(t).State = EntityState.Modified;
      return context.SaveChanges();
    }
  }
}
