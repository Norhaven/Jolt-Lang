﻿using Jolt.Evaluation;
using Jolt.Library;
using Jolt.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jolt.Json.Newtonsoft
{
    public class JoltJsonTransformer : JoltTransformer<JoltContext>
    {
        public static JoltJsonTransformer DefaultWith(string jsonTransformer, IEnumerable<MethodRegistration>? methodRegistrations = null)
        {
            var thirdPartyMethods = methodRegistrations?.Select(x => Registrar.GetCustomMethodRegistration(x));
            var referenceResolver = new ReferenceResolver(thirdPartyMethods);

            var context = new JoltContext(
                jsonTransformer,
                new ExpressionParser(),
                new ExpressionEvaluator(),
                new TokenReader(),
                new JsonTokenReader(),
                new JsonPathQueryPathProvider(),
                referenceResolver);

            return new JoltJsonTransformer(context);
        }

        public JoltJsonTransformer(JoltContext context) 
            : base(context)
        {
        }
    }
}
