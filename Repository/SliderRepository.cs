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
  public class SliderRepository : Interfaces.IRepository<Sliders>, IDisposable
  {
    private DBEntityContext context;
    public SliderRepository(DBEntityContext context)
    {
      this.context = context;
    }
    public int Delete(int id)
    {
      var item = context.Sliders.Where(s => s.SliderId == id).SingleOrDefault();
      if (item != null)
      {
        context.Sliders.Remove(item);
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
      return context.Sliders.ToList();
    }

    public Sliders GetById(int id)
    {
      return context.Sliders.Where(s => s.SliderId == id).SingleOrDefault();
    }

    public int Insert(Sliders t)
    {
      context.Sliders.Add(t);
      return context.SaveChanges();
    }

    public IEnumerable<Sliders> Search(string searchString)
    {
      if (!string.IsNullOrEmpty(searchString))
      {
        return context.Sliders.Where(s => s.SliderName.Contains(searchString)).ToList();
      }
      return context.Sliders.ToList();
    }

    public int Update(Sliders t)
    {
      context.Entry(t).State = EntityState.Modified;
      return context.SaveChanges();
    }
  }
}
