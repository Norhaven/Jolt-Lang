﻿using Jolt.Library;
using Jolt.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jolt.Parsing
{
    public class MethodParameter
    {
        public Type Type { get; }
        public string Name { get; }
        public bool IsLazyEvaluated { get; }

        public MethodParameter(Type type, string name, bool isLazyEvaluated)
        {
            Type = type;
            Name = name;
            IsLazyEvaluated = isLazyEvaluated;
        }
    }
}
