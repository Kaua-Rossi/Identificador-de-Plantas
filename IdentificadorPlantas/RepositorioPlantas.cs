using IdentificadorPlantas.TiposDePlanta;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificadorPlantas
{
    public static class RepositorioPlantas
    {
        public static List<Planta> Inicializar()
        {
            List<Planta> lista = new List<Planta>();

            lista.Add(new Briofita("Musgo-branco", "Octoblepharum albidum")     );
            lista.Add(new Briofita("Hepática", "Riccia fluitans"));
            lista.Add(new Briofita("Musgo-tapete", "Sematophyllum subsimplex"));
            lista.Add(new Briofita("Musgo-de-pedra", "Campylopus sp."));
            lista.Add(new Briofita("Antócero", "Anthoceros sp."));

            lista.Add(new Pteridofita("Avenca", "Adiantum raddianum"));
            lista.Add(new Pteridofita("Samambaia-de-metro", "Polypodium persicifolium"));
            lista.Add(new Pteridofita("Renda-portuguesa", "Davallia fejeensis"));
            lista.Add(new Pteridofita("Samambaia-açu", "Cyathea delgadii"));
            lista.Add(new Pteridofita("Xaxim-do-brejo", "Dicksonia sellowiana"));

            lista.Add(new Gimnosperma("Pinheiro-bravo", "Podocarpus sellowii"));
            lista.Add(new Gimnosperma("Sagu-de-jardim", "Cycas revoluta"));
            lista.Add(new Gimnosperma("Pinheiro-do-caribe", "Pinus caribaea"));
            lista.Add(new Gimnosperma("Cipreste", "Cupressus sempervirens"));
            lista.Add(new Gimnosperma("Tuia", "Thuja occidentalis"));

            lista.Add(new Angiosperma("Carnaúba", "Copernicia prunifera", "Monocotiledônea"));
            lista.Add(new Angiosperma("Babaçu", "Attalea speciosa", "Monocotiledônea"));
            lista.Add(new Angiosperma("Licuri", "Syagrus coronata", "Monocotiledônea"));
            lista.Add(new Angiosperma("Abacaxi", "Ananas comosus", "Monocotiledônea"));
            lista.Add(new Angiosperma("Capim-santo", "Cymbopogon citratus", "Monocotiledônea"));

            lista.Add(new Angiosperma("Umbuzeiro", "Spondias tuberosa", "Dicotiledônea"));
            lista.Add(new Angiosperma("Juazeiro", "Ziziphus joazeiro", "Dicotiledônea"));
            lista.Add(new Angiosperma("Cajueiro", "Anacardium occidentale", "Dicotiledônea"));
            lista.Add(new Angiosperma("Baraúna", "Schinopsis brasiliensis", "Dicotiledônea"));
            lista.Add(new Angiosperma("Mandacaru", "Cereus jamacaru", "Dicotiledônea"));

            return lista;
        }
    }
}
