using System;


   struct Carro{
        // public string marca;
        public string modelo;
        public string cor;
        // public Carro(string marca, string modelo, string cor){
        //     this.marca=marca;
        //     this.modelo=modelo;
        //     this.cor=cor;
        // }   
        public void info(){            
            Console.WriteLine("Modelo....: {0}", this.modelo);
            Console.WriteLine("Cor.......: {0}", this.cor);
            Console.WriteLine("......................................");

        }

    }
    class Aula45
    {
        static void Main()
        {
            //Carro c1;
            //c1.marca="VW";
            //c1.modelo="Golf";
            //c1.cor="Azul";

            //Console.WriteLine("Marca.....: {0}", c1.marca);
            //Console.WriteLine("Modelo....: {0}", c1.modelo);
            //Console.WriteLine("Cor.......: {0}", c1.cor);
            int [] numeros=new int[10];
            Carro[] carros=new Carro[4];
            carros[0].modelo="HRV";
            carros[0].cor="Prata";
            
            carros[1].modelo="Golf";
            carros[1].cor="Azul";

            carros[2].modelo="Jetta";
            carros[2].cor="Branco";

            carros[3].modelo="Argo";
            carros[3].cor="Preto";

            // Carro c2=new Carro("VW", "Golf","Azul\n");
            for (int i=0;i<carros.Length;i++)
            carros[i].info();
            // carros[1].info();
            // carros[2].info();
            // carros[3].info();

            
        }
    }
