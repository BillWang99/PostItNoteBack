using PostItNoteBack.Models;

namespace PostItNoteBack.Interface
{
    public interface IPostItService
    {
        List<PostIt> AllPost();

        List<PostIt> AllDeletePost();

        PostIt GetPost(int Id);

        void AddPost(string Message);

        void RemovePost(int Id);

        void RollBackPost(int Id);

        void DeletePost(int Id);
    }
}
