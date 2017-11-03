using Common.Domain.Base;
using Common.Domain.Interfaces;
using Common.Dto;
using Calemas.Erp.Application.Interfaces;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Filter;
using Calemas.Erp.Domain.Interfaces.Services;
using Calemas.Erp.Dto;
using System.Threading.Tasks;
using Common.Domain.Model;
using System.Collections.Generic;

namespace Calemas.Erp.Application
{
    public class InfraestruturaPopApplicationServiceBase : ApplicationServiceBase<InfraestruturaPop, InfraestruturaPopDto, InfraestruturaPopFilter>, IInfraestruturaPopApplicationService
    {
        protected readonly ValidatorAnnotations<InfraestruturaPopDto> _validatorAnnotations;
        protected readonly IInfraestruturaPopService _service;
		protected readonly CurrentUser _user;

        public InfraestruturaPopApplicationServiceBase(IInfraestruturaPopService service, IUnitOfWork uow, ICache cache, CurrentUser user) :
            base(service, uow, cache)
        {
            base.SetTagNameCache("InfraestruturaPop");
            this._validatorAnnotations = new ValidatorAnnotations<InfraestruturaPopDto>();
            this._service = service;
			this._user = user;
        }

       protected override async Task<InfraestruturaPop> MapperDtoToDomain<TDS>(TDS dto)
        {
			return await Task.Run(() =>
            {
				var _dto = dto as InfraestruturaPopDtoSpecialized;
				this._validatorAnnotations.Validate(_dto);
				this._serviceBase.AddDomainValidation(this._validatorAnnotations.GetErros());
				var domain = this._service.GetNewInstance(_dto, this._user);
				return domain;
			});
        }

		protected override async Task<IEnumerable<InfraestruturaPop>> MapperDtoToDomain<TDS>(IEnumerable<TDS> dtos)
        {
			var domains = new List<InfraestruturaPop>();
			foreach (var dto in dtos)
			{
				var _dto = dto as InfraestruturaPopDtoSpecialized;
				this._validatorAnnotations.Validate(_dto);
				this._serviceBase.AddDomainValidation(this._validatorAnnotations.GetErros());
				var domain = await this._service.GetNewInstance(_dto, this._user);
				domains.Add(domain);
			}
			return domains;
			
        }


        protected override async Task<InfraestruturaPop> AlterDomainWithDto<TDS>(TDS dto)
        {
			return await Task.Run(() =>
            {
				var _dto = dto as InfraestruturaPopDto;
				var domain = this._service.GetUpdateInstance(_dto, this._user);
				return domain;
			});
        }



    }
}
