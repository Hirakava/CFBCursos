using System;
class Aula12{
    static void Main(){
        //SE (EXPRESSAO LOGICA E VERDADEIRA EXECUTA-SE A OPERACAO DO BLOCO A BAIXO)
        int nota=80;
        string resultado="Reprovado";


        if (nota>=60){
            resultado="Aprovado";
        }
        Console.WriteLine("Resultado: {0}", resultado);

    }
}
