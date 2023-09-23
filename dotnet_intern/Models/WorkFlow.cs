using dotnet_intern.Enums;

namespace dotnet_intern
{
    public class WorkFlow
    {
        public int Id { get; set; }
        public string NameStage { get; set; }
        public StageType StageType { get; set; }

        public StageDetails StageDetails { get; set; }
    }

    public class StageDetails
    {
        public int Id { get; set; }

        public string ViedoQuestion { get; set; }
        public string ViedoDes { get; set; }
        public int Duration { get; set; }
        public Duration Durationtype { get; set; }
        public int SubmitionDays { get; set; }
        public WorkFlow WorkFlow { get; set; }

    }
}
