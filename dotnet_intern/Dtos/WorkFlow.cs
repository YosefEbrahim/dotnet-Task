using dotnet_intern.Enums;

namespace dotnet_intern.Dtos
{
    public class WorkFlow
    {

        public List<string> Stages { get; set; }

        public class NewStage
        {
            public string NameStage { get; set; }
            public StageType StageType { get; set; }

            public string ViedoQuestion { get; set; }
            public string ViedoDes { get; set; }
            public int Duration{ get; set; }
            public Duration Durationtype { get; set; }
            public int SubmitionDays { get; set; }

        }
    }
}
