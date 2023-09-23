using dotnet_intern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_task
{
    public class ProgramDetails
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string? Summary { get; set; }
        public string Description { get; set; }
        public List<string>? Key { get; set; }
        public string? Benefits { get; set; }
        public string? Criteria { get; set; }
        public ProgramTypes ProgramType { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly OpenDate { get; set; }
        public DateOnly CloseDate { get; set; }
        public string? Duration { get; set; }
        public string Location { get; set; }
        public bool Remote { get; set; }
        public MinQualification MinQualification { get; set; }
        public int MaxNumApplication { get; set; }



    }
}
