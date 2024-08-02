﻿using Jolt.Structure;
using System;
using System.Collections.Generic;
using System.Text;
using Nodes = System.Text.Json.Nodes;
using JsonValueKind = System.Text.Json.JsonValueKind;
using System.Text.Json;

namespace Jolt.Json.DotNet
{
    public sealed class JsonValue : JsonToken, IJsonValue
    {
        public JsonValueType ValueType { get; }

        public JsonValue(Nodes.JsonNode? token) 
            : base(token)
        {
            if (_token is null)
            {
                ValueType = JsonValueType.Null;
            }
            else
            {
                ValueType = _token.GetValueKind() switch
                {
                    JsonValueKind.String => JsonValueType.String,
                    JsonValueKind.Number => JsonValueType.Number,
                    JsonValueKind.True => JsonValueType.Boolean,
                    JsonValueKind.False => JsonValueType.Boolean,
                    JsonValueKind.Null => JsonValueType.Null,
                    _ => throw new ArgumentOutOfRangeException(nameof(token), $"Unable to determine best JSON value type for unsupported type '{_token.GetValueKind()}'")
                };
            }
        }

        public bool IsObject<T>() => ToTypeOf<object>()?.GetType() == typeof(T);

        public T ToTypeOf<T>() => base.ToTypeOf<T>();

        public override void Clear()
        {
            ((Nodes.JsonValue)_token).ReplaceWith<string>(default);
        }
    }
}
