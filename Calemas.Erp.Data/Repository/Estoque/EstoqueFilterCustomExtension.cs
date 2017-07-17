using Common.Domain.Model;
using Calemas.Erp.Domain.Entitys;
using Calemas.Erp.Domain.Filter;
using System.Linq;

namespace Calemas.Erp.Data.Repository
{
    public static class EstoqueFilterCustomExtension
    {

        public static IQueryable<Estoque> WithCustomFilters(this IQueryable<Estoque> queryBase, EstoqueFilter filters)
        {
            var queryFilter = queryBase;


            return queryFilter;
        }

		public static IQueryable<Estoque> WithLimitSubscriber(this IQueryable<Estoque> queryBase, CurrentUser user)
        {
            var subscriberId = user.GetSubjectId<int>();
			var queryFilter = queryBase;

            return queryFilter;
        }

    }
}
