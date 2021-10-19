using System;

class Veiculo{
    //roteiro, molde de guia de classe abstrata
    sealed abstract class Veiculo{ //nao pode ser herdada

    }
    // class Carro:Veiculo{  // nao funciona porque classe SEALED nao pode ter heranca
    // }
}
class Aula40{
    static void Main(){
        Carro c1=new Carro();

    }
}