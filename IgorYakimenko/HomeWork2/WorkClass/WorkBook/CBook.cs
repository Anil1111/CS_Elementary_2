using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBook
{       
    class CBook
    {
        CContent content = null;
        CTitle title = null;
        CAuthor author = null;

        public CBook(CContent content, CTitle title, CAuthor author)
        {
            inicialization(content, title, author);
        }

        public void inicialization(CContent content, CTitle title, CAuthor author)
        {
            this.content = content;
            this.title = title;
            this.author = author;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();            
        }
        
    }
}
