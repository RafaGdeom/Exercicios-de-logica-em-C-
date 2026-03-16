//0.06 - Faça um programa que receba três notas, calcule e mostre a média aritmética.
double nota = 0;
double somaNota = 0;
double media = 0;
for(int i = 0; i < 3; i++)
{
    Console.Write($"Digite a nota {i+1}: ");
    nota = Convert.ToDouble(Console.ReadLine());
    somaNota += nota;
}
media = somaNota / 3;
Console.WriteLine($"A média aritimética das notas são {media}");
Console.WriteLine(somaNota);