using Common.Domain.Model;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Filter;
using System.Linq;

namespace Calemas.Erp.Data.Repository
{
    public static class MotivoEstoqueMovimentacaoFilterCustomExtension
    {

        public static IQueryable<MotivoEstoqueMovimentacao> WithCustomFilters(this IQueryable<MotivoEstoqueMovimentacao> queryBase, MotivoEstoqueMovimentacaoFilter filters)
        {
            var queryFilter = queryBase;


            return queryFilter;
        }

		public static IQueryable<MotivoEstoqueMovimentacao> WithLimitTenant(this IQueryable<MotivoEstoqueMovimentacao> queryBase, CurrentUser user)
        {
            var tenantId = user.GetTenantId<int>();
			var queryFilter = queryBase;

            return queryFilter;
        }

    }
}

