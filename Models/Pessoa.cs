
namespace ExemploPOO.Models
{
    public class Pessoa
    {
        

            public string ? Name { get ; set; }

            public string ? documento { get ; set; }

            public int Age {  get ; set;  }

            public virtual void  Apresentar(){

                    Console.WriteLine($"Olá, meu nome é {this.Name} e tenho {this.Age} anos. ");
 

            }




    }
}