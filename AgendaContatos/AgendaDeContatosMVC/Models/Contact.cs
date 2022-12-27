using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgendaDeContatosMVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("E-mail")]
        public string EMail { get; set; }

        [DisplayName("Telefone")]
        public string Phone { get; set; }

        [DisplayName("Endereço")]
        public string Adress { get; set; }

        [DisplayName("Aniversário")]
        public DateTime Birthday { get; set; }
    }
}
