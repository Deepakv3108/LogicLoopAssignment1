using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace LogicLoopAssignment2.Utility
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationString = actionContext.Request.Headers.Authorization.Parameter;
                string originalString = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));

                string usrename = originalString.Split(':')[0];
                string password = originalString.Split(':')[1];

                if (!VaidateUser(usrename, password))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Unauthorized User");
                }
            }

            base.OnAuthorization(actionContext);
        }
        public bool VaidateUser(string username, string password)
        {
            if (username.ToLower() == "marshal" && password.ToLower() == "unmarshal")  
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}