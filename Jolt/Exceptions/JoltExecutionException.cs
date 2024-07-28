﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jolt.Exceptions
{
    public sealed class JoltExecutionException : JoltException
    {
        public JoltExecutionException(string message) 
            : base(message)
        {
        }
    }
}
