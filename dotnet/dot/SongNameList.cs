using System;  
using System.Collections.Generic;  
using System.Linq;  

namespace dot
{
    class Song {  
        public int Id { get; set; }  
        public string SongName { get; set; }  
        public int Sequence { get; set; }  
    }

    class Program {  
        static void Main() {  
            Song sOne = new Song() {  
                Id = 101,  
                SongName = "Ik Onkaar",  
                Sequence = 1
            };  
  
            Song sTwo = new Song() {  
                Id = 102,  
                SongName = "Rewrite the Stars",  
                Sequence = 2
            };  
  
            Song sThree = new Song() {  
                Id = 103,  
                SongName = "Titanium",  
                Sequence = 3
            };  
  
            Song sFour = new Song() {  
                Id = 104,  
                SongName = "Lost",  
                Sequence = 4
            };  
  
            Song sFive = new Song() {  
                Id = 105,  
                SongName = "High Hopes",  
                Sequence = 5
            }; 

            // Song[] songs = new Song[] 
            // { 
            //     new Song { Id = 106, SongName = "Tomato Soup", Sequence = 6 }, 
            //     new Song { Id = 107, SongName = "Yo-yo", Sequence = 7 }, 
            //     new Song { Id = 108, SongName = "Hammer", Sequence = 8 } 
            // };
  
            List<Song> SongList = new List<Song>();  
            SongList.Add(sOne);  
            SongList.Add(sTwo);  
            SongList.Add(sThree);  
            SongList.Add(sFour);  
            SongList.Add(sFive); 
            // SongList.Add(songs);  
  
            // foreach(Song s in SongList) {  
                Console.WriteLine("Song Id is {0}, SongName is {1}, Sequence is {2}", SongList);
                // } 
        }  
    }  
}