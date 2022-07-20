using System.IO;

using System.Collections.Generic;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {


              public void ListarDiretorios(string caminho){

                     var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

                     foreach ( var retorno in retornoCaminho)
                     {


                                Console.WriteLine(retorno);



                        
                     }

              }


              public void ListarArquivosDiretorios(string caminho){

                     var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

                     foreach ( var retorno in retornoArquivos)
                     {


                                Console.WriteLine(retorno);



                        
                     }

              }

              public void CriarDiretorio(string caminho){

                     var retorno = Directory.CreateDirectory(caminho);

                     Console.WriteLine(retorno.FullName);

              }

              public void ApagarDiretorio(string caminho, bool apagarArquivos){ //Deletou, já era. Não vai para lixeira.

                     Directory.Delete(caminho, apagarArquivos);

                    

              }  

              public void CriarArquivoTexto(String caminho, String conteudo){

                     if (!File.Exists(caminho))

                            File.WriteAllText(caminho,conteudo);

                     

              }    

              public void CriarArquivoTextoSteeam(String caminho, List<String>conteudo){

                     using(var stream = File.CreateText(caminho)){

                             foreach (var linha in conteudo)
                            
                            {

                            
                                          stream.WriteLine(linha);
                                          

                            }
       

                     }

                    


              }

              public void AdicionarTexto(String caminho, String conteudo){

                     File.AppendAllText(caminho,conteudo);



              }

               public void AdicionarTextoSteeam(String caminho, List<String>conteudo){

                     using(var stream = File.AppendText(caminho)){

                             foreach (var linha in conteudo)
                            
                            {

                            
                                          stream.WriteLine(linha);
                                          

                            }
       

                     }

                    


              }

              public void LerArquivo(string caminho){

                     var conteudo = File.ReadAllLines(caminho);

                     foreach (var linha in conteudo)
                     {

                            Console.WriteLine(linha);
                            
                     }

              }

              public void LerArquivoStream(string caminho){

                     string linha = string.Empty;

                     using(var stream = File.OpenText(caminho)){

                            

                            while ((linha = stream.ReadLine()) != null)
                            {

                                   Console.WriteLine(linha);
                                   
                            }
       

                     }

              }

              public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        
              {
            
                    
                                   
                            File.Move(caminho, novoCaminho, sobrescrever);
            
              }

              public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        
              {

            
                    File.Copy(caminho, novoCaminho, sobrescrever);
              
              
              }
        


              
              public void DeletarArquivo(string caminho)
        
              {
            
                                
                        File.Delete(caminho);
                        
        
              }



    }
}