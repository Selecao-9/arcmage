﻿using System.Runtime.Serialization;

namespace Matrix.Sdk.Api.Responses.Events.Room
{
    [DataContract]
    public class Name : MatrixEvents
    {
        [DataMember(Name = "content")]
        public NameContent Content { get; set; }
    }

    [DataContract]
    public class NameContent
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
