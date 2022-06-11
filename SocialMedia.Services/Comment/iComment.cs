using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface iComment
    {
        Task<bool> CreateCommentAsync(CommentDetail model);
        Task<IEnumerable<CommentDetail>> GetCommentsByPostID ();
    }
