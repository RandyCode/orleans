﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Orleans.Hosting
{
    public class MonitoringStorageOptions
    {
        /// <summary>
        /// Data connection string for statistic table and metric table
        /// </summary>
        public string DataConnectionString { get; set; }
    }
}
