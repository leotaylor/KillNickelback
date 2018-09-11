using System;
using System.Collections.Generic;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            HashSet<Song> allSongs = new HashSet<Song>();

            allSongs.Add(new Song("Megadeth", "Hanger 18"));
            allSongs.Add(new Song("Nickelback", "Photograph"));
            allSongs.Add(new Song("Pink Floyd", "The Great Gig In The Sky"));
            allSongs.Add(new Song("Nickelback", "Rockstar"));
            allSongs.Add(new Song("Opeth", "Deliverance"));
            allSongs.Add(new Song("Nickelback", "How You Remind Me"));
            allSongs.Add(new Song("Judas Priest", "Painkiller"));

            foreach(var song in allSongs)
            {
                if(song.Artist != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach(var song in goodSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist} is a good song.");
            }

            Console.ReadLine();
        }
    }
}
