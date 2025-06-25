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
        public void ValidaArquivo(string caminho)
        {
            if (File.Exists(caminho))
                Console.WriteLine("Arquivo existe.");
            else
                Console.WriteLine("Arquivo não existe.");
        }

       
        public void LeArquivo(string caminho)
        {
            string contents = File.ReadAllText(caminho);
            Console.WriteLine(contents);
        }


        public void EscreveArquivo(string caminho, string texto)
        {
            File.WriteAllText(caminho, texto);
        }

        public void AdicionaTexto(string caminho, string texto)
        {
            File.AppendAllText(caminho, texto);
        }

       
        public void LeLinha(string caminho)
        {
            using (StreamReader leitor = new StreamReader(caminho))
            {
                string linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }

        public void EscreveLinha(string caminho, string texto)
        {
            using (StreamWriter escritor = new StreamWriter(caminho))
            {
                escritor.WriteLine(texto);
            }
        }
    }