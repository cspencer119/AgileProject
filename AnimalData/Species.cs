using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalData
{
    public class Species
    {
        [Key]
        public int SpeciesId { get; set; }

        [Required]
        public string SpeciesName { get; set; }
        [Required]
        public string SpeciesDetail { get; set; }
    }
}
