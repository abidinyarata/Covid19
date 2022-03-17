namespace CovidApp
{
    public class Notify
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ViolationSubject? ViolationSubject { get; set; }
        public ViolationType? ViolationType { get; set; }
        public string? ViolationDetail { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; }
        // Todo: Fotoğraf ekleme işlemi
    }
}