using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Api.Models
{
    public class Comments : IEntity
    {
        private DateTime date;
        private string comment;
        private int userId;

        public Comments(DateTime date, string comment, int userId)
        {
            this.date = date;
            this.comment = comment;
            this.userId = userId;
        }
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get => date; set => date = value; }

        [MaxLength(200)]
        public string Comment { get => comment; set => comment = value; }

        public int UserId { get => userId; set => userId = value; }
    }
}
