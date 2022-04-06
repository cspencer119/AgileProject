using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModel
{
    public class AnimalCreate
    {
        [Required]
        public string NameCommon { get; set; }
        [MaxLength(25)]

        [Required]
        public string NameScientific { get; set; }
        [MaxLength(65)]

        [Required]
        public string FunFacts { get; set; }
        [MaxLength(300)]

    }
}
