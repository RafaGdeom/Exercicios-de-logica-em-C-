/* 0.07 - Faça um programa que receba o salário de um funcionário e o percentual de aumento, 
calcule e mostre o valor do aumento e o novo salário.*/

double salario = 0;
double almento = 0;
double newSalario = 0;

Console.Write("Digite o valor salario: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o percentual do almento: ");
almento = Convert.ToDouble(Console.ReadLine());
newSalario = (salario * almento) + salario;
Console.WriteLine($"O salario reajustado será: R${newSalario}");