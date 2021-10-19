using System;
class Aula24{
    static void Main(){
        //for(int i=0;i<10;i++){
            int V1,V2,r;
            V1=Convert.ToInt32(Console.ReadLine());
            V2=Convert.ToInt32(Console.ReadLine());
            r=soma(V1,V2);
            Console.WriteLine("A Soma de {0} e {1} é: {2}", V1,V2,r);
       // }       

    }
    static int soma(int n1, int n2){
        int res=n1+n2;
        //Console.WriteLine("A Soma de {0} e {1} é: {2}", n1,n2,res);
        return res;

    }
    //metodo estatico que invoca um retorno.
    //void nao retorna nada
    //ola sera um metodo
    // static void CFB(){
    //     Console.WriteLine("CFB Cursos ");
    //     Console.WriteLine("Curso de C#");
    //     Console.WriteLine("youtube.com/cfbcursos");
    // }
}