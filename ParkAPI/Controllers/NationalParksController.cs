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
  [Route("api/nationalparks")]
  [ApiController]
  public class NationalParksV1Controller : ControllerBase
  {
    private ParkAPIContext _db;
    public NationalParksV1Controller(ParkAPIContext db)
    {
      _db = db;
    }
    //GET api/nationalparks
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get()
    {
      return _db.NationalParks.ToList();
    }
    //GET api/nationalParks/random
    [HttpGet]
    [Route("random")]
    public ActionResult<NationalPark> Random()
    {
      Random random = new Random();
      int someNationalPark = random.Next(_db.NationalParks.ToList().Count);
      return _db.NationalParks.FirstOrDefault(e => e.NationalParkId == someNationalPark);
    }
    //POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark nationalPark)
    {
      _db.NationalParks.Add(nationalPark);
      _db.SaveChanges();
    }
    //GET api/nationalparks/{id}
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
      return _db.NationalParks.FirstOrDefault(e => e.NationalParkId == id);
    }
    //PUT api/nationalparks/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark nationalPark)
    {
      nationalPark.NationalParkId = id;
      _db.Entry(nationalPark).State = EntityState.Modified;
      _db.SaveChanges();
    }
    //DELETE api/nationalparks/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var natlParkToDelete = _db.NationalParks.FirstOrDefault(e => e.NationalParkId == id);
      _db.NationalParks.Remove(natlParkToDelete);
      _db.SaveChanges();
    }
  }
  [ApiVersion("2.0")]
  [Route("api/{Version:apiVersion}/nationalParks")]
  [ApiController]
  public class NationalParksV2Controller : ControllerBase
  {
    private ParkAPIContext _db;
    public NationalParksV2Controller(ParkAPIContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get(string name, string state)
    {
      var query = _db.NationalParks.AsQueryable();

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