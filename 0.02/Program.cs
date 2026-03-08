//0.02 - A partir da digitação do ano de nascimento de um aluno, calcule a idade e use a expressão 
//condicional para apresentar se o aluno é maior de idade ou menor

Console.WriteLine("\nDigite o ano de nascimento do aluno: \n");
int idade = Convert.ToInt32(Console.ReadLine());

int nasc = 2026 - idade;

if(nasc >=18)
{
    Console.WriteLine($"\nIdade de {nasc} anos Maior de idade.");
}
else
{
    Console.WriteLine($"\nIdade de {nasc} anos De menor!!!");
}