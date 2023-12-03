﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningDDD.Domain
{
    public static class Shared
    {
        public static bool IsFake()
        {
            return ConfigurationManager.AppSettings["IsFake"] == "1";
        }
        public static string FakePath { get; } = ConfigurationManager.AppSettings["FakePath"];

        public static string LoginId { get; set; } = String.Empty;

    }
}
