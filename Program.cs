namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number of day :");
                int NumberOfDay = int.Parse(Console.ReadLine());
                string NameOfDay = NumberOfDay switch
                {
                    1 => "Shanebe",
                    2 => "Yekshanbe",
                    3 => "Doshanbe",
                    4 => "Seshanbe",
                    5 => "Charshanbe",
                    6 => "Panjshanbe",
                    7 => "Jome",
                    _ => "Unknown Day"

                };
                Console.WriteLine(NameOfDay);
            }
              
        }
    }
}
