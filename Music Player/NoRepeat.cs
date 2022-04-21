using System;
using System.Collections.Generic;

namespace Music_Player
{
    class NoRepeat
    {
        public static List<string> newSongs = new List<string>();
        public static bool activeList = false;

        public static string returnNewSongPath()
        {
            if (newSongs.Count == 0)
            {
                // No new songs left
                return "empty";
            } else
            {
                // There are still new songs left
                Random random = new Random();
                int randomIndex = random.Next(0, newSongs.Count);
                string randomPath = newSongs[randomIndex];
                newSongs.RemoveAt(randomIndex);
                return randomPath;
            }
        }

        public static void emptySongCache()
        {
            newSongs = new List<string>();
            activeList = false;
        }
    }
}
