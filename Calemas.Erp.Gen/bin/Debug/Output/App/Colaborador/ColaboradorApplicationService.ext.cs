using Common.Domain.Interfaces;
using Calemas.Erp.Application.Interfaces;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Filter;
using Calemas.Erp.Domain.Interfaces.Services;
using Calemas.Erp.Dto;
using System.Linq;
using System.Collections.Generic;
using Common.Domain.Base;

namespace Calemas.Erp.Application
{
    public class ColaboradorApplicationService : ColaboradorApplicationServiceBase
    {

        public ColaboradorApplicationService(IColaboradorService service, IUnitOfWork uow, ICache cache) :
            base(service, uow, cache)
        {
  
        }

        protected override System.Collections.Generic.IEnumerable<TDS> MapperDomainToResult<TDS>(FilterBase filter, PaginateResult<Colaborador> dataList)
        {
            return base.MapperDomainToResult<ColaboradorDtoSpecializedResult>(filter, dataList) as IEnumerable<TDS>;
        }


    }
}
