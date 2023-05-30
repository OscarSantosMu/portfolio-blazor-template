namespace Portfolio.ViewModels
{
    public interface IResumeViewModel
    {
        public string? Name { get; set; }
        public string? About { get; set; }
        public List<ExperienceModel>? Experiences { get; set; }
        public List<EducationModel>? Educations { get; set; }
        public List<VolunteerModel>? Volunteers { get; set; }
        public List<SkillModel>? Skills { get; set; }
        public List<CertificationModel>? Certifications { get; set; }
        public List<CommunityModel>? Communities { get; set; }
        public List<AwardModel>? Awards { get; set; }
        public List<PatentModel>? Patents { get; set; }
        public List<ArticleModel>? Articles { get; set; }
        public List<ConferenceModel>? Conferences { get; set; }
        public List<MentorshipModel>? Mentorships { get; set; }
        public List<ProjectModel>? Projects { get; set; }
        public List<ProjectModel> FilterProjects(string selectedDomain, string selectedTechStack, string condition);

        public Task GetSkills();
        public Task GetBackground();
        public Task GetAccomplishments();
        public Task GetProjects();
        public Task<ProjectModel?> GetProject(string projectName);
    }
}