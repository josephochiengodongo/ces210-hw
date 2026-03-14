using System;
using System.Collections.Generic;

 public class VideoLibrary
{
    private List<Video> _videos;
    public VideoLibrary()
    {
        _videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public List<Video> GetVideos()
    {
        return _videos;
    }
    

}