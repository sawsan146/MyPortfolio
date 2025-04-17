namespace portfolio.Models
{
    public class Project
    {

        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public string GitHubUrl { get; set; }

        public List<ProjectSkill> ProjectSkills { get; set; }

    }
}
