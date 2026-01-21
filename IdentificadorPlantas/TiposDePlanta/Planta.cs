using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas.TiposDePlanta
{
    public abstract class Planta
    {
        public string NomePopular { get; set; }
        public string NomeCientifico { get; set; }
        public Planta(string popular, string cientifico)
        {
            NomePopular = popular;
            NomeCientifico = cientifico;
        }

        public abstract string ObterCuriosidade();
    }
}
