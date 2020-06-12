using System;
using System.IO;

namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Permitir { get; set; }

        public void Autorizar(){

            Console.WriteLine("Deseja permitir acesso? Digite true ou false");
            try
            {
                Permitir = Boolean.Parse( Console.ReadLine() );
                if(Permitir == true){
                    try
                    {
                        using (StreamReader sr = File.OpenText("data.txt"))
                        {
                            Console.WriteLine($"A primeira linha do arquivo é: \n {sr.ReadLine()}");
                        }
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine($"O aarquivo não foi encontrado: '{e}'");
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        Console.WriteLine($"O diretório não foi encontrado: '{e}'");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine($"O arquivo não pôde ser aberto: '{e}'");
                    }
                            }
                        }
            catch (System.Exception )
            {
                
                Console.WriteLine("Erro na aplicação: dados invalidos");
            }

        }
    }
}