using System;
//METODOS VIRTUAL - TEM MESMO NOME EM CLASSES DIFERENTES
//
class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
    // virtual public void info(){
    //     Console.WriteLine("Base");
    // }
    virtual public void info(){
        Console.WriteLine("Base");
    }
    

}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada 1");        
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada 2");
    }

}

class Aula38{
    static void Main (){
        Base Ref;
        Derivada1 derivada2=new Derivada1();
        Derivada2 derivada2= new Derivada2();
        Derivada1.info();
        derivada2.info();
        Ref=Derivada2;
        Ref.info();       

    }
}