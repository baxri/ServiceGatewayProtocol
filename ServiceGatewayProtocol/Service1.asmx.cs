﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceGatewayProtocol
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public param[] check(string merchantId, string branch, string alias, param[] data, string hash)
        {
            param[] result = null;
            return result;
        }

        [WebMethod]
        public param[] pay(string merchantId, string branch, string alias, string paymentId, param[] data, string hash)
        {
            param[] result = null;
            return result;
        }
    }
}