﻿namespace C.Fundamentals.Module13.Arrays.Question03;

/// <summary>
/// <para>
///     Faça um programa que cria uma matriz de inteiros de duas dimensões e atribui valores a cada
///     uma das posições desta matriz. O número de linhas, de colunas e os valores a serem
///     atribuídos para cada posição devem ser lidos via console.
/// </para>
/// <para>
///     Na sequência, imprima a matriz e calcule a soma dos elementos de cada coluna. Esta soma
///     deve ser armazenada em um array. Por exemplo, se a matriz tem tamanho 3x4, você deverá
///     criar uma array de 4 posições, onde cada posição armazenará a soma dos 3 valores da coluna.
///     Os valores das somas também deverão ser mostrados.
/// </para>
/// </summary>
internal static class Answer
{
    internal static void Run()
    {
        Console.WriteLine("Create a two-dimensional integer array:");

        Console.Write("What is the number of rows: ");
        int rowNumbers = Read();

        Console.Write("What is the number of columns: ");
        int columnNumbers = Read();

        Console.WriteLine();

        int[,] matrix = new int[rowNumbers, columnNumbers];
        int[] sum = new int[columnNumbers];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("What is the position value [{0}, {1}]", i, j);
                int value = Read();
                matrix[i, j] = value;
                sum[j] += value;
            }
        }

        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,-5} ", matrix[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write("{0,-5} ", sum[i]);
        }
    }

    private static int Read()
    {
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }

        throw new FormatException("Could not convert the entered value to a valid number.");
    }
}
