using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        public string Book { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EnterDate { get; set; }

        [Display(Name = "Notes/Comments")]
        public string JournalEntry { get; set; }
    }
}
