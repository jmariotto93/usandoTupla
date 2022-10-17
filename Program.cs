using Tuplas.Models;

Leitura arquivo = new Leitura();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");


//Exemplo para dar o erro na leitura
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");


if (sucesso)
{
   //Console.WriteLine("Quantidade linhas d arquivo:" + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

































// (int, string, string, decimal) tupla = (16, "José", "Mariotto", 1.75M);

// //ValueTuple<int, string, string, decimal> outroExemploTupla = (16, "José", "Mariotto", 1.75M);
// //var outroExemploTuplaCreate = Tuple.Create(16, "José", "Mariotto", 1.75M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");