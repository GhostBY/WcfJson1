using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfJson1
{
    [DataContract]
    public class Auto
    {
        [DataMember (Name ="Id")]
        public string Id { get ; set;}
        [DataMember(Name = "Company")]
        public string Company { get; set;}
        [DataMember(Name = "Model")]
        public string Model { get; set; }
        [DataMember(Name = "Price")]
        public string Price { get; set;}

    }
}