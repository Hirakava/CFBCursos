using System;
class Aula27{
    static void Main(){
        Soma(10,5,2,4,7);

    }
    static void Soma(params int[]n){
        //int res=n1+n2;
        int res=0;
        if (n.Length<1){
            Console.WriteLine("Nao existem valores a serem somados");
        }
        else if(n.Length<2){
            Console.WriteLine("Valores insuficienes para soma: {0}", n[0]);
        }
        else{
            for (int i=0;i<n.Length;i++){
                res+=n[i];
            }
        }

        Console.WriteLine("A Soma dos valores sao: {0}",res);
    }
}