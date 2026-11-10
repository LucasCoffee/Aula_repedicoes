int contador = 10;

while (contador > 0)
{
    Console.WriteLine(contador);
    contador--;
    Thread.Sleep(500);
}

Console.WriteLine("Feliz Ano Novo!");

do
{
    Console.WriteLine(contador);
    contador++;
    Thread.Sleep(500);
} while (contador < 10);

for(contador = 10; contador > 0; contador--)
{
    Console.WriteLine(contador);
    Thread.Sleep(500);
}