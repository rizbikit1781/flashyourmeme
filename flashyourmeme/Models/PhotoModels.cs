namespace flashyourmeme.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Branch { get; set; }
        public string PreviewUrl { get; set; }
        public string LinkUrl { get; set; }
    }

}
