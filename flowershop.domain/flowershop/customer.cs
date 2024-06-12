namespace flowershop.domain.flowershop
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<flowers>flowers { get; set; }
}
}
