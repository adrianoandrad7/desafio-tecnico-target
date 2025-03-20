using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        string invertida = InverterString(texto);

        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string s)
    {
        char[] caracteres = s.ToCharArray();
        int inicio = 0;
        int fim = s.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}