using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas.TiposDePlanta
{
    public class Angiosperma : Planta
    {
        public string Tipo { get; set; }
        public Angiosperma(string n, string c, string tipo) : base(n, c)
        {
            Tipo = tipo;
        }

        public override string ObterCuriosidade()
        {
            if (Tipo == "Monocotiledônea")
            {
                return "Base da alimentação mundial (grãos, cana-de-açúcar) e pastagens.";
            }
            else
            {
                return "Produção de frutos, madeiras de lei, leguminosas e óleos essenciais.";
            }
        }
    }
}
