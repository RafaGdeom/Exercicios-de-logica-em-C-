//0.05 - Criar o programa para calcular e apresentar a tabuada do 5 ao 10.
//Utilize duas estruturas de repetição.
for(int i = 5; i <= 10; i++)
{
    Console.WriteLine($"===Taboada do {i} ===");
    for(int y = 1; y <= 10; y++)
    {
        Console.WriteLine($"{y} x {i} = {y * i}");
    }
    System.Console.WriteLine();
}