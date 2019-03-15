﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace OpenActive.NET
{
    public static class OpenActiveDiscovery
    {
        public static class MediaTypes
        {
            /// <summary>
            /// Realtime Paged Data Exchange (https://www.openactive.io/realtime-paged-data-exchange/)
            /// </summary>
            public const string RealtimePagedDataExchange = "application/vnd.openactive.rpde+json";

            /// <summary>
            /// Open Booking (https://www.openactive.io/open-booking-api)
            /// </summary>
            public const string OpenBooking = "application/vnd.openactive.booking+json";

            /// <summary>
            /// Create a versioned equivalent of a given media type
            /// </summary>
            public static MediaTypeHeaderValue VersionedMediaType(string mediatype, decimal version) => MediaTypeHeaderValue.Parse($"{mediatype}; version={version}");

            public static class Version1
            {
                /// <summary>
                /// Media type for latest version of Realtime Paged Data Exchange
                /// </summary>
                public static MediaTypeHeaderValue RealtimePagedDataExchange => VersionedMediaType(MediaTypes.RealtimePagedDataExchange, 1);

                /// <summary>
                /// Media type for latest version of Realtime Paged Data Exchange
                /// </summary>
                public static MediaTypeHeaderValue OpenBooking => VersionedMediaType(MediaTypes.OpenBooking, 1);
            }
        }
    }
}