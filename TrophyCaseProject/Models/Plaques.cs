namespace TrophyCaseProject.Models
{
    public class Plaques
    {
        public int Id { get; set; }
        public string? Classification { get; set; }
        public int Year { get; set; }

        public List<Winner> Winners { get; set; }
    }
    public class Winner
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string? Name { get; set; }
    }
}
