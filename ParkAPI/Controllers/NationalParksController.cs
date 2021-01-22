using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParkAPI.Models;

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
  }
}