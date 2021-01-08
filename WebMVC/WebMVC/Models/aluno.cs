using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class aluno
    {
        [Required]
        [Display(Name ="Numero do Aluno")]
        public int Naluno { get; set; }

        [Required]
        [Display(Name = "Primeiro Nome")]
        public string PriNome { get; set; }

        [Required]
        [Display(Name = "Ultimo Nome")]
        public string UltNome { get; set; }
        [Required]
        
        public string Morada { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DataNasc { get; set; }
        [Required]
        [Display(Name = "Ano de escolaridade")]
        [Range(1,12)]
        public int AnoEscolaridade { get; set; }
        [Display(Name = "Imagem")]
        public string ImgPath { get; set; }

        public HttpPostedFileBase imagem { get; set; }
    }

}