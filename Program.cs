using System;
using System.Threading;

namespace JogoDaMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            float altura, largura;
            altura = Console.WindowHeight;
            largura = Console.WindowWidth;
            metadel(largura/2+largura/3);
            Console.Title = "Jogo da Memoria!!";
            Console.WriteLine("Bem vindo ao Jogo da Memoria!!");
            linha(largura);
            Console.Write("\n");
            int dificudade ,jogando = 0;
            int[] num;
            Random rand = new Random();
            num = new int[5];
            while (jogando == 0)
            {
                int acerto = 0, erros = 0,retorno = 0,level = 1;
                Console.WriteLine("1-Fácil\n2-Medio\n3-Difícil");
                Console.Write("Escolha a dificudade: ");
                dificudade = Convert.ToInt32(Console.ReadLine());
                if (dificudade == 1)
                {
                    altura = Console.WindowHeight;
                    largura = Console.WindowWidth;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    metadea(altura);
                    metadel(largura);
                    Console.WriteLine("Fácil");
                    Thread.Sleep(3000);
                    fini:
                    for (int i = 0; i < 5; i++)
                    {
                       num[i] = numbers(altura, largura,level,i,10);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        retorno = teste(num[i],i);
                        acerto += retorno;
                        if (retorno == 0)
                        {
                            erros += 1;
                        }
                    }
                    Console.WriteLine("Acertou: " + acerto);
                    Console.WriteLine("Errou: " + erros);
                    Thread.Sleep(2000);
                    if (acerto >= 2 && level<3)
                    {
                        acerto = 0;
                        level++;
                        Console.WriteLine("Level" + level);
                        Thread.Sleep(2000);
                        goto fini;
                    }
                    else if (level != 3)
                    {
                        Console.Clear();
                        metadea(altura);
                        metadel(largura);
                        Console.WriteLine("Game Over");
                        Thread.Sleep(2000);
                    }
                }
                else if (dificudade == 2)
                {
                    altura = Console.WindowHeight;
                    largura = Console.WindowWidth;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    metadea(altura);
                    metadel(largura);
                    Console.WriteLine("Medio");
                    Thread.Sleep(3000);
                    mini:
                    for (int i = 0; i < 5; i++)
                    {
                       num[i] = numbers(altura, largura,level,i,100);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        retorno = teste(num[i], i);
                        acerto += retorno;
                        if (retorno == 0)
                        {
                            erros += 1;
                        }
                    }
                    Console.WriteLine("Acertou: " + acerto);
                    Console.WriteLine("Errou: " + erros);
                    Thread.Sleep(2000);
                    if (acerto >= 4 && level < 3)
                    {
                        acerto = 0;
                        level++;
                        Console.WriteLine("Level" + level);
                        Thread.Sleep(2000);
                        goto mini;
                    }
                    else if (level != 3)
                    {
                        Console.Clear();
                        metadea(altura);
                        metadel(largura);
                        Console.WriteLine("Game Over");
                        Thread.Sleep(2000);
                    }
                }
                else if (dificudade == 3)
                {
                    altura = Console.WindowHeight;
                    largura = Console.WindowWidth;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    metadea(altura);
                    metadel(largura);
                    Console.WriteLine("Difícil");
                    Thread.Sleep(3000);
                    dini:
                    for (int i = 0; i < 5; i++)
                    {
                        num[i] = numbers(altura, largura, level, i, 1000);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        retorno = teste(num[i], i);
                        acerto += retorno;
                        if (retorno == 0)
                        {
                            erros += 1;
                        }
                    }
                    Console.WriteLine("Acertou: " + acerto);
                    Console.WriteLine("Errou: " + erros);
                    Thread.Sleep(2000);
                    if (acerto == 5 && level < 3)
                    {
                        acerto = 0;
                        level++;
                        Console.WriteLine("Level" + level);
                        Thread.Sleep(2000);
                        goto dini;
                    }
                    else if(level != 3)
                    {
                        Console.Clear();
                        metadea(altura);
                        metadel(largura);
                        Console.WriteLine("Game Over");
                        Thread.Sleep(2000);
                    }
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("0-sim");
                Console.WriteLine("1-não");
                Console.Write("Jogar Novamente?: ");
                jogando = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
        }

        static void metadea(float a)
        {
            for (int i = 0;i<a/5;i++)
            {
                Console.WriteLine("\n");
            }
        }

        static void metadel(float l)
        {
            for (float i = 0; i < l / 2; i++ )
            {
                Console.Write(" ");
            }
        }

        static void linha(float l)
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write("-");
            }
        }

        static int teste(int n,int i)
        {
            Console.Clear();
            int num,a = 0;
            i += 1; 
            Console.WriteLine("Escreva o " + i + " Numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (n==num)
            {
                Console.WriteLine("Certo");
                Thread.Sleep(2000);
                a++;
            }
            else
            {
                Console.WriteLine("Errado");
                Thread.Sleep(2000);
            }
            Console.Clear();
            return a;
        }

        static int numbers(float altura, float largura, int level, int i,int f)
        {
            int[] num;
            num = new int[5];
            Random rand = new Random();
            Console.Clear();
            num[i] = rand.Next(1, f);
            metadea(altura);
            metadel(largura);
            Console.WriteLine(num[i]);
            if (level == 1)
            {
                Thread.Sleep(3000);
            }
            else if (level == 2)
            {
                Thread.Sleep(2000);
            }
            else if (level == 3)
            {
                Thread.Sleep(1000);
            }
            return num[i];
        }
    }
}
