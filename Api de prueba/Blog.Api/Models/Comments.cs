using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Api.Models
{
    public class Comments : IEntity
    {
        private DateTime date;
        private string comment;
        private User user;
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get => date; set => date = value; }

        [MaxLength(200)]
        public string Comment { get => comment; set => comment = value; }

        public int UserId { get => user.Id; set => user.Id = value; }
    }
}
