using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){
        //string[] v={"Carro","Moto","Navio","Aviao"};
        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");
        
        string v="Patinete";
        if (veiculos.Contains(v)){
            Console.WriteLine("Veiculo " + v + " encontrado");
        }
        else{
            Console.WriteLine("Veiculo " + v + " nao esta na fila");
        }
        //veiculos.Clear();
        // Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue());
        // Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue());
            Console.WriteLine("Primeiro Veiculo" + veiculos.Peek());
        //  foreach(string v in veiculos){
        //      v=veiculos.Dequeue();
            //  Console.WriteLine("Veiculo removido: " + v);        
             Console.WriteLine("Tamanho fila:" +veiculos.Count);
            //  foreach (string veic in veiculos){
            //      Console.WriteLine("Veiculo " + veic);

            //  }
             Console.WriteLine("Tamanho Fila: " +veiculos.Count);
             //Console.WriteLine(veiculos[2]);

             while(veiculos.Count>0){
                 Console.WriteLine(veiculos.Dequeue());
             }

    }
}