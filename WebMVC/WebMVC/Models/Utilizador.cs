using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Utilizador
    {
        public int MUtilizador { get; }
        [Display(Name="E-Mail")]
        [DataType(DataType.EmailAddress)]

        public string email { get; set; }
        [DataType(DataType.Password)]

        public string password { get; set; }
    }
}