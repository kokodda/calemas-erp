using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Calemas.Erp.Dto
{
	public class SolicitacaoEstoqueMovimentacaoDtoSpecializedReport : SolicitacaoEstoqueMovimentacaoDto
	{

        public  EstoqueDto Estoque { get; set;} 
        public  SolicitacaoEstoqueDto SolicitacaoEstoque { get; set;} 

		
	}
}