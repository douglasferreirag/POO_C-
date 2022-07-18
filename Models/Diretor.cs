namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {

            //sealed - não quer que seja derivado nas classes filhas. Só pode ser tratado na classe pai.


            public override void  Apresentar(){ 

                    Console.WriteLine($"Diretor");
 

            }


        
    }
}