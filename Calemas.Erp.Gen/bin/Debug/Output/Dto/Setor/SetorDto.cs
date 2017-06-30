using System.ComponentModel.DataAnnotations;
using Common.Dto;
using System;

namespace Calemas.Erp.Dto
{
	public class SetorDto  : DtoBase
	{
	
        

        public virtual int SetorId {get; set;}

        [Required(ErrorMessage="Setor - Campo Nome é Obrigatório")]
        [MaxLength(50, ErrorMessage = "Setor - Quantidade de caracteres maior que o permitido para o campo Nome")]
        public virtual string Nome {get; set;}

        

        public virtual string Descricao {get; set;}

        [Required(ErrorMessage="Setor - Campo Cor é Obrigatório")]
        [MaxLength(7, ErrorMessage = "Setor - Quantidade de caracteres maior que o permitido para o campo Cor")]
        public virtual string Cor {get; set;}

        [Required(ErrorMessage="Setor - Campo Ativo é Obrigatório")]
        public virtual bool Ativo {get; set;}


		
	}
}