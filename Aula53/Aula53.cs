using System;

class Area
{
    
    public static float Quad(float bas, float alt)
    {
        if (bas==0 || alt==0)
        {
            throw new Exception ("Base ou Altura nao pode ser igual a Zero");
        }
        return bas*alt;
    }
}

class Aula53
{

    static void Main()
    {
       
            float area=0;
      

            try
            {
                area=Area.Quad(0,5F);
                Console.WriteLine("Area do Quadrado:{0}",area);
            }
             catch (Exception e)
            {
                Console.WriteLine("Error", e.Message);
                
            }     
            finally
            {
                Console.WriteLine("Fim do Processo");
            }             

    }
    
}
