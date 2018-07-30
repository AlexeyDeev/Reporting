﻿using System.Collections;
using System.Collections.Generic;
using Reporting.Core.Abstractions;
using Reporting.Core.Enums;

namespace Reporting.Data.ReportParameters
{
    public sealed class SimpleParameter : ParameterBase, IReportParameter
    {
        public IEnumerable ParameterValues { get; private set; }
        public ReportParameterType ParameterType => ReportParameterType.Simple;

        public SimpleParameter(string id) : base(id)
        {
        }

        public void SetParameterValues(IEnumerable<SimpleParameterValue> values)
        {
            ParameterValues = values;
        }
    }
}