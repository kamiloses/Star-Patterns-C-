namespace Rozmowa_Rekrutacyjna;

public class StarPattern
{

// *
// **
// ***
// ****
// *****
    public void RightTriangleStar()
    {
        for (int i = 0; i <5; i++)
        {
            for (int j = 0 ; j< i+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    public void InvertedRightTriangleStar()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine("");
        }
        
    }



    public class MainClass
    {

        public static void Main(string[] args)
        {
           StarPattern starPattern= new StarPattern();
           starPattern.InvertedRightTriangleStar();
           
        }
        
    }
    
    
}