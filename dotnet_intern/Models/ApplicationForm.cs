using dotnet_intern.Enums;

namespace dotnet_intern
{
    public class Cover
    {
        public int Id { get; set; }
        public IFormFile File { get; set; }

        public ApplicationForm ApplicationForm { get; set; }

    }
    public class ApplicationForm
    {
        public int Id { get; set; }

        public PersonalInfo PersonalInfo { get; set; }
        public Profile Profile { get; set; }
        public Cover Cover { get; set; }
    }
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool HidePhone { get; set; }
        public bool IntarnalPhone { get; set; }
        public bool HideNationalty { get; set; }
        public bool IntarnalNationalty { get; set; }
        public string? Benefits { get; set; }
        public string? Criteria { get; set; }
        public bool HideResidence { get; set; }
        public bool IntarnalResidence { get; set; }
        public bool HideIdNum { get; set; }
        public bool IntarnalIdNum { get; set; }
        public bool HideDateOfBirth { get; set; }
        public bool IntarnalDateOfBirth { get; set; }
        public bool HideGender { get; set; }
        public bool IntarnalGender { get; set; }
        public ApplicationForm ApplicationForm { get; set; }
        public List<Qeustion> Qeustions { get; set; }
    }

    public class Qeustion
    {
        public int Id { get; set; }
        public TypeOfQeustion Type { get; set; }
        public string _Question { get; set; }
        public List<Choises>? Choises { get; set; }
        public bool? EnableOther { get; set; }
        public bool? Disqualfiyno { get; set; }
        public int? MaxAllowed { get; set; }
        public ApplicationForm ApplicationForm { get; set; }
    }

    public class Profile
    {
        public int Id { get; set; }
        public bool HideEducation { get; set; }
        public bool MandatoryEducation { get; set; }
        public bool HideExperience { get; set; }
        public bool MandatoryExperience { get; set; }
        public bool HideResume { get; set; }
        public bool MandatoryResume { get; set; }
        public ApplicationForm ApplicationForm { get; set; }
    }


    public class Choises
    {
        public int Id { get; set; }
        public string Option { get; set; }
        public Qeustion Qeustion { get; set; }
    }
}
