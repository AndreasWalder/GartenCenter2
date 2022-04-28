using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace GartenCenter2.BAL
{
    public partial class Article
    {
        public Article()
        {
            Lieferungs = new HashSet<Lieferung>();
        }

        public int Id { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "selected category is required and must not be empty.")]
        public string selectedCategoryId { get; set; }    

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required and must not be empty.")]
        public string Name { get; set; }

        [Range (1, 1000)]   
        public double Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Lieferung> Lieferungs { get; set; }
    }
}
