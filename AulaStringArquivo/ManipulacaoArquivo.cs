namespace AulaStringArquivo;

public class ManipulacaoArquivo
{
    /*
      Faça um metodo que faça cada uma das funções abaixo
      Operações comuns:
    - File.Exists(): Verifica se o arquivo existe
    - File.ReadAllText(): Lê o conteúdo do arquivo
    - File.WriteAllText(): Escreve conteúdo
    - File.AppendAllText(): Adiciona texto
    - StreamReader.ReadLine(): Lê linha a linha
    - StreamWriter.WriteLine(): Escreve linha a linha
     */

    public void ValidaArquivo()
    {
        //File file = new File();

        if (File.Exists("C:\\Users\\robso\\source\\repos\\AulaStringArquivo\\arquivos\\texto.txt"))
        {
            Console.WriteLine("Existe");
        }
        else
        {
            Console.WriteLine("Não Existe");
        }
    }
}
