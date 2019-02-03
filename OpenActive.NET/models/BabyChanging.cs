
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenActive.NET
{
    /// <summary>
    /// 
    /// This type is derived from [LocationFeatureSpecification](https://schema.org/LocationFeatureSpecification), which means that any of this type's properties within schema.org may also be used. Note however the properties on this page must be used in preference if a relevant property is available.
    /// </summary>
    [DataContract]
    public class BabyChanging : LocationFeatureSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BabyChanging";

        
        /// <summary>
        /// A string, suitable for presentation in user interfaces.
        /// </summary>
        /// <example>
        /// <code>
        /// "name": "Baby Changing Facilities"
        /// </code>
        /// </example>
        [DataMember(Name = "name", Order = 115)]
        public new virtual string Name { get; set; }

    }
}
