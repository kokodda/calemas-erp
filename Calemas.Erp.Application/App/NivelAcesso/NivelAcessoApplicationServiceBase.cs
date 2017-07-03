using Common.Domain.Base;
using Common.Domain.Interfaces;
using Common.Dto;
using Calemas.Erp.Application.Interfaces;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Filter;
using Calemas.Erp.Domain.Interfaces.Services;
using Calemas.Erp.Dto;
using System.Threading.Tasks;

namespace Calemas.Erp.Application
{
    public class NivelAcessoApplicationServiceBase : ApplicationServiceBase<NivelAcesso, NivelAcessoDto, NivelAcessoFilter>, INivelAcessoApplicationService
    {
        protected readonly ValidatorAnnotations<NivelAcessoDto> _validatorAnnotations;
        protected readonly INivelAcessoService _service;

        public NivelAcessoApplicationServiceBase(INivelAcessoService service, IUnitOfWork uow, ICache cache) :
            base(service, uow, cache)
        {
            base.SetTagNameCache("NivelAcesso");
            this._validatorAnnotations = new ValidatorAnnotations<NivelAcessoDto>();
            this._service = service;
        }


        protected override NivelAcesso MapperDtoToDomain<TDS>(TDS dto)
        {
			var _dto = dto as NivelAcessoDtoSpecialized;
            this._validatorAnnotations.Validate(_dto);
            this._serviceBase.AddDomainValidation(this._validatorAnnotations.GetErros());

			var domain = new NivelAcesso.NivelAcessoFactory().GetDefaaultInstance(_dto);
            return domain;
        }


        protected override async Task<NivelAcesso> AlterDomainWithDto<TDS>(TDS dto)
        {
			var nivelacesso = dto as NivelAcessoDto;
            var result = await this._serviceBase.GetOne(new NivelAcessoFilter { NivelAcessoId = nivelacesso.NivelAcessoId });

            //Inicio da Transferencia dos valores
           

            //Fim da Transferencia dos valores

            return result;
        }

    }
}