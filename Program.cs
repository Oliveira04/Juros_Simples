﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P

        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i

        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        double montanteFinal = P + (P * i * n);
        return montanteFinal; // Retorna o montante final
    }
}