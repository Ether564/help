using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        // Метод установки названия
        public void SetTitle(string title)
        {
            this.title = new Title(title);
        }

        // Метод установки автора
        public void SetAuthor(string author)
        {
            this.author = new Author(author);
        }

        // Метод установки содержания
        public void SetContent(string content)
        {
            this.content = new Content(content);
        }

        // Метод Show выводит всю информацию о книге
        public void Show()
        {
            if (title != null)
                title.Show();
            if (author != null)
                author.Show();
            if (content != null)
                content.Show();
        }
    }

}
