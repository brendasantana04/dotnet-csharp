using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca_subclasses.Services
{
    using System;

    class Personagem
    {
        public string Nome { get; set; }
        public int Mana { get; set; }

        public Personagem(string nome, int mana)
        {
            Nome = nome;
            Mana = mana;
        }
    }

    class Subclasse : Personagem
    {
        public int DanoBase { get; set; }

        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }
    }

    class Program
    {
        static void Main()
        {
            string nome = Console.ReadLine();
            int mana = Convert.ToInt32(Console.ReadLine());
            int danoBase = Convert.ToInt32(Console.ReadLine());

            Subclasse sb = new Subclasse(nome, mana, danoBase);

            sb.CalcularDano();
        }
    }
}