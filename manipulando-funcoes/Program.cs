﻿using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
       // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        Calculadora calc = new Calculadora();
        double pegadaDeCarbono = calc.Calcular(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
        Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:

    class Calculadora
    {
        public double Calcular(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
        {
            double transporte = quilometrosPorDia * 365 * 0.2;
            double eletrônicos = horasDeEletronicos * 0.1;
            double consumoCarne = refeicoesComCarne * 0.5;

            double pegadaDeCarbono = transporte + eletrônicos + consumoCarne;

            return pegadaDeCarbono;
        }
    }
    
}