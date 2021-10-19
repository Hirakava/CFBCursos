using System;

class Calc{
    public int soma(params int[]n){
        int s=0;
        for (int i = 0; i<n.Length;i++)
        {
            s+=n[i];
        }
        return s;
    }    
     public double soma(params double[]n){
        double s=0;
        for (int i = 0; i < n.Length;i++)
        {
            s+=n[i];
        }

        return s;
    }   
    // public int soma(int n1, int n2, int n3){
    //     return n1+n2+n3;
    // }   
    // public int soma(int n1, int n2, int n3, int n4){
    //     return n1+n2+n3+n4;
    // }     
}

class Aula47{
    static void Main(){
        double res;
        Calc calc=new Calc();
        res=calc.soma(10.2,5.4);
        Console.WriteLine(res);
    }
}
