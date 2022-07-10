

namespace funcoes_recursivas
{

    class Program
    {
        private static void LerArquivo(int numeroArquivo)
        {
            string caminho = @"C:\Users\FATIMA AIKAWA\Documents\CURSO C# DANILO APARECIDO\07 - FUNÇÕES RECURSIVAS - C# - TORNE-SE UM PROGRAMADOR\arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(caminho))
            {
                using (StreamReader arquivo = File.OpenText(caminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }

                }
            }

            string caminho2 = @"C:\Users\FATIMA AIKAWA\Documents\CURSO C# DANILO APARECIDO\07 - FUNÇÕES RECURSIVAS - C# - TORNE-SE UM PROGRAMADOR\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminho2))
            {
                using(StreamReader arquivo2 = File.OpenText(caminho2))
                {
                    LerArquivo(numeroArquivo + 1);
                }
            }

        }

        


        static void Main(string[]args)
            {
            LerArquivo(1);
            }
        
    }

}
