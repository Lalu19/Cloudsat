using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Model.Story
{
    public class StoryProvider : IStory
    {
        IHttpWebClients _objIHttpWebClients;
        /// <summary>
        /// Constructor declaration
        /// </summary>
        /// <param name="objKeyList"></param>
        /// <param name="objIHttpWebClients"></param>
        public StoryProvider(IHttpWebClients objIHttpWebClients)
        {

            _objIHttpWebClients = objIHttpWebClients;
        }

        public string StoryCreate(StoryNewDTO storyNewDTO)
        {
            try
            {
               
                _objIHttpWebClients.PostRequest("api/Story/StoryCreate", JsonConvert.SerializeObject(storyNewDTO), true);
                return "Record Submitted Successfully.";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
