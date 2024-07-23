using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBible
{
    public class BibleBooks
    {
        string Book, verse;
        int chapter;
        string verseNumber;

        public BibleBooks(string book, int chapter, string verseNumber, string verse)
        {
            this.Book = book;
            this.verse = verse;
            this.chapter = chapter;
            this.verseNumber = verseNumber;
        }

        public object this[int index] // creating an index
        {
            get // getting and setting the postions of the variables 
            {
                if (index == 0)
                    return this.Book;
                else if (index == 1)
                    return this.verse;
                else if (index == 2)
                    return this.chapter;
                else if (index == 3)
                    return this.verseNumber;
                return null;

            }
            set
            {
                if (index == 0)
                    this.Book = (string)value;
                else if (index == 1)
                    this.verse = (string)value;
                else if (index == 2)
                    this.chapter = (int)value;
                else if (index == 3)
                    this.verseNumber = (string)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("book"))
                    return this.Book;
                else if (attrName.ToLower().Equals("verse"))
                    return this.verse;
                else if (attrName.ToLower().Equals("chapter"))
                    return this.chapter;
                else if (attrName.ToLower().Equals("versenumber"))
                    return this.verseNumber;
                return null;

            }
            set
            {
                if (attrName.ToLower().Equals("book"))
                    this.Book = (string)value;
                else if (attrName.ToLower().Equals("verse"))
                    this.verse = (string)value;
                else if (attrName.ToLower().Equals("chapter"))
                    this.chapter = (int)value;
                else if (attrName.ToLower().Equals("versenumber"))
                    this.verseNumber = (string)value;
                

            }
        }
    }
}
