using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GartenCenter2.BAL
{
    public partial class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required and must not be empty.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "ErrorMessage is required and must not be empty.")]
        public string Password { get; set; }
    }
}
