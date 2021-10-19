using System;
using System.Collections.Generic;

//colecao de dados aonde tenho uma dupla onde o dado é relacionado por um chave e um valor.
class Aula55{
    static void Main(){
        Dictionary<int, string> veiculos=new Dictionary<int, string>();//abre e fecha pararenteses indicando que ele é um construtor generico.
        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Aviao");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinente");
        //veiculos.Clear();

        veiculos.Remove(20);
        Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);
        int chave=20;

        if (veiculos.ContainsKey(chave)){
            Console.WriteLine("A Chave {0} esta na colecao", chave);
        }
        else{
            Console.WriteLine("A Chave {0} NAO esta na colecao", chave);
        }

        veiculos[15]="Bicicleta";


        string valor="Bicicleta";
        if (veiculos.ContainsValue(valor)){
            Console.WriteLine("O Valor {0} esta na colecao", valor);
        }
        else{
            Console.WriteLine("O Valor {0} NAO esta na colecao", valor);
        }

        Dictionary<int,String>.ValueCollection valores=veiculos.Values;
        
        foreach(string v in valores){
            Console.WriteLine(v);
        }
    }
}