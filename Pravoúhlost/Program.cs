namespace Pravoúhlost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                CW("Zadej délku strany a");
                int strana_a = Convert.ToInt32(Console.ReadLine());
                CW("Zadej délku strany b");
                int strana_b = Convert.ToInt32(Console.ReadLine());
                CW("Zadej délku strany c");
                int strana_c = Convert.ToInt32(Console.ReadLine());


                bool pravouhly1 = (strana_c * strana_c) == strana_b * strana_b + strana_a * strana_a;
                bool pravouhly2 = strana_b * strana_b == strana_a * strana_a + strana_c * strana_c;
                bool pravouhly3 = strana_a * strana_a == strana_b * strana_b + strana_c * strana_c;


                if (pravouhly1 || pravouhly2 || pravouhly3)
                {
                    CW("Je pravoúhlý.");
                }
                else
                {
                    CW("Není pravoúhlý");
                }




                CW("");
            }
        }

        



        public static void CW(string txt)
        {
            Console.WriteLine(txt);
        }

} }