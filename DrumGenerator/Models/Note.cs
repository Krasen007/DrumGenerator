namespace DrumGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Note
    {
        public string EmptyNote { get; set; } = "----";
        public string HiHat { get; set; } = "--42";
        public string Kick { get; set; } = "--36";
        public string Snare { get; set; } = "--38";
        
        public string RandomLine()
        {
            List<string> listOfNotes = new List<string>()
            {
                EmptyNote,
                HiHat,
                Kick,
                Snare
            };
            return GenerateNotes(listOfNotes);
        }

        public string ClearLine()
        {
            return EmptyNote + EmptyNote + EmptyNote + EmptyNote + EmptyNote + EmptyNote + EmptyNote + EmptyNote;
        }

        public string SnareLine()
        {
            List<string> listOfNotes = new List<string>()
            {
                EmptyNote,
                Snare
            };
            return GenerateNotes(listOfNotes);
        }

        public string KickLine()
        {
            List<string> listOfNotes = new List<string>()
            {
                EmptyNote,
                Kick
            };
            return GenerateNotes(listOfNotes);
        }

        public string HiHatLine()
        {
            List<string> listOfNotes = new List<string>()
            {
                EmptyNote,
                HiHat
            };
            return GenerateNotes(listOfNotes);
        }

        private string GenerateNotes(List<string> listOfNotes)
        {
            Random random = new Random();

            string stringOfNotes = "";
            StringBuilder stringOfNotesBuilder = new StringBuilder(stringOfNotes);

            for (int i = 0; i < 8; i++)
            {
                stringOfNotesBuilder.Append(listOfNotes[random.Next(0, listOfNotes.Count)].ToString());
            }

            return stringOfNotesBuilder.ToString();
        }
    }
}
