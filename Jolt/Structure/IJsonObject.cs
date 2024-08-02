﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jolt.Structure
{
    /// <summary>
    /// Represents a JSON object. This can be enumerated to iterate through its properties, if any exist.
    /// </summary>
    public interface IJsonObject : IJsonToken, IEnumerable<IJsonProperty>
    {
        /// <summary>
        /// Gets or sets the JSON structure used as the value for this property.
        /// </summary>
        /// <param name="propertyName">The name of the property to use.</param>
        /// <returns>An instance of <see cref="IJsonToken"/> if present, null otherwise.</returns>
        IJsonToken? this[string propertyName] { get; set; }

        /// <summary>
        /// Removes a property by name from this JSON object.
        /// </summary>
        /// <param name="propertyName">The property name to remove.</param>
        /// <returns>An instance of <see cref="IJsonToken"/> which is the removed JSON structure if present, null otherwise.</returns>
        IJsonToken? Remove(string propertyName);
    }
}
