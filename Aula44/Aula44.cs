﻿using System;

namespace Aula44
{   struct Carro{
        public string marca;
        public string modelo;
        public string cor;
        public Carro(string marca, string modelo, string cor){
            this.marca=marca;
            this.modelo=modelo;
            this.cor=cor;
        }   
        public void info(){
            Console.WriteLine("Marca.....: {0}", this.marca);
            Console.WriteLine("Modelo....: {0}", this.modelo);
            Console.WriteLine("Cor.......: {0}", this.cor);

        }

    }
    class Aula44
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
            Carro c1=new Carro("Honda","HRV", "Prata\n");
            Carro c2=new Carro("VW", "Golf","Azul\n");
            
            c1.info();
            c2.info();

            
        }
    }
}
