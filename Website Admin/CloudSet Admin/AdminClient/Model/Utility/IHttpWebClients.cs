namespace AdminClient.Model.Utility
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IHttpWebClients
    {
        // string PostRequest(string URI, string parameterValues);
        string PostRequest(string URI, string parameterValues, bool isAnonymous = false);
        //string GetRequest( string URI, object parameterValues);
       
    }
}
