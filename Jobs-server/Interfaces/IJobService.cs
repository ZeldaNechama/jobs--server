using Jobs_server.Models;

namespace Jobs_server.Interfaces
{
    public interface IJobService
    {
        List<Job> GetJobs();
    }
}
