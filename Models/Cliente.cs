using System.ComponentModel.DataAnnotations;

namespace ClienteApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeCompleto { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(20)]
        public string RG { get; set; }

        [Required]
        [StringLength(20)]
        public string CPF { get; set; }

        // Endereço
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        // Estado Civil
        public string EstadoCivil { get; set; }

        // Nome dos pais
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
    }
}
