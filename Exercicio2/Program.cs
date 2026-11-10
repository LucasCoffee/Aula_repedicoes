Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
int calculo = 0;

int antecessor = 1;
int anterior = 2;


for (int i = 3; calculo < numero; i++)
{
    calculo = antecessor + anterior;

    antecessor = anterior;
    anterior = calculo;
    Console.WriteLine(calculo);
}