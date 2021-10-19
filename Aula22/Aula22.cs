using System;
class Aula22{
    static void Main(){
        int[] num=new int[5]{11,22,33,44,55};
        
        for(int i=0;i<num.Length;i++){
             Console.WriteLine(num[i]);

         }

        //forech ele eh mais simples. leitura e interacao
        //recebe vsriaveis do mesmo tipo da colecao(vetor)
        //e informa a colecao.        
        foreach(int n in num){
           Console.WriteLine(n);


        }


    }

}