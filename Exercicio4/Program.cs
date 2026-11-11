Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

void primo(int numero)
{

    if(numero > 1)
    {
        if (numero <= 1) return;

        int contador = 0;

        for (int i = 2; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contador++;
            }
        }

        if (contador == 1)
        {
            Console.WriteLine("Número informado: " + numero + " é primo");
        }

        primo(numero - 1);
    }
    else {
        Console.WriteLine("Fim");
        return;
    }

}

primo(numero);

//bool primo(int numero)
//{

//    if (numero <= 1) return false;
//    int contador = 0;

//    for (int i = 2; i <= numero; i++)
//    {
//        if (numero % i == 0)
//        {
//            contador++;
//        }
//        if (contador > 1)
//        {
//            return false;
//        }
//    }
//    return true;
//}


//for (int i = 2; i <= numero; i++)
//{
//    if (primo(i))
//    {
//        Console.WriteLine("Número informado: " + i + " é primo");
//    }
//}

//for (int i = 2; i <= numero; i++)
//{

//    Console.WriteLine("Número informado: " + i + " " + (primo(i) ? "é primo" : "não é primo"));
//}


//contador = 0;

//for (int j = i; j >= 2; j--)
//{
//    if (i % j == 0)
//    {
//        contador++;
//    }

//    if (contador > 1)
//    {
//        break;
//    }
//}