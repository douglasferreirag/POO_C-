namespace ExemploPOO.Models
{
    public class Retangulo
    {
        
            

            private double comprimento;

            private double largura ;

            private bool valido;

            public void DefinirMedidas(double comprimento, double largura){

                    if( (comprimento > 0) && (largura > 0) ) {

                            this.comprimento = comprimento;

                            this.largura = largura;

                            this.valido = true;

                            Console.WriteLine(largura);

                    }

                    else {

                            if(valido)

                                Console.WriteLine("Valores inválidos.");

                            else {

                                Console.WriteLine("Preencha os valors válidos");

                                

                            }


                    }



            }

            public double obterArea(){

                if(valido)

                    return  (comprimento * largura) ;

                else {
                
                    Console.WriteLine("Preencha valores válidos");

                    return 0;


                }


            }






    }
}