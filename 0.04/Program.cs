// 0.04 - Criar um algoritmo para somar as idades de 5 alunos. Apresente o resultado.
int idade = 0;
int soma = 0;

for(int i = 0; i <= 5; i++)
{
    Console.Write($"Digite a idade do aluno {i}: ");
    idade = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    soma += idade;
}
int media = soma / 5;
Console.WriteLine($"A media das idades será: {media} anos.");
