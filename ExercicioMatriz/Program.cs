using System;
using System.Globalization;

Console.WriteLine("Digite a ordem da matriz");
int ordemMatriz = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

int[,] matriz = new int[ordemMatriz, ordemMatriz];
List<int> diagonal = new List<int>();
int negativeNumbers = 0;

for (int i = 0; i < ordemMatriz; i++)
{
    for (int x = 0; x < ordemMatriz; x++)
    {
        Console.WriteLine("Digite " +
            "o valor para a posição [" + i + "," + x + "]: ");
        int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        matriz[i, x] = valor;

        if (matriz[i, x] < 0)
        {
            negativeNumbers++;
        }

        if (i == x)
        {
            diagonal.Add(matriz[i, x]);
        }
    }
}

Console.WriteLine("Main diagonal: ");

foreach (var item in diagonal)
{
    Console.WriteLine(item);
}

Console.WriteLine("Números negativos: ");
Console.WriteLine(negativeNumbers);