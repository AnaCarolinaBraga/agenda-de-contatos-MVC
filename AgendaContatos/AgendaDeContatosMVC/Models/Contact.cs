using System.ComponentModel.DataAnnotations;

namespace AgendaDeContatosMVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public DateTime Birthday { get; set; }
    }
}
