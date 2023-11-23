namespace insiderwebsite.Models.Utility
{
    public interface IHttpWebClients
    {
        string PostRequest (string URI, string parameterValues,bool isAnonymous = false);
    }
}
