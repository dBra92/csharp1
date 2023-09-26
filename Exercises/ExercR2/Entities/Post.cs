using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace ExercR2.Entities
{
    public class Post
    {
        public Post(DateTime moment, string content)
        {
            this.Moment = moment;
    this.Content = content;

        }
                public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(Parameters)
        {
            
        }

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }


        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RmvComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" - Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");

            foreach (Comment com in Comments)
            {
                sb.AppendLine(com.Text);
            }
            return sb.ToString();
        }
    }
}