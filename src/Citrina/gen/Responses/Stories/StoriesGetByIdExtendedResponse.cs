using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class StoriesGetByIdExtendedResponse
    {
        /// <summary>
        /// Stories count.
        /// </summary>
        public int? Count { get; set; } 

        public IEnumerable<StoriesStory> Items { get; set; } 

        public IEnumerable<UsersUserFull> Profiles { get; set; } 

        public IEnumerable<GroupsGroupFull> Groups { get; set; } 
    }
}
