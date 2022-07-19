using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using ExemploPOO.Helper;


namespace ExemploPOO {

        class Program {

                // Valores válidos


                static void Main(string[] args){


//                     Retangulo r = new Retangulo();

//                     r.DefinirMedidas(30,30);



//                     Console.WriteLine("Area: " + r.obterArea()  );


//                     Retangulo r2 = new Retangulo();

//                     r2.DefinirMedidas(0,0);



//                      Console.WriteLine("Area: " + r2.obterArea()  );


 /*

                        Pessoa p1 = new Pessoa();

                        p1.Name = "Bob";

                        p1.Age = 20;

                        p1.Apresentar();


 */

                        // Aluno p1 = new Aluno();

                        // p1.Name = "Bob";

                        // p1.Age = 20;

                        // p1.documento = "555555";

                        // p1.nota = 10;

                        // p1.Apresentar();


                        // Professor p2 = new Professor();

                        // p2.Name = "Teo";

                        // p2.Age = 40;

                        // p2.Salario = 5000;

                        // p2.documento = "123456";

                        // p2.Apresentar();


                       // Calculadora calc = new Calculadora();

                        //System.Console.WriteLine("Resultado da primeira soma: " + calc.somar(10,10));

                        //System.Console.WriteLine("Resultado da segunda soma: " + calc.somar(10,10,10));

                        //Corrente c = new Corrente();

                       // c.Creditar(100);

                       // c.ExibirSaldo();

                       //Computador comp = new Computador();

                       //System.Console.WriteLine(comp.ToString());

                       //ICalculadora calc = new Calculadora();

                       //System.Console.WriteLine(calc.Somar(10,20));

                        var caminho = "C:\\TrabalhandoComArquivos";

                       // var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");

                       var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
                       
                        FileHelper helper = new FileHelper();

                       //helper.ListarDiretorios(caminho);

                        //helper.ListarArquivosDiretorios(caminho);

                       // Console.WriteLine("Criando diretório: " + caminhoPathCombine);

                       // helper.CriarDiretorio(caminhoPathCombine);

                        //helper.ApagarDiretorio(caminhoPathCombine, true);

                        helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo." );



                }

        }

}

