using System;
using System.Collections.Generic;
using IdentificadorPlantas.TiposDePlanta;

namespace IdentificadorPlantas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planta> bancoDeDados = RepositorioPlantas.Inicializar();

            Console.WriteLine("--- IDENTIFICADOR DE PLANTAS ---");
            Console.WriteLine("Responda 's' ou 'n'");
            Console.WriteLine("------------------------------------------");

            string tipoFinal = "";
            string subTipoAngiosperma = "";


            Console.WriteLine("1. A planta tem vasos condutores e cresce alto?");
            if (Console.ReadLine().ToLower() == "n")
            {
                tipoFinal = "Briofita";
            }
            else
            {
                Console.WriteLine("2. A planta tem sementes visíveis?");
                if (Console.ReadLine().ToLower() == "n")
                {
                    tipoFinal = "Pteridofita";
                }
                else
                {
                    Console.WriteLine("3. Tem flores e frutos?");
                    if (Console.ReadLine().ToLower() == "n")
                    {
                        tipoFinal = "Gimnosperma";
                    }
                    else
                    {
                        tipoFinal = "Angiosperma";
                        Console.WriteLine("4. Pétalas em múltiplos de 3 (Ex: 3, 6)?");
                        if (Console.ReadLine().ToLower() == "s")
                            subTipoAngiosperma = "Monocotiledônea";
                        else
                            subTipoAngiosperma = "Dicotiledônea";
                    }
                }
            }

            Console.WriteLine($"RESULTADO: Você identificou uma {tipoFinal.ToUpper()} " +
                              $"{(subTipoAngiosperma != "" ? subTipoAngiosperma : "")}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");

            bool curiosidade = false;

            foreach (var p in bancoDeDados)
            {
                bool ehDoTipo = false;

                if (tipoFinal == "Briofita" && p is Briofita) ehDoTipo = true;
                else if (tipoFinal == "Pteridofita" && p is Pteridofita) ehDoTipo = true;
                else if (tipoFinal == "Gimnosperma" && p is Gimnosperma) ehDoTipo = true;
                else if (tipoFinal == "Angiosperma" && p is Angiosperma angio)
                {
                    if (angio.Tipo == subTipoAngiosperma) ehDoTipo = true;
                }

                if (ehDoTipo)
                {
                    if (!curiosidade)
                    {
                        Console.WriteLine("Curiosidade desse tipo de planta: ");
                        Console.WriteLine(p.ObterCuriosidade());
                        Console.WriteLine("\nExemplos de plantas desse tipo:");
                        curiosidade = true;
                    }
                    Console.WriteLine($"> {p.NomePopular} ({p.NomeCientifico})");
                }
            }
        }
    }
}