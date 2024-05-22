using Jobs_server.Interfaces;
using Jobs_server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jobs_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        IJobService JobService;

        public JobController(IJobService jobService)
        {
            this.JobService = jobService;
        }

        [HttpGet]
        public List<Job> GetJobs()
        {
            return this.JobService.GetJobs();
        }
    }
}
