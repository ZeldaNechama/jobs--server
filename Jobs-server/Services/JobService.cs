using Jobs_server.Interfaces;
using Jobs_server.Models;

namespace Jobs_server.Services
{
    public class JobService : IJobService
    {
        public static List<Job> jobs = new List<Job>() { 
            new Job() { Field=Fields.BackEnd,Name="",Area="north",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.BackEnd,Name="",Area="north",Requirements="",Hours=60,fromHome=false},
            new Job() { Field=Fields.BackEnd,Name="",Area="north",Requirements="",Hours=60,fromHome=false}
        };
    
        public List<Job> GetJobs()
         {
                return jobs;
         }
    }
}
