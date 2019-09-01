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
  public class SliderService : Interfaces.ISliderService<Sliders>
  {
    private IRepository <Sliders> repository;

    public SliderService()
    {
      repository = new SliderRepository(new DBEntityContext());
    }
    public int Delete(int id)
    {
      return repository.Delete(id);
    }

    public IEnumerable<Sliders> Filter(Sliders t)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Sliders> GetAll()
    {
      return repository.GetAll();
    }

    public Sliders GetById(int id)
    {
      return repository.GetById(id);
    }

    public int Insert(Sliders t)
    {
      return repository.Insert(t);
    }

    public IEnumerable<Sliders> Search(string searchString)
    {
      return repository.Search(searchString);
    }

    public int Update(Sliders t)
    {
      return repository.Update(t);
    }
  }
}
