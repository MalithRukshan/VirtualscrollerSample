using VirtualscrollerSample.Model;

namespace VirtualscrollerSample.Services
{
    public interface IDataServices
    {
      SearchResponces PatientSearch(SearchRequest searchRequest);
    }
}
