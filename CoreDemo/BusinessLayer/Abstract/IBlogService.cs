using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogUpdate(Blog blog);
        void BlogDelete(Blog blog);
        List<Blog> GetAll();    
        Blog GetById(int id);   
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogByWriter(int id);

    }
}
