using System.Collections.Generic;
namespace TodoApi.Models
{
    public class MediaPlayerItem
    {
        public long Id { get; set; }
        public string SongName { get; set; }
        public int Sequence { get; set; }

        // List<string> mySongsList = new List<string>();
        // mySongsList.Add("abc", "def"); 
    }

    public class SongSequenceRequest
    {
        public IList<MediaPlayerItem> SongList { get; set; }
        
    }

    // class MediaPlayerItems
    // {
    //     MediaPlayerItem sOne= new MediaPlayerItem {
    //         Id = 101,  
    //         SongName = "Ik Onkaar",  
    //         Sequence = 1   
    //     };

    //     MediaPlayerItem sTwo= new MediaPlayerItem {
    //         Id = 102,  
    //             SongName = "Rewrite the Stars",  
    //             Sequence = 2   
    //     };

    //     // public List<MediaPlayerItem> SongList = new List<MediaPlayerItem>();
    //     // SongList.Add(sOne):
    // }
}
