Console.WriteLine("--- IDENTIFICADOR DE PLANTAS ---");
Console.WriteLine("Responda as perguntas com s/n");
Console.WriteLine("-------------------------------------------------");

Console.WriteLine("1. A planta possui vasos condutores e consegue crescer alto (não é rasteira)?");
string resposta = Console.ReadLine();

if (resposta == "n")
{
    Console.WriteLine("É uma BRIÓFITA.");
}
else
{
    Console.WriteLine("2. A planta produz sementes visíveis?");
    resposta = Console.ReadLine();

    if (resposta == "n")
    {
        Console.WriteLine("É uma PTERIDÓFITA");
    }
    else
    {
        Console.WriteLine("3. A planta possui flores verdadeiras e frutos que envolvem a semente?");
        resposta = Console.ReadLine();

        if (resposta == "n")
        {
            Console.WriteLine("É uma GIMNOSPERMA");
        }
        else
        {
            Console.WriteLine("4. Olhe para a flor, a quantidade de pétalas é 3 ou um múltiplo de 3?");
            resposta = Console.ReadLine();

            if (resposta == "s")
            {
                Console.WriteLine("RESULTADO: É uma ANGIOSPERMA MONOCOTILEDÔNEA");
            }
            else
            {
                Console.WriteLine("RESULTADO: É uma ANGIOSPERMA DICOTILEDÔNEA");
            }
        }
    }
}