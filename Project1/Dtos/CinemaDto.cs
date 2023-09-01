namespace Project1.Dtos
{
    public class CinemaDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public CinemaDto() { }

        public CinemaDto(string name, string description, string type, string url)
        {
            Name = name;
            Description = description;
            Type = type;
            Url = url;
        }
    }
}
