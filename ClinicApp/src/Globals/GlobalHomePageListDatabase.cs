using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicApp.Globals
{
    public static class GlobalHomePageListDatabase
    {
        public static List<NoteListItem> TodoList { get; set; }
        public static List<NoteListItem> NotesList { get; set; }

        static GlobalHomePageListDatabase()
        {
            DateTime d = DateTime.Now;
            int day1 = d.AddDays(-1).Day;
            int day2 = d.Day;
            int day3 = d.AddDays(1).Day;
            int day4 = d.AddDays(2).Day;

            NotesList = new List<NoteListItem>()
            {
                new NoteListItem(1,"Chris Ben's test results came in last night", new DateTime(2022,12,day2,9,15,0)),
                new NoteListItem(2,"Alden Hoffman canceled appointment", new DateTime(2022,12,day2,9,15,0)),
                new NoteListItem(3,"Dan called in sick", new DateTime(2022,12,day3,9,15,0)),
            };

            TodoList = new List<NoteListItem>()
            {
                new NoteListItem(1,"Call David Maca to confirm appointment", new DateTime(2022,12,day2,9,15,0)),
                new NoteListItem(2,"Let Dr. Frank know about Chris's test results", new DateTime(2022,12,day2,9,15,0)),
                new NoteListItem(3, "Let Dr. Josh know about Alden Hoffman's cancellation", new DateTime(2022,12,day3,9,15,0)),
                new NoteListItem(4,"Let manager know that Dan cannot make it to work today", new DateTime(2022,11,day2,9,15,0)),

            };
        }
    }
}
