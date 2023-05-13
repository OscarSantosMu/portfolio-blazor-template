using System.Net.Http.Json;

namespace Portfolio.ViewModels
{
    public class ResumeViewModel : IResumeViewModel
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

        private HttpClient _httpClient;

        public ResumeViewModel()
        {

        }
        public ResumeViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<ResumeModel?> GetResume()
        {
            return await _httpClient.GetFromJsonAsync<ResumeModel>("sample-data/resume.json");
        }
        public async Task GetBackground()
        {
            ResumeModel? resume = await GetResume();
            LoadBackground(resume);
        }
        public async Task GetSkills()
        {
            ResumeModel? resume = await GetResume();
            LoadSkills(resume);
        }

        public async Task GetAccomplishments()
        {
            ResumeModel? resume = await GetResume();
            LoadAccomplishments(resume);
        }

        public async Task GetProjects()
        {
            ResumeModel? resume = await GetResume();
            LoadProjects(resume);
        }

        public async Task<ProjectModel?> GetProject(string projectName)
        {
            ResumeModel? resume = await GetResume();
            LoadProjects(resume);
            foreach (var project in resume?.Projects ?? new List<ProjectModel>())
            {
                if (project.Title == projectName)
                {
                    Console.WriteLine("Project found");
                    return project;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Project not found");
            return null;
        }

        private void LoadBackground(ResumeViewModel? resumeViewModel)
        {
            this.Name = resumeViewModel?.Name;
            this.About = resumeViewModel?.About;
            this.Experiences = resumeViewModel?.Experiences;
            this.Educations = resumeViewModel?.Educations;
            this.Volunteers = resumeViewModel?.Volunteers;
            this.Communities = resumeViewModel?.Communities;

        }

        private void LoadSkills(ResumeViewModel? resumeViewModel)
        {
            this.Name = resumeViewModel?.Name;
            this.About = resumeViewModel?.About;
            this.Skills = resumeViewModel?.Skills;
            this.Certifications = resumeViewModel?.Certifications;

        }

        private void LoadAccomplishments(ResumeViewModel? resumeViewModel)
        {
            this.Name = resumeViewModel?.Name;
            this.About = resumeViewModel?.About;
            this.Awards = resumeViewModel?.Awards;
            this.Patents = resumeViewModel?.Patents;
            this.Articles = resumeViewModel?.Articles;
            this.Conferences = resumeViewModel?.Conferences;
            this.Mentorships = resumeViewModel?.Mentorships;
        }

        private void LoadProjects(ResumeViewModel? resumeViewModel)
        {
            this.Name = resumeViewModel?.Name;
            this.About = resumeViewModel?.About;
            this.Projects = resumeViewModel?.Projects;
        }

        public static implicit operator ResumeViewModel(ResumeModel? resume)
        {
            return new ResumeViewModel
            {
                Name = resume?.Name,
                About = resume?.About,
                Experiences = resume?.Experiences,
                Educations = resume?.Educations,
                Volunteers = resume?.Volunteers,
                Skills = resume?.Skills,
                Certifications = resume?.Certifications,
                Communities = resume?.Communities,
                Awards = resume?.Awards,
                Patents = resume?.Patents,
                Articles = resume?.Articles,
                Conferences = resume?.Conferences,
                Mentorships = resume?.Mentorships,
                Projects = resume?.Projects
            };
        }

        public static implicit operator ResumeModel(ResumeViewModel resumeViewModel)
        {
            return new ResumeModel
            {
                Name = resumeViewModel.Name,
                About = resumeViewModel.About,
                Experiences = resumeViewModel.Experiences,
                Educations = resumeViewModel.Educations,
                Volunteers = resumeViewModel.Volunteers,
                Skills = resumeViewModel.Skills,
                Certifications = resumeViewModel.Certifications,
                Communities = resumeViewModel.Communities,
                Awards = resumeViewModel.Awards,
                Patents = resumeViewModel.Patents,
                Articles = resumeViewModel.Articles,
                Conferences = resumeViewModel.Conferences,
                Mentorships = resumeViewModel.Mentorships,
                Projects = resumeViewModel.Projects
            };
        }
    }
}