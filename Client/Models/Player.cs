﻿namespace Client.Models
{
    public class Player
    { 
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Club { get; set; }
        public List<Performance>? Performances { get; set; }
    }
}
