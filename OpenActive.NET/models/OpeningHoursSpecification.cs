
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenActive.NET
{
    /// <summary>
    /// 
    /// This type is derived from [OpeningHoursSpecification](https://schema.org/OpeningHoursSpecification), which means that any of this type's properties within schema.org may also be used. Note however the properties on this page must be used in preference if a relevant property is available.
    /// </summary>
    [DataContract]
    public partial class OpeningHoursSpecification : Schema.NET.OpeningHoursSpecification
    {
        /// <summary>
        /// Returns the JSON-LD representation of this instance.
        /// This method overrides Schema.NET ToString() to serialise using OpenActiveSerializer.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the JSON-LD representation of this instance.</returns>
        public override string ToString()
        {
            return OpenActiveSerializer.Serialize(this);
        }

        /// <summary>
        /// Returns the JSON-LD representation of this instance, including "https://schema.org" in the "@context".
        ///
        /// This method must be used when you want to embed the output raw (as-is) into a web
        /// page. It uses serializer settings with HTML escaping to avoid Cross-Site Scripting (XSS)
        /// vulnerabilities if the object was constructed from an untrusted source.
        /// 
        /// This method overrides Schema.NET ToHtmlEscapedString() to serialise using OpenActiveSerializer.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the JSON-LD representation of this instance.
        /// </returns>
        public new string ToHtmlEscapedString()
        {
            return OpenActiveSerializer.SerializeToHtmlEmbeddableString(this);
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        
        /// <summary>
        /// The closing time.
        /// </summary>
        /// <example>
        /// <code>
        /// "closes": "17:00"
        /// </code>
        /// </example>
        [DataMember(Name = "closes", EmitDefaultValue = false, Order = 7)]
        [JsonConverter(typeof(OpenActiveDateTimeOffsetToISO8601TimeValuesConverter))]
        public new virtual DateTimeOffset? Closes { get; set; }


        /// <summary>
        /// Defines the day of the week upon which the Place is open
        /// </summary>
        /// <example>
        /// <code>
        /// "dayOfWeek": "https://schema.org/Monday"
        /// </code>
        /// </example>
        [DataMember(Name = "dayOfWeek", EmitDefaultValue = false, Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public new virtual Schema.NET.DayOfWeek? DayOfWeek { get; set; }


        /// <summary>
        /// The opening time.
        /// </summary>
        /// <example>
        /// <code>
        /// "opens": "09:00"
        /// </code>
        /// </example>
        [DataMember(Name = "opens", EmitDefaultValue = false, Order = 9)]
        [JsonConverter(typeof(OpenActiveDateTimeOffsetToISO8601TimeValuesConverter))]
        public new virtual DateTimeOffset? Opens { get; set; }

    }
}
