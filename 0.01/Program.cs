/*
a) Crie um algoritmo para informar duas notas de provas, calcular e apresentar a média do aluno e se ele foi ou não aprovado.
*/
double nota1;
double nota2;

System.Console.WriteLine("----Calculo das notas ----\n");

System.Console.WriteLine("Digite a 1° nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite a 2° nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;
System.Console.WriteLine($"Média: {media}\n");
if (media >= 6)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
System.Console.WriteLine();