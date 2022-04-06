using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Animal_Project.Controllers
{
    public class SpeciesController : ApiController
    {



        public IHttpActionResult Get()
        {
            var cService = CreateSpeciesService();
            var categories = cService.GetSpecies();
            return Ok(categories);
        }

        public IHttpActionResult Post(SpeciesCreate species)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var cService = CreateSpeciesService();
            if (!cService.CreateSpecies(species))
            {
                return InternalServerError();
            }
            return Ok();
        }
        
        public IHttpActionResult Delete(int id)
        {
            var service = CreateSpeciesSerice();

            if (!service.DeleteSpecies(id))
                return InternalServerError();

            return Ok();
        }

        private SpeciesService CreateSpeciesService()
        {
            var speciesService = new SpeciesService();
            return speciesService;
        }
    }
}
