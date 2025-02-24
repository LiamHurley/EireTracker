namespace API.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
     //   public List<OverallStats> OverallStats { get; set; }
        public List<Season>? Seasons { get; set; }   
    }
}