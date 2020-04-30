﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using Microsoft.Health.Fhir.Core.Features.Search.SearchValues;

namespace Microsoft.Health.Fhir.Core.Features.Search.Converters
{
    /// <summary>
    /// A converter used to convert from <see cref="FhirDateTime"/> to a list of <see cref="DateTimeSearchValue"/>.
    /// </summary>
    public class DateTimeNodeToDateTimeSearchValueTypeConverter : DateNodeToDateTimeSearchValueTypeConverter
    {
        public override string FhirNodeType { get; } = "dateTime";
    }
}