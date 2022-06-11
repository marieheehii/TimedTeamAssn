using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class CommentService : iComment
{
    private readonly SocialMedia_DbContext _context;
    public CommentService(SocialMedia_DbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateCommentAsync(CommentDetail model)
    {
        var comment = new CommentDetail
        {
            Text = model.Text,
            PostID = model.PostID
        };

        _context.Comments.Add(CommentDetail);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<IEnumerable<CommentDetail>> GetCommentsByPostID()
    {
        var comments = _context.Comments
        // .Where(comments => comments.ID == PostID)
        .Select(comments => new Comment
        {
            Text = comments.Text,
        })
        .ToListAsync();

        return comments;
    }
}
