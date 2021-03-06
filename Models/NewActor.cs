namespace movie.Models
{
    public class NewActor
    {
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        public DateTimeOffset Birthdate { get; set; }
    }
}