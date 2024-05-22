namespace Jobs_server.Models
{
    public class Job
    {
        public Fields Field { get; set; }
        public string? Name { get; set; }
        public int Hours { get; set; }
        public string? Area { get; set; }
        public string? Requirements { get; set; }
        public bool fromHome { get; set; }
    }
    public enum Fields
    {
        FullStackDevelepor,
        QA,
        BackEnd
    }
}
