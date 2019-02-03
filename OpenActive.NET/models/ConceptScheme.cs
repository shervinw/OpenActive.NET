
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenActive.NET
{
    /// <summary>
    /// 
    /// This type is derived from [ConceptScheme](http://www.w3.org/2004/02/skos/core#ConceptScheme).
    /// </summary>
    [DataContract]
    public class ConceptScheme 
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public virtual string Type => "ConceptScheme";

        
        /// <summary>
        /// A collection of concepts that are part of this scheme
        /// </summary>
        /// <example>
        /// <code>
        /// "concept": [
        ///   {
        ///     "id": "https://example.com/concept/martial-arts",
        ///     "type": "Concept",
        ///     "prefLabel": "Martial Arts",
        ///     "inScheme": "https://example.com/scheme/123",
        ///     "narrower": "https://example.com/concept/martial-arts/karate"
        ///   }
        /// ]
        /// </code>
        /// </example>
        [DataMember(Name = "concept", Order = 115)]
        public virtual List<Concept> Concept { get; set; }


        /// <summary>
        /// A free text description of the taxonomy
        /// </summary>
        /// <example>
        /// <code>
        /// "description": "An example activity list."
        /// </code>
        /// </example>
        [DataMember(Name = "description", Order = 115)]
        public virtual string Description { get; set; }


        /// <summary>
        /// Reference to the license under which the activity list has been published.
        /// </summary>
        /// <example>
        /// <code>
        /// "license": "https://example.com/license/MIT"
        /// </code>
        /// </example>
        [DataMember(Name = "license", Order = 115)]
        public virtual Uri License { get; set; }


        /// <summary>
        /// The title of the scheme
        /// </summary>
        /// <example>
        /// <code>
        /// "title": "Activity List"
        /// </code>
        /// </example>
        [DataMember(Name = "title", Order = 115)]
        public virtual string Title { get; set; }


        /// <summary>
        /// A URL to a web page (or section of a page) that describes the concept scheme.
        /// </summary>
        /// <example>
        /// <code>
        /// "url": "https://example.com/scheme/1234"
        /// </code>
        /// </example>
        [DataMember(Name = "url", Order = 115)]
        public virtual Uri Url { get; set; }

    }
}
