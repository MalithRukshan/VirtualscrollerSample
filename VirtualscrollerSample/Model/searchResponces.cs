using System.Collections.Generic;

namespace VirtualscrollerSample.Model
{
    public class SearchResponces
    {
       public List<PatientDto> Result { get; set; }
        public int RowCount { get;set; }
    }
}
