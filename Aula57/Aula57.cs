using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){
        List<string>carros=new List<string>();
        string[] carros2= new string[10];


        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.CopyTo(carros2,2);

        //carros2.AddRange(carros);
        //carros2.Clear();
        if (carros.Contains("Golf")){
            Console.WriteLine("Esta na Lista");
        }
        else
        {
            Console.WriteLine("Nao encontrado");
        }



        carros.CopyTo(carros2,2);


        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }

        string ca="HRV";
        int pos=0;
        pos=carros.IndexOf(ca);
        Console.WriteLine("Carro {0} esta na posicao {1}", ca, pos);

    }
}