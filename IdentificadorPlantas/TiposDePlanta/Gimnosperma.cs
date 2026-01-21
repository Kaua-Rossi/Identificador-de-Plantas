    using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas.TiposDePlanta
{
    public class Gimnosperma : Planta
    {
        public Gimnosperma(string n, string c) : base(n, c) { }

        public override string ObterCuriosidade()
        {
            return "Indústria madeireira (tábuas), produção de papel (celulose) e resinas.";
        }
    }
}
