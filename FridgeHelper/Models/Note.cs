using System;
using System.Collections.Generic;

namespace DrumGenerator.Models
{
    public class Note
    {
        public string Empty { get; set; } = "----";
        public string HiHat { get; set; } = "--42";
        public string Kick { get; set; } = "--36";
        public string Snare { get; set; } = "--38";
        ////private readonly string eLine = "   E   E   E   E   E   E   E   E";

        ////public string ELine()
        ////{
        ////    return eLine;
        ////}

        public string RandomLine()
        {
            Random random = new Random();

            List<string> listOfNotes = new List<string>()
            {
                Empty,
                HiHat,
                Kick,
                Snare
            };

            string stringOfNotes = "";

            for (int i = 0; i < 8; i++)
            {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                stringOfNotes += listOfNotes[random.Next(0, listOfNotes.Count)].ToString();
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
            }

            return stringOfNotes;
        }

        public string ClearLine()
        {
            return Empty + Empty + Empty + Empty + Empty + Empty + Empty + Empty;
        }

        public string SnareLine()
        {
            Random random = new Random();

            List<string> listOfNotes = new List<string>()
            {
                Empty,
                Snare
            };

            string stringOfNotes = "";

            for (int i = 0; i < 8; i++)
            {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                stringOfNotes += listOfNotes[random.Next(0, listOfNotes.Count)].ToString();
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
            }

            return stringOfNotes;
        }

        public string KickLine()
        {
            Random random = new Random();

            List<string> listOfNotes = new List<string>()
            {
                Empty,
                Kick
            };

            string stringOfNotes = "";

            for (int i = 0; i < 8; i++)
            {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                stringOfNotes += listOfNotes[random.Next(0, listOfNotes.Count)].ToString();
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
            }

            return stringOfNotes;
        }

        public string HiHatLine()
        {
            Random random = new Random();

            List<string> listOfNotes = new List<string>()
            {
                Empty,
                HiHat
            };

            string stringOfNotes = "";

            for (int i = 0; i < 8; i++)
            {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                stringOfNotes += listOfNotes[random.Next(0, listOfNotes.Count)].ToString();
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
            }

            return stringOfNotes;
        }
    }
}
