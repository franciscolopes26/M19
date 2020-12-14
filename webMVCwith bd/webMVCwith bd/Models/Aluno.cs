using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webMVCwith_bd.Models
{
    public class Aluno
    {
        public int Naluno { get; set; }

        public string PriNome { get; set; }

        public string UltNome { get; set; }

        public string Morada { get; set; }

        public Genero genero { get; set; }

        public DateTime DataNasc { get; set; }

        public int AnoEscolaridade { get; set; }

        public string ImgPath { get; set; }


    }
}