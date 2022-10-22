using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Client.Shared
{
    public class PlayerProfileViewModel
    {
        public int PlayerId {  get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public List<Performance> Performances { get; set; }
    }
}
