using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercR2.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment() { }

        public Comment(string text)
        {
            Text = text;
        }
    }
}