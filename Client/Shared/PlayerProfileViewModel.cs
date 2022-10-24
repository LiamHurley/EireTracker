using System.ComponentModel.DataAnnotations;

namespace Client.Shared
{
    public class PlayerProfileViewModel
    {
        public int PlayerId {  get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required] 
        public string Club { get; set; }
        [Required] 
        public string Position { get; set; }
        [Required] 
        public OverallStats OverallStats { get; set; }
        [Required]
        public List<Performance> Performances { get; set; }
    }
}
