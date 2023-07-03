namespace Movies
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Movie(int id, string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
            Id = id;
        }

        public void Update(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}
