using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Calemas.Erp.Dto
{
	public class StatusClienteDtoSpecialized : StatusClienteDto
	{

        public IEnumerable<ClienteDto> CollectionCliente { get; set;} 

		
	}
}