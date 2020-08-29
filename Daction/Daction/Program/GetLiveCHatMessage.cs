using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daction.StartYoutube
{
    class GetLiveCHatMessage
    {
        static public async Task GetLiveChatMessage(string liveChatId, YouTubeService youtubeService, string nextPageToken)
        {
            var liveChatRequest = youtubeService.LiveChatMessages.List(liveChatId, "snippet,authorDetails");
            liveChatRequest.PageToken = nextPageToken;

            var liveChatResponse = await liveChatRequest.ExecuteAsync();
            foreach (var liveChat in liveChatResponse.Items)
            {
                try
                {
                    Console.WriteLine($"{liveChat.Snippet.DisplayMessage},{liveChat.AuthorDetails.DisplayName}");
                }
                catch { }

            }
            await Task.Delay((int)liveChatResponse.PollingIntervalMillis);


            await GetLiveChatMessage(liveChatId, youtubeService, liveChatResponse.NextPageToken);
        }
    }
}
