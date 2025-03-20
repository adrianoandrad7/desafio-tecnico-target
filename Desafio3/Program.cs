using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Carrega os dados do arquivo JSON
        string json = File.ReadAllText("dados.json");
        var dados = JsonSerializer.Deserialize<Dictionary<string, List<double>>>(json);

        // Filtra os dias com faturamento válido (ignora valores 0)
        List<double> faturamentoValido = dados["faturamento"].FindAll(valor => valor != 0);

        // Calcula menor e maior valor
        double menor = faturamentoValido.Min();
        double maior = faturamentoValido.Max();

        // Calcula a média mensal
        double media = faturamentoValido.Average();

        // Conta dias acima da média
        int diasAcimaMedia = faturamentoValido.Count(valor => valor > media);

        // Exibe os resultados
        Console.WriteLine($"Menor valor de faturamento: {menor}");
        Console.WriteLine($"Maior valor de faturamento: {maior}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
    }
}