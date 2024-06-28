using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain
{
    public class Comment
    {
        public Comment(string content , string userName)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            UserName = userName;
        }
        public string Content { get; }
        public DateTime CreatedAt { get; }
        public string UserName { get; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }



    }
}
