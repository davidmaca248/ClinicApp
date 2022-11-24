using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Globals
{
    public static class GlobalHomePageListDatabase
    {
        public static List<NoteListItem> TodoList { get; set; }
        public static List<NoteListItem> NotesList { get; set; }

        static GlobalHomePageListDatabase()
        {
            NotesList = new List<NoteListItem>()
            {
                new NoteListItem("Arhum's test results came in last night", new DateTime(2022,11,23,9,15,0)),
                new NoteListItem("Alden Hoffman canceled appointment", new DateTime(2022,11,23,9,15,0)),
                new NoteListItem("Dan called in sick", new DateTime(2022,11,24,9,15,0)),
            };

            TodoList = new List<NoteListItem>()
            {
                new NoteListItem("Call David Maca to confirm appointment", new DateTime(2022,11,23,9,15,0)),
                new NoteListItem("Let Dr. Frank know about Arhum's test results", new DateTime(2022,11,23,9,15,0)),
                new NoteListItem("Let Dr. Josh know about Alden Hoffman's cancellation", new DateTime(2022,11,24,9,15,0)),
                new NoteListItem("Let manager know that Dan cannot make it to work today", new DateTime(2022,11,22,9,15,0)),
            };
        }
    }
}
