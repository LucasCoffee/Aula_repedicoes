Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if(i == 2 || i == 3)
    {
        Console.WriteLine("Número é primo: " + i);
    }

    if (i % 2 != 0 && i % 3 != 0)
    {
        Console.WriteLine("Número é primo: " + i);
    }

   Thread.Sleep(200);

}