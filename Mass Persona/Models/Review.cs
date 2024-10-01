namespace Mass_Persona.Models
{
    public class Review
    {
        public int ReviewID { get; set; }  // Primary key
        public string Title { get; set; }
        public string Category { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime DateReviewed { get; set; }
    }
}
