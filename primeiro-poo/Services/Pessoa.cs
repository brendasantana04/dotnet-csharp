using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_poo.Services
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }
        public string GetNome()
        {
            return nome;
        }

        public int GetIdade()
        {
            return idade;
        }
    }

    class Program
    {
    static void Main()
        {
            string Nome = Console.ReadLine();
            int Idade = Convert.ToInt32(Console.ReadLine());

            Pessoa p = new Pessoa(Nome, Idade);
        
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        
        }
    }
}