using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment p)
        {
            _commentDal.Insert(p);
        }

        public void CommentDelete(Comment p)
        {
            throw new NotImplementedException();
        }

        public void CommentUpdate(Comment p)
        {
            throw new NotImplementedException();
        }

        public Comment GetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
           return _commentDal.GetListAll(x => x.BlogID == id);
        }
    }
}
