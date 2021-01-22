using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParkAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ParkAPI.Controllers
{
  [Route("api/NationalParks")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private ParkAPIContext _db;
    public NationalParksController(ParkAPIContext db)
    {
      _db = db;
    }
    //GET api/nationalparks
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get()
    {
      return _db.NationalParks.ToList();
    }
    //POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark nationalPark)
    {
      _db.NationalParks.Add(nationalpark);
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
    public void Delet(int id)
    {
      var natlParkToDelete = _db.NationalParks.FirstOrDefault(e => e.NationalParkId == id);
      _db.NationalParks.Remove(natlParkToDelete);
      _db.SaveChanges();
    }
  }
}