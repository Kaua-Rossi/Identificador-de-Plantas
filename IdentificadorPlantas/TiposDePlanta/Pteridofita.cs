using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas.TiposDePlanta
{
    public class Pteridofita : Planta
    {
        public Pteridofita(string n, string c) : base(n, c) { }

        public override string ObterCuriosidade()
        {
            return "Alto valor ornamental (paisagismo) e histórico (formação de combustíveis fósseis).";
        }
    }
}
