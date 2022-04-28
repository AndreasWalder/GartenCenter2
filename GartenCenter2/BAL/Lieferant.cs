using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GartenCenter2.BAL
{
    public partial class Lieferant
    {
        public Lieferant()
        {
            Lieferungs = new HashSet<Lieferung>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required and must not be empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Country is required and must not be empty.")]
        public string Country { get; set; }

        public virtual ICollection<Lieferung> Lieferungs { get; set; }
    }
}
