using Jobs_server.Interfaces;
using Jobs_server.Models;

namespace Jobs_server.Services
{
    public class JobService : IJobService
    {
        public static List<Job> jobs = new List<Job>() { 
            new Job() { Field=Fields.BackEnd,Name="Back-End Devellepor",Area="north",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.QA,Name="QA",Area="north",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.FullStackDevelepor,Name="FullStackDevelepor",Area="north",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.BackEnd,Name="Back-End Devellepor",Area="south",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.QA,Name="QA 2",Area="south",Requirements="",Hours=60,fromHome=true},
            new Job() { Field=Fields.FullStackDevelepor,Name="FullStackDevelepor 2",Area="south",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.BackEnd,Name="Back-End Devellepor 3",Area="center",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.QA,Name="QA 3",Area="center",Requirements="",Hours=60,fromHome=true},
            new Job() { Field=Fields.FullStackDevelepor,Name="FullStackDevelepor 3",Area="center",Requirements="",Hours=70,fromHome=false}
        };
    
        public List<Job> GetJobs()
         {
                return jobs;
         }
    }
}
