using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using ParkAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ParkAPI.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/stateparks")]
  [ApiController]
  public class StateParksV1Controller : ControllerBase
  {
    private ParkAPIContext _db;
    public StateParksV1Controller(ParkAPIContext db)
    {
      _db = db;
    }
    //GET api/stateparks
    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get()
    {
      return _db.StateParks.ToList();
    }
    //GET api/stateParks/random
    [HttpGet]
    [Route("random")]
    public ActionResult<StatePark> Random()
    {
      Random random = new Random();
      int someStatePark = random.Next(_db.StateParks.ToList().Count);
      return _db.StateParks.FirstOrDefault(e => e.StateParkId == someStatePark);
    }
    //POST api/stateparks
    [HttpPost]
    public void Post([FromBody] StatePark statePark)
    {
      _db.StateParks.Add(statePark);
      _db.SaveChanges();
    }
    //GET api/stateparks/{id}
    [HttpGet("{id}")]
    public ActionResult<StatePark> Get(int id)
    {
      return _db.StateParks.FirstOrDefault(e => e.StateParkId == id);
    }
    //PUT api/stateparks/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark statePark)
    {
      statePark.StateParkId = id;
      _db.Entry(statePark).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/stateparks/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateParkToDelete = _db.StateParks.FirstOrDefault(e => e.StateParkId == id);
      _db.StateParks.Remove(stateParkToDelete);
      _db.SaveChanges();
    }
  }
  [ApiVersion("2.0")]
  [Route("api/{Version:apiVersion}/stateParks")]
  [ApiController]
  public class StateParksV2Controller : ControllerBase
  {
    private ParkAPIContext _db;
    public StateParksV2Controller(ParkAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get(string name, string state)
    {
      var query = _db.StateParks.AsQueryable();

      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }
      if (state != null)
      {
        query = query.Where(e => e.State == state);
      }
      return query.ToList();
    }
  }
}