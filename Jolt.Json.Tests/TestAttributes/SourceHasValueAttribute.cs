﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jolt.Json.Tests.TestAttributes;

internal class SourceHasValueAttribute(object? value) : SourceHasAttribute(SourceValueType.Unknown, Default.Value, value)
{
}
