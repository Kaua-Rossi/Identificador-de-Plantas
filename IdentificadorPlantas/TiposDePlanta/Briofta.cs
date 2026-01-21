using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas.TiposDePlanta
{
    public class Briofita : Planta
    {
        public Briofita(string n, string c) : base(n, c) { }

        public override string ObterCuriosidade()
        {
            return "São bioindicadores (só vivem onde o ar é puro) e retêm a umidade do solo.";
        }
    }
}
