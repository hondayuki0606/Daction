using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daction.StartYoutube
{
    class GetLiveChatID
    {
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
    }
}
