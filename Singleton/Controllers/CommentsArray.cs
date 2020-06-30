using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Singleton.Controllers
{

    class CommentsArray
    {

        private static CommentsArray commentSingleton = null;

        private List<string> _comments = new List<string>();

        private CommentsArray()
        {
        }

        public static CommentsArray getSingleton()
        {
            if (commentSingleton == null)
            {
                commentSingleton = new CommentsArray();
            }
            return commentSingleton;
        }

        public void AddComment(string comment)
        {
            _comments.Add(comment);
        }

        public IEnumerable<string> Comments => _comments;

    }
}

