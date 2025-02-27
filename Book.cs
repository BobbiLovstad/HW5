using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// written by bobbi Lovstad
// 2/27/25
namespace Homework5
{
    public class Book
    {
        private string title = "n/a";
        private string author = "n/a";
        private int published = -1;

        // gets and sets

        public string Title
        {
            get { return this.title; }
            set { this.title = value }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value }
        }
        public int Published
        {
            get { return this.published; }
            set { this.published = value }
        }

        // Constructor 

        public Book(string atitle, string aauthor, int apublished)
        {
            this.title = atitle;
            this.author = aauthor;
            this.published = apublished;
        }

        // Methods 

        public override string ToString()
        {
            return "Title:" + title + "Author" + author + "Year published" + published
        }

        public class EBook : Book
        {
            private int fileSize = -1;

            // gets and sets 

            public int FileSize
            {
                get { return this.fileSize; }
                set { this.fileSize = value; }
            }

            // Constructor 

            public EBook(string atitle, string aauthor, int apublished, int afileSize) : base(atitle, aauthor, apublished)
            {
                this.fileSize = afileSize;
            }

            public override string ToString()
            {
                return "Title:" + title + "Author" + author + "Year published" + published + "FileSize:" + fileSize;
            }


        }

        public class PrintedBook : Book
        {
            private int pageCount = -1;

            // gets and sets 

            public int PageCount
            {
                get { return this.pageCount; }
                set { this.pageCount = value; }
            }

            // Constructor 

            public PaperBook(string atitle, string aauthor, int apublished, int apageCount) : base(atitle, aauthor, apublished)
            {
                this.pageCount = apageCount;
            }

            public override string ToString()
            {
                return "Title:" + title + "Author" + author + "Year published" + published + "Number of Pages:" + pageCount;
            }


        }
    }
