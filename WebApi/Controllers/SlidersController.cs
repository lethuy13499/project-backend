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
  public class SlidersController : ApiController
    {
    private SliderService service;

    public SlidersController()
    {
      service = new SliderService();
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
          var user = JsonConvert.DeserializeObject<Sliders>(value.ToString());
          result.Success = service.Insert(user);
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
