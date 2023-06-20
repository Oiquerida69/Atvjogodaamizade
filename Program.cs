using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATV07_JOGOS
{
    class Program
    {

        private static int resultado;
        private static int resultado2;
        private static int resultado3;
        private static int resultado4;


        public static void Main(string[] args)
        {
            Random sorteador = new Random();




            int sorteio = sorteador.Next(1, 11);








            Console.WriteLine("bem-vindo ao jogo da amizade");
            Console.WriteLine($"o seu numero inicial é {sorteio}");
            Console.WriteLine("Você deseja mais um numero? \n - Sim \n - Não");
            string resposta = Console.ReadLine();
            int vencedor = 21;
            if (resposta == "sim")
            {
                Random sorteador2 = new Random();
                int sorteio2 = sorteador2.Next(1, 11);
                resultado = sorteio + sorteio2;
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine($"você decidiu parar por aqui o seu numero final é {sorteio}");
            }
            Console.WriteLine("você deseja mais um numero:");
            Console.Write("- Sim");
            Console.WriteLine("- Não");
            string resposta2 = Console.ReadLine();
            if (resultado > 21)
            {
                Console.WriteLine("você estorou e infelizmente perdeu ;[");
                return;
            }
            if (resposta2 == "sim")
            {
                Random sorteador3 = new Random();
                int sorteio3 = sorteador3.Next(1, 11);
                resultado2 = resultado + sorteio3;
                Console.WriteLine(resultado2);
            }
            if (resultado2 == vencedor)
            {
                Console.WriteLine("você chegou a vinte um , parabéns você venceu");

            }
            else
            {
                Console.WriteLine($"você desejou para por aqui o seu valor final é{resultado} ");
                Console.ReadKey();
                Console.Clear();
                return;
            }




            Console.WriteLine("você deseja mais um numero:");
            Console.Write("- Sim");
            Console.WriteLine("- Não");
            string resposta3 = Console.ReadLine();
            if (resultado2 > vencedor)
            {
                Console.WriteLine("você estorou e infelizmente perdeu ;[");
                Console.ReadKey();
                return;
            }
            if (resultado2 == vencedor)
            {
                Console.WriteLine("Parabéns você ganhou o jogo");

            }
            if (resposta3 == "sim")
            {
                Random sorteador4 = new Random();
                int sorteio4 = sorteador4.Next(1, 11);
                resultado3 = resultado2 + sorteio4;
                Console.WriteLine(resultado3);
            }
            else
            {
                Console.WriteLine($"você desejou parar por aqui o seu valor final é {resultado2} ");
                Console.ReadKey();
                Console.Clear();
            }
            if (resultado3 > 21)
            {
                Console.WriteLine("você estorou e infelizmente perdeu ;[");
                return;
            }
            if (resultado3 == vencedor)
            {
                Console.WriteLine("você chegou a vinte um , parabéns você venceu");


            }
            else
            {
                Console.WriteLine($"o seu resultado agora é{resultado3}, você deseja mais um numero ?");
                Console.ReadKey();
                Console.Clear();
            }
            Console.Write("- sim");
            Console.WriteLine("- não");
            string resposta5 = Console.ReadLine();
            if (resposta5 == "sim")
            {
                Random sorteador5 = new Random();
                int sorteio5 = sorteador5.Next(1, 11);
                resultado4 = resultado3 + sorteio5;
                Console.WriteLine(resultado4);
            }
            if (resultado > 21)
            {
                Console.WriteLine("você estorou e infelizmente perdeu ;[");

                return;
            }

            if (resultado4 == vencedor)
            {
                Console.WriteLine("parabèns você venceu");
            }
            else
            {
                Console.WriteLine($"você desejou parar por aqui o seu resultado final é{resultado4} ");
                Console.Clear();

            }
            Console.ReadLine();
        }
    }
}





