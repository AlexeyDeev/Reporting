using System.Collections.Generic;

namespace Reporting.Data.ReportParameters
{
    public class MultiParameterValue
    {
        public string DisplayValue { get; set; }
        public List<object> Value { get; set; }
    }
}