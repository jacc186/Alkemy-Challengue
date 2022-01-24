using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DTOs
{
    public class CommentsDTO
    {
        private int commentId;
        private DateTime date;
        private string comment;
        private int userId;

        public CommentsDTO(DateTime date, string comment, int userId)
        {
            this.date = date;
            this.comment = comment;
            this.userId = userId;
        }

        public int CommentId { get => commentId; set => commentId = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Comment { get => comment; set => comment = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
