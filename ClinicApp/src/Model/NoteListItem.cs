using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class NoteListItem
    {
        public string Info { get; set; }
        public DateTime Date { get; set; }

        public NoteListItem(string info, DateTime date)
        {
            Info = info;
            Date = date;
        }
    }
}
