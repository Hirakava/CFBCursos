using System;
class Aula25{

    //precisa usar passagem por referencia, senao o metodo dobrar nao enxerga a variavel
    //usa o endereco de memoria como referencia
    static void Main(){
        int num=10;
        dobrar(ref num);
        Console.WriteLine(num);

    }
    static void dobrar(ref int valor){
        valor*=2;

    }
}