using System.Collections;
using System.Collections.Generic;
using Reporting.Core.Abstractions;
using Reporting.Core.Enums;

namespace Reporting.Data.ReportParameters
{
    public class MultiValueParameter : ParameterBase, IReportParameter
    {
        public ReportParameterType ParameterType => ReportParameterType.Multivalue;
        public IEnumerable ParameterValues { get; private set; }
        public MultiValueParameter(string id) : base(id)
        {
        }
        public void SetParameterValues(IEnumerable<MultiParameterValue> values)
        {
            ParameterValues = values;
        }
    }
}