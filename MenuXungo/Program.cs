namespace MenuXungo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char nom;
            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║               MENU                ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║      1. JUGAR A LA TRIVIAL        ║");
                Console.WriteLine("║      2. MATEMÀTICA MENTAL         ║");
                Console.WriteLine("║                                   ║");
                Console.WriteLine("║      0. Sortir                    ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.Write("\nTria una opcio: ");
                nom = Console.ReadKey().KeyChar;
                switch (nom)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("** TRIVIAL DE PREGUNTES GENERALS **");
                        Random b = new Random();
                        StreamReader c = new StreamReader("preguntes.txt");
                        int aa = 0;
                        while (c.ReadLine() != null)
                            aa++;
                        int abc = b.Next(1, aa + 1);
                        string patata = "";
                        for (int i = 0; i < abc; i++)
                            patata = c.ReadLine();
                        string girona = "";
                        Console.WriteLine($"Pregunta: {patata}");
                        Console.Write("Resposta: ");
                        string girona2 = Console.ReadLine();

                        StreamReader sr2 = new StreamReader("respostes.txt");
                        for (int i = 0; i < abc; i++)
                            girona = sr2.ReadLine();
                        if (girona2.ToLower() == girona.ToLower())
                        {
                            Console.WriteLine("Correcte! Has encertat.");

                            for (int i = 5; i > 0; i--)
                            {
                                Console.Write("\r");
                                Console.Write(($"Tornant al menu: {i}s"));
                                Thread.Sleep(1000);
                            }
                        }

                        else
                        {
                            Console.WriteLine($"Incorrecte! La resposta correcta és: {girona}");

                            for (int i = 5; i > 0; i--)
                            {
                                Console.Write("\r");
                                Console.Write(($"Tornant al menu: {i}s"));
                                Thread.Sleep(1000);
                            }
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("** CONCURS DE MATEMÀTICA MENTAL **");
                        Random paco = new Random();
                        int dia = paco.Next(1, 20);
                        int mes = paco.Next(1, 20);
                        int any = dia + mes;

                        Console.WriteLine($"Pregunta: Quant és {dia} + {mes}?");
                        Console.Write("Resposta: ");
                        int anytraspas = Convert.ToInt32(Console.ReadLine());


                        if (anytraspas == any)
                        {
                            Console.WriteLine("Correcte! Has encertat.");

                            for (int dies = 5; dies > 0; dies--)
                            {
                                Console.Write("\r");
                                Console.Write(($"Tornant al menu: {dies}s"));
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Incorrecte! La resposta correcta és: {any}");

                            for (int valorsDecimals = 5; valorsDecimals > 0; valorsDecimals--)
                            {
                                Console.Write("\r");
                                Console.Write(($"Tornant al menu: {valorsDecimals}s"));
                                Thread.Sleep(1000);
                            }
                        }
                        break;
                    case '0':
                        Console.Clear();
                        Console.WriteLine($"Sortint del programa... Prem qualsevol a per continuar.");

                        for (int hores = 5; hores > 0; hores--)
                        {
                            Console.Write("\r");
                            Console.Write(($"Tornant al menu: {hores}s"));
                            Thread.Sleep(1000);
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opció incorrecta. Prem una a per tornar al menú.");

                        for (int patata2 = 5; patata2 > 0; patata2--)
                        {
                            Console.Write("\r");
                            Console.Write(($"Tornant al menu: {patata2}s"));
                            Thread.Sleep(1000);
                        }
                        break;
                }

            } while (nom != '0');
        }
    }
}
