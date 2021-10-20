using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAutoEscola.Pages.Contato
{
    public class Contato
    {
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(11)]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "Sua Mensagem")]
        public string Mensagem { get; set; }
    }
}
