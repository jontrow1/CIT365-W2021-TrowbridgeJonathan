using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptureJournal.Data;
using System;
using System.Linq;

namespace ScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for any scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "John",
                        EnterDate = DateTime.Parse("2016-12-5"),
                        Chapter = 3,
                        Verse = 16,
                        JournalEntry = "This is part of my conversion story"
                    },

                    new Scripture
                    {
                        Book = "Doctrine and Covenants",
                        EnterDate = DateTime.Parse("2021-1-10"),
                        Chapter = 10,
                        Verse = 4,
                        JournalEntry = "Come Follow Me for 2021"
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        EnterDate = DateTime.Parse("2020-6-5"),
                        Chapter = 38,
                        Verse = 5,
                        JournalEntry = "These are my notes"
                    },

                    new Scripture
                    {
                        Book = "Genesis",
                        EnterDate = DateTime.Parse("2003-8-11"),
                        Chapter = 1,
                        Verse = 1,
                        JournalEntry = "I have read this one mre times than I can remember"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
