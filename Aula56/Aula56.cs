using System;
using System.Collections.Generic;

//LISTA DUPLAMENTE ENCADEADA OU LINKEDLIST
class Aula56{
    static void Main(){
        LinkedList<String> transp= new LinkedList<string>();
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no=transp.FindLast("Navio").Value;
        transp.AddAfter(no,"Patinete");
        transp.AddBefore(no,"Patins");

        //transp.Clear();
        if (transp.Find("Carro"==null)){
            Console.WriteLine("Nao encontrado");
        }
        else{
            Console.WriteLine("Elemento Encontrado");
        }
        //transp.Remove("Navio");
        transp.RemoveFirst();
        transp.RemoveLast();


        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }        
    }
}