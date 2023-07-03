
using Movies;

int choice;
List<Movie> movies = new();


void PrintOptions()
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
    PrintOptions();
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            var id = movies.Any() ? movies.Max(m => m.Id) + 1 : 1;
            Console.WriteLine("Please enter the name of the Movie!");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be null!");
                Console.WriteLine("Please enter the name of the Movie!");
                name = Console.ReadLine();
            }

            Console.WriteLine("Please enter the genre of the Movie !");
            string genre = Console.ReadLine();

            Console.WriteLine("Please enter the year of the Movie !");
            int year = int.Parse(Console.ReadLine());

            Movie m = new Movie(id, name, genre, year);
            movies.Add(m);


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


            var movie = movies.FirstOrDefault(m => m.Name == oldname);
            if (movie is null) Console.WriteLine("Movie not found ya errrr !!!");
            else
            {
                movie.Update(newName, newGenre, newYear);
                Console.WriteLine("Movie updated successfuly");
            }



            break;

        case 3:
            Console.WriteLine("Please enter the name of the Movie you want to Delete !");
            string Dname = Console.ReadLine();

            Console.WriteLine("Please enter the genre of the Movie you want to Delete !");
            string Dgenre = Console.ReadLine();

            Console.WriteLine("Please enter the year of the Movie you want to Delete !");
            int Dyear = int.Parse(Console.ReadLine());
            movies.Remove(movies.FirstOrDefault(m => m.Name == Dname));

            break;


        case 4:
            foreach (var i in movies)
            {
                Console.WriteLine("List of Movies: {0} {1} {2}", i.Name, i.Genre, i.Year);
            }


            break;


    }

} while (choice != 5);





