namespace API.CQRS.Results.Service
{
    public class ServiceByIDResult
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string? ServiceIcon { get; set; }
    }
}
