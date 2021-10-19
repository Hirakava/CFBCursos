using System;
using System.Collections.Generic;

//IndexOf

class Aula58{
    static void Main(){
        List<string>carros=new List<string>();
        string[] carros2= new string[10];


        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

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
        carros.Insert(1,"Cruze");
        int pos2=carros.LastIndexOf("HRV");

        // carros.RemoveAt(0);            

        // if (carros.Remove("Argo")){
        //     Console.WriteLine("Argo Removido");
        // }
        // else
        // {
        //     Console.WriteLine("Argo NAO Removido");
        // }

        //carros.Reverse();
        carros.Sort();

        int tamanho=carros.Count;
        carros.Capacity=20;
        int cap=carros.Capacity;

        Console.WriteLine("Tamanho {0}", tamanho);
        Console.WriteLine("Capacidade {0}", cap);

        foreach(string c in carros){
             Console.WriteLine("Carro: {0}",c);
        }

        string ca="HRV";
        int pos=0;
        pos=carros.IndexOf(ca);
        Console.WriteLine("Carro {0} esta na posicao {1}", ca, pos);
        Console.WriteLine("Ultimo HRV esta na pos {0}",pos);

    }
}