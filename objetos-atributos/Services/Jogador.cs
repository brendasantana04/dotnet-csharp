using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace objetos_atributos.Services
{

    class Jogador
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
        }
    }

    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string nationality = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string position = Console.ReadLine();

            Jogador j = new Jogador(name, nationality, age, position);

            Console.WriteLine("Jogador criado!");
            Console.WriteLine(name);
            Console.WriteLine(nationality);
            Console.WriteLine(age);
            Console.WriteLine($"Posição: {position}");

        }
    }
}