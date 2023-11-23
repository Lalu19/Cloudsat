using AdminClient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Model.Story
{
    public interface IStory
    {
        public string StoryCreate(StoryNewDTO storyNewDTO);
    }
}
