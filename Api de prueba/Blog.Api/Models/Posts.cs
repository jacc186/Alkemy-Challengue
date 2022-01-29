using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Api.Models
{
    public class Posts : IEntity
    {
        private string title;
        private DateTime date;
        private string content;
        private int userId;

        public Posts(string title, DateTime date, string content, int userId)
        {
            this.title = title;
            this.date = date;
            this.content = content;
            this.userId = userId;
        }
        public int Id { get; set; }
        [MaxLength(80)]
        public string Title { get => title; set => title = value; }
        [DataType(DataType.Date)]
        public DateTime Date { get => date; set => date = value; }
        [MaxLength(150)]
        public string Content { get => content; set => content = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
