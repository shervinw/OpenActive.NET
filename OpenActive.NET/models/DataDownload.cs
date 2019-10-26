
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenActive.NET
{
    /// <summary>
    /// 
    /// ## **EARLY RELEASE NOTICE**
    /// In order to expedite the OpenActive tooling work, this class has been added to the model for the purposes of testing.
    /// IT IS SUBJECT TO CHANGE, as the [Dataset API Discovery specification](https://www.openactive.io/dataset-api-discovery/EditorsDraft/) evolves.
    /// 
    /// This type is derived from [DataDownload](https://schema.org/DataDownload), which means that any of this type's properties within schema.org may also be used. Note however the properties on this page must be used in preference if a relevant property is available.
    /// </summary>
    [DataContract]
    public partial class DataDownload : Schema.NET.DataDownload
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataDownload";

        
        /// <summary>
        /// The name of the type of feed
        /// </summary>
        /// <example>
        /// <code>
        /// "name": "SessionSeries"
        /// </code>
        /// </example>
        [DataMember(Name = "name", EmitDefaultValue = false, Order = 7)]
        public new virtual string Name { get; set; }


        /// <summary>
        /// A fully qualified reference to the class that is at the root of the items in the RPDE feed.
        /// </summary>
        /// <example>
        /// <code>
        /// "additionalType": "https://openactive.io/SessionSeries"
        /// </code>
        /// </example>
        [DataMember(Name = "additionalType", EmitDefaultValue = false, Order = 8)]
        public new virtual Uri AdditionalType { get; set; }


        /// <summary>
        /// The URL of the RPDE data feed.
        /// </summary>
        /// <example>
        /// <code>
        /// "contentUrl": "https://opendata.leisurecloud.live/api/feeds/fusion-lifestyle-fl-live-session-series"
        /// </code>
        /// </example>
        [DataMember(Name = "contentUrl", EmitDefaultValue = false, Order = 9)]
        public new virtual Uri ContentUrl { get; set; }


        /// Must always be present and set to <code>
        /// "encodingFormat": "application/vnd.openactive.rpde+json; version=1"
        /// </code>
        [DataMember(Name = "encodingFormat", EmitDefaultValue = false, Order = 10)]
        public new virtual string EncodingFormat { get; set; }

    }
}
