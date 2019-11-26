﻿using System.Reflection;
using NpgsqlTypes;

namespace Copy.Internal.Models
{
    class EmitInfo
    {
        public string PostgresName { get; set; }
        public string PostgresType { get; set; }
        public MethodInfo Getter { get; set; }
        public MethodInfo WriteMethod { get; set; }
    }
}