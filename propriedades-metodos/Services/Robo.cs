    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace propriedades_metodos.Services
    {
        class Robo
        {
            public int VelocidadeAtual { get; set; } = 0;
            public int VelocidadeMaxima { get; }
            public int VelocidadeMinima { get; }

            public Robo(int vmin, int vmax)
            {
                VelocidadeMinima = vmin;
                VelocidadeMaxima = vmax;
                VelocidadeAtual = vmin;
            }

            public void Acelerar()
            {
                if (VelocidadeAtual < VelocidadeMaxima)
                {
                    VelocidadeAtual++;
                }
            }

            public void Desacelerar()
            {
                if (VelocidadeAtual > VelocidadeMinima)
                {
                    VelocidadeAtual--;
                }
            }
        }
        class Program
        {
            static void Main()
            {   
                //lendo as velocidades em apenas uma linha
                string[] valores = Console.ReadLine().Split(' ');

                //inicializando as velocidades e convertendo para int
                int velMax = Convert.ToInt32(valores[0]);
                int velMin = Convert.ToInt32(valores[1]);

                Robo r = new Robo(velMax, velMin);

                //fazendo leitura dos comandos
                string comandos = Console.ReadLine();

                //realizando acoes dos comandos
                foreach (char vel in comandos)
                {
                    if (vel == 'A')
                    {
                        r.Acelerar();
                    }
                    if (vel == 'D')
                    {
                        r.Desacelerar();
                    }
                }

                //exibindo mensagem na tela
                Console.WriteLine(r.VelocidadeAtual);
            }
        }
    }