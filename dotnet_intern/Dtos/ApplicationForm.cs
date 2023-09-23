using dotnet_intern.Enums;

namespace dotnet_intern.Dtos
{
    public class ApplicationForm
    {
        public class Cover
        {
        public IFormFile File{ get; set; }

        }
        public class PersonalInfo
        {
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

            public List<Qeustion>Qeustions { get; set; }
        }

        public class Qeustion
        {
            public TypeOfQeustion Type{ get; set; }
            public string _Question { get; set; }
            public List<string>? Choises { get; set; }
            public bool? EnableOther { get; set; }
            public bool? Disqualfiyno { get; set; }
            public int? MaxAllowed { get; set; }
        }

        public class Profile
        {
            public bool HideEducation { get; set; }
            public bool MandatoryEducation { get; set; }
            public bool HideExperience { get; set; }
            public bool MandatoryExperience{ get; set; }
            public bool HideResume { get; set; }
            public bool MandatoryResume { get; set; }
        }

    }
}
