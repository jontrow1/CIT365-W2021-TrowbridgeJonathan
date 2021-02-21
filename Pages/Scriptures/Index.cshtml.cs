using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Scriptures { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureSearch { get; set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from s in _context.Scripture
                                            orderby s.Book
                                            select s.Book;
            
            var scriptures = from s in _context.Scripture
                             select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.JournalEntry.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureSearch))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureSearch);
            }

            /*IQueryable<Scripture> bookOrder = from b in _context.Scripture
                                           select b;*/

            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.EnterDate);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.EnterDate);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }

            Scriptures = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriptures.AsNoTracking().ToListAsync();
        }
    }
}
