using System.Linq;
using VirtualscrollerSample.Model;

namespace VirtualscrollerSample.Services
{
    public class DataServices : IDataServices
    {
        private readonly DBContext _context;
        private const int DEFAULT_PAGE_SIZE = 10;
        public DataServices(DBContext _context)
        {
            this._context = _context;
        }

        private IQueryable<PatientDto> Paging(IQueryable<PatientDto> query, int? pageIndex, int? pageSize)
        {
            if (pageIndex == null) return Enumerable.Empty<PatientDto>().AsQueryable();

            pageSize = pageSize != null ? pageSize.Value : DEFAULT_PAGE_SIZE;

            return query.Skip(pageIndex.Value * pageSize.Value).Take(pageSize.Value);
        }

        public SearchResponces PatientSearch(SearchRequest searchRequest)
        {
            IQueryable<PatientDto> postalCodeSearchQuery = _context.Patients

                 .Select(x => new PatientDto()
                 {
                     FirstName = x.FirstName,
                     LastName = x.LastName,
                     Oid = x.Oid,
                     SocialSecurityNumber = x.SocialSecurityNumber
                 });

            var sortedQuery = postalCodeSearchQuery.OrderBy(q => q.Oid).AsQueryable();
            var query = Paging(sortedQuery, searchRequest.PageIndex, searchRequest.PageSize);

            return new SearchResponces()
            {
                RowCount = postalCodeSearchQuery.Count(),
                Result = query.ToList()
            };

        }


    }
}
