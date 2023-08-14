namespace UserAPI
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public string Occupation { get; set; } = string.Empty;
    }
}
