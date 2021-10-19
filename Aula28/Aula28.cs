using System;
//Se nao usa modificar, a classe eh publlica
public class Jogador{

    //propriedade
    public int energia=100;
    public bool vivo=true;  

}
class Aula28{
    static void Main(){
        Jogador j1=new Jogador(); //Instancia novo Jogador objeto, alocamemoria para objeto do mesmo tipo, mas em lugar diferente.
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();
        Jogador j4=new Jogador();

        j1.energia=50;

        Console.WriteLine("Energia do Jogador 1:{0}", j1.energia);
        Console.WriteLine("Energia do Jogador 2:{0}", j2.energia);

    }
}