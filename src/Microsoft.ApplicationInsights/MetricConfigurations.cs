﻿namespace Microsoft.ApplicationInsights
{
    using System;

    /// <summary>
    /// Static container for the most commonly used metric configurations.
    /// </summary>
    internal sealed class MetricConfigurations
    {
        /// <summary>
        /// Groups extension methods that return pre-defined metric configurations and related constants.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2104", Justification = "Singelton is intended.")]
        public static readonly MetricConfigurations Common = new MetricConfigurations();

        private MetricConfigurations()
        {
        }
    }
}
