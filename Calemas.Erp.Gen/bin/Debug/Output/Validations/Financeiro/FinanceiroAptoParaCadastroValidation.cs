using Common.Validation;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Interfaces.Repository;

namespace Calemas.Erp.Domain.Validations
{
    public class FinanceiroAptoParaCadastroValidation : ValidatorSpecification<Financeiro>
    {
        public FinanceiroAptoParaCadastroValidation(IFinanceiroRepository rep)
        {
            //base.Add(Guid.NewGuid().ToString(), new Rule<Financeiro>(Instance of RuleClassName,"message for user"));
        }

    }
}
