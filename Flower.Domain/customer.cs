using System.ComponentModel.DataAnnotations;

namespace flowershop.domain.flowershop
{
    public class customer
    {
        public int Id { get; set; }
        [MaxLength(length: 60)] 
        public string Name { get; set; }
        [MaxLength(length: 24)]
        [Phone]
        public string Email { get; set; }
        public string Phone { get; set; }
        [MaxLength(length: 60)]
        [EmailAddress]
        public List<flowers>flowers { get; set; }
}
}
