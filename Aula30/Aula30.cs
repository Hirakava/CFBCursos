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

        //SOBRECARREGANDO CONSTRUTOR
        public Jogador (){
            energia=100;
            vivo=true;
            nome="Jogador";
        }
        public Jogador (string n, int e){
        energia=e;
        vivo=true;
        nome=n;
        }
          public Jogador (string n, int e, bool v){
        energia=100;
        vivo=false;
        nome=n;
        }
        public void info(){
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador:{0}", energia);
            Console.WriteLine("Status jogador:{0}\n", vivo);            
        }
        public void info(int n){
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador:{0}", energia);
            Console.WriteLine("Status jogador:{0}\n", vivo);            
        }
        
}
class Aula30{
    static void Main(){        

        Jogador j1=new Jogador(); //Instancia novo Jogador objeto, alocamemoria para objeto do mesmo tipo, mas em lugar diferente.
        Jogador j2=new Jogador("Bruno");
        Jogador j3=new Jogador("Theo",100);          
        Jogador j4=new Jogador("Benegundesfirno",0,false);     

       j1.info();
       j2.info();
       j3.info();
       j4.info();

    }
}