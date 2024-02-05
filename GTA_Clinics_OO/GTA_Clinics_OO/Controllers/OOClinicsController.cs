using GTA_Clinics_OO.MyData;
using GTA_Clinics_OO.OOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTA_Clinics_OO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OOClinicsController : ControllerBase
    {
        private IClinicData _clinidata;
        public OOClinicsController(IClinicData clinicData)
        {
            _clinidata = clinicData;
        }
        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetClinic()
        {
          return Ok(_clinidata.GetClinicss());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetClinic(Guid id)
        {
            var clinic  = _clinidata.GetClinic(id); 

            if (clinic != null)
            {
                return Ok(clinic);
            }
            return NotFound($"clinicwith Id: {id} was not found");
        }
        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult GetEmployee(ClinicOO clinic) 
        {
            _clinidata.AddClinic(clinic);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + clinic.Id, clinic);
        }

    }
}

