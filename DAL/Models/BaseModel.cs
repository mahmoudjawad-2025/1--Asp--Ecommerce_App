namespace D_A_L.Models
{
    public enum Status
    {
        active=1,
        inActive=2
    }
    public class BaseModel
    {
        public int id { get; set; }
        public DateTime createAt { get; set; } = DateTime.Now;
        public Status status { get; set; }=Status.active;

    }
}
