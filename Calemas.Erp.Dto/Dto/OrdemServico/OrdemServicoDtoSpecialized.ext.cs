using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Calemas.Erp.Dto
{
	public class OrdemServicoDtoSpecialized : OrdemServicoDto
	{
        public AgendaDto Agenda { get; set; }
        public int[] ResponsavelIds { get; set; }

    }
}