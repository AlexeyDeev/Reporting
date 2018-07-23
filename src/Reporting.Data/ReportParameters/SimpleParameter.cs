using System;
using System.Collections.Generic;
using Reporting.Core.Abstractions;
using Reporting.Core.Enums;

namespace Reporting.Data.ReportParameters
{
    public sealed class SimpleParameter : IReportParameter
    {
        public string Id { get; }
        public ReportParameterTypes ParameterType { get; }
        public string DisplayName { get; private set; }
        public List<SimpleParameterValue> ParameterValues { get; private set; }

        public SimpleParameter(string id, ReportParameterTypes parameterType)
        {
            Id = id;
            ParameterType = parameterType;
        }

        public void SetDisplayName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ApplicationException("Displayname can't be null or empty");
            }

            DisplayName = name;
        }

        public void SetParameterValues(List<SimpleParameterValue> values)
        {
            ParameterValues = values;
        }
    }
}