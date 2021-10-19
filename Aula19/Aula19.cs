using System;

namespace Aula19
{
    class Aula19
    {
        static void Main()
        {
            int [] num=new int [10];
            //o i so vale detro do for.
            for (int i=0;i<num.Length;i++){
                num[i]=i;
                
            }

            //o i, so vale dentro de cada for.
            //Length dentro da expressao cuida para que o contador nao exceda o valor.    
            for (int i=0; i<num.Length;i++)
            {
                Console.WriteLine("Valor de num na pos{0}: {1}", i,num[i]);
            }

            
        }
    }
}
