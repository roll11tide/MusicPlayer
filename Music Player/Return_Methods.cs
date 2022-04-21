using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Music_Player
{
    class Return_Methods
    {
        public static string returnTypeOfFile(string path)
        {
            string extension = Path.GetExtension(path);
            return extension;
        }

        public static MemoryStream GenerateStreamFromString(string value)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(value ?? ""));
        }

        public static int getLengthOfSong(string path)
        {
            TagLib.File file = TagLib.File.Create(path);
            int s_time = (int)file.Properties.Duration.TotalSeconds;
            return s_time * 1000;
        }

        public static double Convert100NanosecondsToMilliseconds(double nanoseconds)
        {
            // One million nanoseconds in 1 millisecond, but we are passing in 100ns units...
            return nanoseconds * 0.0001;
        }
    }
}
