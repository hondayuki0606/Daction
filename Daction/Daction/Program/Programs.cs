using System;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

class Programs
{
    public static async Task Main()
    {
        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        {
            ApiKey = "AIzaSyBdcR5MNIAMS04fe3MkP2JZY7BwM6I901c"
        });

        string liveChatId = GetliveChatID("kLPHFsfYgk4", youtubeService);

        await GetLiveChatMessage(liveChatId, youtubeService, null);

    }

    static public string GetliveChatID(string videoId, YouTubeService youtubeService)
    {
        //引数で取得したい情報を指定
        var videosList = youtubeService.Videos.List("LiveStreamingDetails");
        videosList.Id = videoId;
        //動画情報の取得
        var videoListResponse = videosList.Execute();
        //LiveChatIDを返す
        foreach (var videoID in videoListResponse.Items)
        {
            return videoID.LiveStreamingDetails.ActiveLiveChatId;
        }
        //動画情報取得できない場合はnullを返す
        return null;
    }

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