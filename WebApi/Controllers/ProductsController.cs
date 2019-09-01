using Model;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  public class ProductsController : ApiController
    {
    private ProductService service;

    public ProductsController()
    {
      service = new ProductService();
    }
    [HttpGet]
   // [ValidateSSID(ActionId = 50)]
    public string Get()
    {
      var result = service.GetAll().ToList();
      // return JsonConvert.SerializeObject(result);
      return JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
      {
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
      });
    }
    [HttpGet]
    //[ValidateSSID(ActionId = 51)]
    public string Get(int id)
    {

      var result = service.GetById(id);
      return JsonConvert.SerializeObject(result, Formatting.Indented, new JsonSerializerSettings
      {
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
      });


    }
    [HttpPost]
    //[ValidateSSID(ActionId = 52)]
    public string Get([FromUri]string action, [FromBody]string value)
    {
      if (value != null && !"".Equals(value))
      {
        if ("search".Equals(action))
        {
          return JsonConvert.SerializeObject(service.Search(value));
        }
        
      }
      return "NULL VALUE";
    }
    [HttpPost]
    //[ValidateSSID(ActionId = 53)]
    public string Post([FromBody]object value)
    {
      ResultObject result = new ResultObject();
      try
      {
        if (value != null)
        {
          var question = JsonConvert.DeserializeObject<Product>(value.ToString());
          result.Success = service.Insert(question);
          return JsonConvert.SerializeObject(result);
        }
      }
      catch (Exception e)
      {
        result.Message = "EXCEPTION: " + e.Message + "Stack: " + e.StackTrace;
        return JsonConvert.SerializeObject(result);
      }

      return JsonConvert.SerializeObject(result);
    }
    [HttpPut]
    //[ValidateSSID(ActionId = 51)]
    public string Put(int id, [FromBody]object value)
    {
      ResultObject result = new ResultObject();
      try
      {
        if (value != null)
        {
          var category = JsonConvert.DeserializeObject<Product>(value.ToString().Trim());
          category.CategoryId = id;
          result.Success = service.Update(category);
          return JsonConvert.SerializeObject(result);
        }

      }
      catch (Exception e)
      {
        result.Message = "EXCEPTION: " + e.Message + "Stack: " + e.StackTrace;
        return JsonConvert.SerializeObject(result);
      }
      result.Message = "Null content";
      return JsonConvert.SerializeObject(result);
    }

    [HttpDelete]
    //[ValidateSSID(ActionId = 52)]
    public string Put(int id)
    {
      ResultObject result = new ResultObject();
      try
      {
        result.Success = service.Delete(id);
        return JsonConvert.SerializeObject(result);

      }

      catch (Exception e)
      {
        result.Message = "EXCEPTION: " + e.Message + "Stack: " + e.StackTrace;
        return JsonConvert.SerializeObject(result);
      }




    }

  }
}
