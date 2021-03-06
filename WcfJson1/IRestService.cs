﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfJson1
{

    [ServiceContract(Namespace ="IRestService/JSONData")]
    public interface IRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json,
                   BodyStyle =WebMessageBodyStyle.Wrapped,
                   UriTemplate = "json/{id}")]
        Auto json(string id);
    }
}
