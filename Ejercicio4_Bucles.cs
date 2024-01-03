namespace CSharpPractices
{
    public static class Ejercicio4_Bucles
    {
        public static void PracticaFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PracticaWhile()
        {
            int i = 0;
            
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            
        }
        
        public static void PracticaDoWhile()
        {
            int i = 0;
            
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }
        
    }
};

