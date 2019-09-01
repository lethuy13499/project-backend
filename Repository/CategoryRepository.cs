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
 public class CategoryRepository : Interfaces.IRepository<Sliders>, IDisposable
  {
    private DBEntityContext context;
    public CategoryRepository(DBEntityContext context)
    {
      this.context = context;
    }

    public int Delete(int id)
    {
      var item = context.Categorys.Where(s => s.CategoryId == id).SingleOrDefault();
      if (item != null)
      {
        context.Categorys.Remove(item);
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

    public IEnumerable<Sliders> Filter(Sliders t)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Sliders> GetAll()
    {
      return context.Categorys.ToList();
    }

    public Sliders GetById(int id)
    {
      return context.Categorys.Where(s => s.CategoryId == id).SingleOrDefault();
    }

    public int Insert(Sliders t)
    {
      context.Categorys.Add(t);
      return context.SaveChanges();
    }

    public IEnumerable<Sliders> Search(string searchString)
    {
      if (!string.IsNullOrEmpty(searchString))
      {
        return context.Categorys.Where(s => s.CategoryName.Contains(searchString)).ToList();
      }
      return context.Categorys.ToList();
    }

    public int Update(Sliders t)
    {
      context.Entry(t).State = EntityState.Modified;
      return context.SaveChanges();
    }
  }
}
