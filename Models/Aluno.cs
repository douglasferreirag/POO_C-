namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {

            public int nota {get;set;}

             public override void  Apresentar(){

                    Console.WriteLine($"Olá, meu nome é {this.Name} e sou um aluno nota {this.nota}. ");
 

            }



    }
}