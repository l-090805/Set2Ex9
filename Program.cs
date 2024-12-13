namespace Set2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lungimea secventei de numere: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            Console.WriteLine("Elementele secventei: ");

            int prev = int.Parse(Console.ReadLine());
            bool esteCresc = true;
            bool esteDesc = true;


            for(int i = 1; i < n; i++)
            {
                int curent = int.Parse(Console.ReadLine());
                if(curent < prev)
                {
                    esteCresc = false;
                }
                if(curent > prev)
                {
                    esteDesc = false;
                }

                prev = curent;
            }
            
            if(esteCresc || esteDesc)
            {
                Console.WriteLine("Seria este monotona");
            }
            else
            {
                Console.WriteLine("Nu este monotona");
            }
            
        }
    }
}
