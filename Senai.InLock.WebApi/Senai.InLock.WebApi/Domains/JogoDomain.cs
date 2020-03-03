using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        
        [Required(ErrorMessage = "O nome do jogo não foi informado")]
        public string NomeJogo { get; set; }

        [Required(ErrorMessage = "A descrição não foi informado")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data de lançamento do jogo não foi informada")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O valor do jogo não foi informado")]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O estúdio não foi informado")]
        public int IdEstudio { get; set; }
        public EstudioDomain Estudio { get; set; }
    }
}
