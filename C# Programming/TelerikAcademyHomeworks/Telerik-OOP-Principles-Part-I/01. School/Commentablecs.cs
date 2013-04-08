using System;
using System.Collections.Generic;
// Abstract class that adds comments
public abstract class Commentable
{
    private List<string> comments = new List<string>();
    public void AddComment(string comment)
    {
        // Encapsulation
        if (comment.Length < 10 || comment.Length > 200)
        {
            throw new ArgumentOutOfRangeException("Your comment should be in the range [10, 200] symbols");
        }
        this.comments.Add(comment);
    }

}