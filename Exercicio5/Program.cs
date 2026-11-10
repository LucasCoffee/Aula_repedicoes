Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
int aux = numero;

for (int i = numero - 1; i > 0; i--)
{
    aux = i * aux;
    Console.WriteLine(aux);
}

Console.WriteLine("Resultado: " + aux);

//Console.WriteLine("Digite um número: ");
//int numero = int.Parse(Console.ReadLine());
//int aux = 1;

//for (int i = 2; i <= numero; i++)
//{
//    aux = i * aux;
//    Console.WriteLine(aux);
//}

//Console.WriteLine("Resultado: " + aux);