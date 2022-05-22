using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment p);
        void CommentUpdate(Comment p);
        void CommentDelete(Comment p);
        List<Comment> GetList(int id);
        Comment GetbyID(int id);
    }

}
