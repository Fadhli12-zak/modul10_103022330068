namespace modul10_103022330068.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> starts { get; set; }
        public string description { get; set; }

        public Movie(string title, string director, List<string> starts, string description)
        {
            Title = title;
            Director = director;
            this.starts = starts;
            this.description = description;
        }
    }
}
