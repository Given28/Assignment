using Assignment;

namespace Assignment
{
    class BeerSong
    {
        public void Sing()
        {
            for (int bottles = 99; bottles > 0; bottles--)
            {
                {
                    if (bottles > 1)

                    {

                        Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                        Console.WriteLine("Take one down and pass it around,");
                        Console.WriteLine($"{bottles - 1} bottles of beer on the wall.");
                    }
                    else

                    {
                        Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                        Console.WriteLine($"Take one down and pass it around,");


                    }
                    Console.WriteLine();

                }
            }
            Console.WriteLine($"No more bottles of beer on the wall no more bottles of beer");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall");
        }


    }
    }
    
    class program
    {
        static void Main(string[] args)
        {
            BeerSong beersong = new BeerSong();
            beersong.Sing();
        }
    }

