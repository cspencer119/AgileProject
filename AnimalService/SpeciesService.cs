using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Project.Models;

namespace AnimalService
{
    public class SpeciesService
    {
        public bool CreateSpecies(SpeciesCreate model)
        {
            var entity =
                new Species()
                {
                    SpeciesId = model.SpeciesId,
                    SpeciesName = model.SpeciesName,
                    SpeciesDetail = model.SpeciesDetail
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Species.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
