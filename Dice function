namespace Blatte_5___Dice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice = 2;
            int rolls = 6;

            int[,] array = calculation(dice, rolls);
            Console.WriteLine("+---------+----------+");
            Console.WriteLine("+ Augenzahl + Anzahl +");
            Console.WriteLine("+---------+----------+");
            for (int i = 0; i < (5*dice)+1 ; i++)
            
            {
                Console.Write("\n");
                
                
                Console.Write(array[0, i]);
                Console.Write("            "+"|" + array[1, i] + "|");

                

            }
            Console.WriteLine("\n");
            Console.WriteLine("+---------+----------+");

            Console.ReadLine();
        }
        static int[,] calculation(int dice, int rolls)
        {
            Random objektname = new Random();
            int previousrolls = 0;
            
            int[,] anzahl = new int[2, (5 * dice)+1];
            for (int i = 0; i < (5 * dice) + 1; i++)
            {
                if (i == 5 * dice)
                {
                    anzahl[0, i] = i + dice;
                    anzahl[1, i] = rolls - previousrolls;
                    return anzahl;
                }
                anzahl[0, i] = i + dice;
                anzahl[1,i] = objektname.Next(0, rolls - previousrolls+1);
                previousrolls += anzahl[1, i];
            }
            return anzahl;
        }


    }
}
