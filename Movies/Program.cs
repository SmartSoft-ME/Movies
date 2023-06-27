namespace Movies
{
    internal class Movie
    {

        public string genre { get; set; }

        public string name { get; set; }

        public int year { get; set; }

        public Movie(string name, string genre, int year)
        {
            this.name = name;
            this.genre = genre;
            this.year = year;


        }




        public static void Main(string[] args)
        {
            int choice;
            List<Movie> list = new List<Movie>();




            void printOptions()
            {
                Console.WriteLine("Please Choose the action you want to perform !");
                Console.WriteLine("1: Create item");
                Console.WriteLine("2: Update item");
                Console.WriteLine("3: Delete item");
                Console.WriteLine("4: Display item");
                Console.WriteLine("5: Exit \n");
            }

            do
            {
                printOptions();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the name of the Movie!");
                        string name = Console.ReadLine();

                        Console.WriteLine("Please enter the genre of the Movie !");
                        string genre = Console.ReadLine();

                        Console.WriteLine("Please enter the year of the Movie !");
                        int year = int.Parse(Console.ReadLine());

                        Movie m = new Movie(name, genre, year);
                        list.Add(m);


                        break;

                     case 2:
                     Console.WriteLine("Please enter the name of the Movie you want to Change!");
                     string oldname = Console.ReadLine();

                  
                            Console.WriteLine("Please enter the new name: ");
                            string newName = Console.ReadLine();
                            Console.WriteLine("Please enter the new genre: ");
                      string newGenre = Console.ReadLine();
                     Console.WriteLine("Please enter the new release year: ");
                      int newYear = int.Parse(Console.ReadLine());

                            int counter = 0;

                            foreach (Movie movie in list.ToList())
                            {
                                if (movie.name == oldname)
                                {
                                    movie.name = newName;
                                    movie.genre = newGenre;
                                    movie.year = newYear;
                                    counter++;
                                    Console.WriteLine("Movie updated successfuly");
                                    break;
                                }
                            }

                            if (counter == 0) Console.WriteLine("Movie not found ya errrr !!!") ;


                     break;

                    case 3:
                        Console.WriteLine("Please enter the name of the Movie you want to Delete !");
                        string Dname = Console.ReadLine();

                        Console.WriteLine("Please enter the genre of the Movie you want to Delete !");
                        string Dgenre = Console.ReadLine();

                        Console.WriteLine("Please enter the year of the Movie you want to Delete !");
                        int Dyear = int.Parse(Console.ReadLine());

                        foreach (var i in list.ToList())
                        {
                            if (i.name == Dname && i.genre == Dgenre && i.year == Dyear)
                            {
                                list.Remove(i);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Movie not found!");
                            }


                        }
                        break;


                    case 4:
                        foreach (var i in list)
                        {
                            Console.WriteLine("List of Movies: {0} {1} {2}", i.name, i.genre, i.year);
                        }


                        break;


                }

            } while (choice != 5);





        }

    }
}