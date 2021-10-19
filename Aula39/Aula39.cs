using System;
    //classes abstratas so servem para heranca. ele nao permite criar outro objeto.
        //nao utiliza comportamento.
    //classes abstratas podem ter metodos abstratos ou nao.

    abstract class Veiculo{    
    	
        protected int velMaxima;// diferente de private nao permite acesso
        protected int velAtual;
        protected bool ligado;
        public Veiculo(){
            ligado=false;
            velAtual=0;
        }
        public void setLigado(bool ligado){
            this.ligado=ligado; //obrigado implementar a funcionalidade porque esse metodo nao eh abstrato.
        }
        public int getVelAtual(){
        return velAtual;
        }
        abstract public void aceleracao(int mult); //nao precisa iumplementar nada porque eh abstract  
    }     
      
    class Carro:Veiculo{
        public Carro(){
            velMaxima=120;
        }   

        override public void aceleracao(int mult){ //metodo implementado do abstract
        velAtual+=10*mult;
        }
    }

class Aula39{
    static void Main(){
        Carro carro1=new Carro();
        carro1.aceleracao(1);
        carro1.aceleracao(1);
        Console.WriteLine(carro1.getVelAtual());
    }    
}

