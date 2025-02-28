namespace API.Dal
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamNameSurname { get; set; }
        public string TeamDescription { get; set; }

        public string? TeamPhoto { get; set; }
    }
}
