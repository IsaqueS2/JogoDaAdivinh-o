namespace JogoDaAdivinhção
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int randomNumero = rand.Next(1, 20);

            Console.WriteLine("**************************************");
            Console.WriteLine("* Bem-vindo(a) ao Jogo da Adivinhação*");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade: \n " +
                "(1) Fácil (2) Médio (3) Difícil \n Escolha: " );
            Console.WriteLine("");
            int dificuldade = int.Parse(Console.ReadLine());
            double pontuacao = 1000;
            double calculo = 0;
            
            if (dificuldade == (1)){
                for (int i = 1; i <= 15; i++)
                {

                    Console.WriteLine("Tentativa "+ i + " de 15");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Qual seu " + i + "º" + " chute (De 1 ao 20): ");
                    double numeroChutado = double.Parse(Console.ReadLine());

                 
                    if (numeroChutado != randomNumero && numeroChutado < randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi menor que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if (numeroChutado != randomNumero && numeroChutado > randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi maior que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if (numeroChutado == randomNumero)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n Sua pontução final foi de: " + pontuacao);
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }    
            }

            else if (dificuldade == (2))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Tentativa " + i + " de 10");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Qual seu " + i + "º" + " chute (De 1 ao 20): ");
                    double numeroChutado = double.Parse(Console.ReadLine());
                    if (numeroChutado != randomNumero && numeroChutado < randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi menor que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if (numeroChutado != randomNumero && numeroChutado > randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi maior que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if (numeroChutado == randomNumero)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n Sua pontução final foi de: " + pontuacao);
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

            }


            else if (dificuldade == (3))
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Tentativa " + i + " de 5");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Qual seu " + i + "º" + " chute (De 1 ao 20): ");
                    double numeroChutado = double.Parse(Console.ReadLine());
                    if (numeroChutado != randomNumero && numeroChutado < randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi menor que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if (numeroChutado != randomNumero && numeroChutado > randomNumero)
                    {
                        calculo = Math.Abs(numeroChutado - randomNumero);
                        pontuacao = Math.Abs(pontuacao - (calculo) / 2);
                        Console.WriteLine("Seu chute foi maior que o número secreto! \n Você fez " + pontuacao + " pontos");
                    }
                    else if ( numeroChutado == randomNumero)
                    {
                        Console.WriteLine("Parabéns, você acertou!\n Sua pontução final foi de: " + pontuacao);
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }



            


        }
    }
}