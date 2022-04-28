using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace GartenCenter2.BAL
{
    public partial class Lieferung
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "selected Article is required and must not be empty.")]
        public string selectedArticleId { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "selected Supplier is required and must not be empty.")]
        public string selectedSupplierId { get; set; }  


        public int LieferantId { get; set; }

        [Required(ErrorMessage = "Day Of Delivery is required and must not be empty.")]
        public DateTime? DayOfDelivery { get; set; }


        [Range (1, 500)]   
        [Required(ErrorMessage = "Amount is required and must not be empty.")]
        public int Amount { get; set; }

        public virtual Article Article { get; set; }
        public virtual Lieferant Lieferant { get; set; }
    }
}
