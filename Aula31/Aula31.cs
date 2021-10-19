using System;

//classe como static, nao posso instanciar um objeto.
//classe static nao pode ter construtores

static public class Jogador{

    //propriedade, de escopo global
    static public int energia;
    static public bool vivo;  
    static public string nome;
    
    //Construtor, tem o mesmo nome da classe e as propriedades ja estao iniciados.
    //essas propriedades sao de escopo local
    //uma classe nao static pode ter um membro nao static
        static public void iniciar (string n){
        energia=100;
        vivo=true;
        nome=n;
        }            
        static public void info(){
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador:{0}", energia);
            Console.WriteLine("Status jogador:{0}\n", vivo);            
        }      
        
}
class Inimigo{
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta=false;
        nome=n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("------------------------------------");

    }
}
class Aula31{
    static void Main(){
       
        Jogador.iniciar("Bruno");
        Jogador.info();
        Inimigo i1=new Inimigo("Doido");
        Inimigo i2=new Inimigo("Maluco");
        Inimigo i3=new Inimigo("Pirado");

        Inimigo.alerta=true;
        i1.info();
        i2.info();
        i3.info();
    }
}

 