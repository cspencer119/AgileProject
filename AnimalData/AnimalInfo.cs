using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalData
{
    public class AnimalInfo
    {
        [Key]
        public int AnimalId { get; set; }

        [Required]
        public string NameCommon { get; set; }
        [Required]
        public string NameScientific { get; set; }
        [Required]
        public string FunFacts { get; set; }

        [ForeignKey(nameof(Species))]
        public int SpeciesId { get; set; }
        public Species Species { get; set; }
    }
}
