using System;
//METODOS CONSTRUTOR E DESTRUTOR
//Se nao usa modificar, a classe eh publlica
public class Jogador{

    //propriedade, de escopo global
    public int energia;
    public bool vivo;  
    public string nome;
    
    //Construtor, tem o mesmo nome da classe e as propriedades ja estao iniciados.
    //essas propriedades sao de escopo local
        public Jogador (string n){
        energia=100;
        vivo=true;
        nome=n;
        }
         //metodo destruturor
         ~Jogador(){
         Console.WriteLine("Jogador {0} foi destruido",nome);
        }   
}
class Aula29{
    static void Main(){

        string nome1; //tem o mesmo nome, mas sao diferentes por causa do escopo
        Console.WriteLine("Digite o nome do Jogador 1: ");
        nome1=Console.ReadLine();

        Jogador j1=new Jogador(nome1); //Instancia novo Jogador objeto, alocamemoria para objeto do mesmo tipo, mas em lugar diferente.
        Jogador j2=new Jogador("Theo");       

        Console.WriteLine("Nome do Jogador 1:{0}", j1.nome);
        Console.WriteLine("Nome do Jogador 2:{0}", j2.nome);

    }
}