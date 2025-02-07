﻿using System.Runtime.Serialization;

namespace Matrix.Sdk.Api.Responses.Events
{
    [DataContract]
    public class Typing : MatrixEvents
    {
        [DataMember(Name = "content")]
        public TypingContent Content { get; set; }
    }

    [DataContract]
    public class TypingContent
    {
        [DataMember(Name = "user_ids")]
        public string[] UserIDs { get; set; }
    }
}
