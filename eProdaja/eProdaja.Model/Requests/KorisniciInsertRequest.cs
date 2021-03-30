using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Ime { get; set; }


        [MinLength(3)]
        [MaxLength(20)]
        public string Prezime { get; set; }



        [Required(AllowEmptyStrings =false)]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        //regex
        //[RegularExpression("/(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8}/g",
        // ErrorMessage = "Password must meet requirements")]
        public string Lozinka { get; set; }

    }
}
