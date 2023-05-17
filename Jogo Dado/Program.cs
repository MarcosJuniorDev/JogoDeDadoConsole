namespace Jogo_Dado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            int seuNumero, numeroAdversario, score = 0, scoreMaquina = 0;

            while (round <= 10)
            {
                Console.WriteLine("Pressione qualquer tecla para rodar o dado.");
                Console.ReadKey();
                Random nAleatorio = new Random();
                seuNumero = nAleatorio.Next(11);
                Console.WriteLine($"voce tirou o numero: {seuNumero}");
                Console.WriteLine("...");
                numeroAdversario = nAleatorio.Next(11);
                Console.WriteLine($"O adversário tirou o numero: {numeroAdversario}");
                if (seuNumero > numeroAdversario)
                {
                    round++;
                    score++;
                    Console.WriteLine("Voce ganhou esse round!");
                    Console.WriteLine($"O resultado esta: Player: {score}. Adversario: {scoreMaquina}");
                }
                else if (seuNumero == numeroAdversario)
                {
                    round++;
                    Console.WriteLine("Empatou");
                    Console.WriteLine($"O resultado esta: Player: {score}. Adversario: {scoreMaquina}");
                }
                else
                {
                    round++;
                    scoreMaquina++;
                    Console.WriteLine("Voce perdeu este round");
                    Console.WriteLine($"O resultado esta: Player: {score}. Adversario: {scoreMaquina}");
                }
                if (round == 11)
                {
                    if (score > scoreMaquina)
                    {
                        Console.WriteLine("Voce ganhou GG");
                    }
                    else
                    {
                        Console.WriteLine("Voce perdeu!");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}