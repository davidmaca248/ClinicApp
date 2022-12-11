using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class NoteListItem
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }

        public bool IsDone { get; set; }

        public NoteListItem(int id, string info, DateTime date)
        {
            Id = id;
            Info = info;
            Date = date;
            IsDone = false;
        }
    }
}
