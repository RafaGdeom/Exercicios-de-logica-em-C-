//0.03 - Implemente a tabuda do 7.
Console.WriteLine("\n=== TABUADA DO 7===\n");
Console.WriteLine("CONDIÇÃO FOR\n");
for(int i = 1; i <= 10 ; i++)
{
    Console.WriteLine($"{i} x 7 = {i * 7}");
}
Console.WriteLine();
Console.WriteLine("CONDIÇÃO WHILE\n");
int y = 1;
while(y <= 10)
{
    Console.WriteLine($"{y} x 7 = {y * 7}");
    y += 1;
}