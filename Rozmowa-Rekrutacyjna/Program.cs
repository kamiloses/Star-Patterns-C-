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

    
    //     *
    //    ***
    //   *****
    //  *******
    // *********
    public void PyramidStar()
    {
        for (int i = 0; i <5 ; i++)
        {
            for (int j = i; j < 4; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <2*i+1 ; j++)
            {
                Console.Write("*");
            }
            
         
            Console.WriteLine("");
            
        }
        
    }
    
    
    
    
    //      *
    //     * *
    //    *   *
    //   *     *
    //  * * * * *

    public void HollowPyramidStarPattern()
    {
        int height = 5;

        for (int i = 0; i < height; i++)
        {
            for (int j = i; j < height - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (i == height - 1) 
                {
                    if (j % 2 == 0)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                else 
                {
                    if (j == 0 || j == 2 * i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
    
    
//     *
//    ***
//   *****
//  *******
// *********
//  *******
//   *****
//    ***
//     *    

    public void FullPyramidStarPattern()
    {
        int height = 5;
        int spaceWidth = 4;
        for (int i = 0; i < height; i++)
        {
            for (int j = i; j < spaceWidth; j++)
            {
                Console.Write(" ");
            }
            
            for (int j = 0; j < i*2+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(""); }

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = i*2+1; j <=7; j++)
            {
                Console.Write("*");

            }

            Console.WriteLine("");
        }
    }

    
    //8.Rhombus Star Pattern:
    
    


    public class MainClass
    {

        public static void Main(string[] args)
        {
           StarPattern starPattern= new StarPattern();
           starPattern.FullPyramidStarPattern();

        }
        
    }
    
    
    
    
    
}