﻿using System.Runtime.Serialization;

namespace Matrix.Sdk.Api.Responses.Session
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }
        [DataMember(Name = "device_id")]
        public string DeviceID { get; set; }
        // Deprecated
        /*[DataMember(Name = "home_server")]
        public string HomeServer { get; set; }*/
        [DataMember(Name = "user_id")]
        public string UserID { get; set; }
    }
}
