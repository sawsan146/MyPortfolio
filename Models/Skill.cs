﻿namespace portfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public List<ProjectSkill> ProjectSkills { get; set; }
    }
}
