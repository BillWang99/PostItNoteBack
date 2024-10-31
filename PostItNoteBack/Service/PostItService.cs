using Dapper;
using Microsoft.Data.SqlClient;
using PostItNoteBack.Interface;
using PostItNoteBack.Models;
namespace PostItNoteBack.Service
{
    public class PostItService : IPostItService
    {
        private readonly SqlConnection _conn;

        public PostItService(SqlConnection conn)
        {
            _conn = conn;
        }

        //取得所有便利貼
        public List<PostIt> AllPost()
        {
            string sql = @"SELECT * FROM PostIt WHERE IsDelete = 0";

            List<PostIt> result = _conn.Query<PostIt>(sql).ToList();

            return result;
        }


        //取得選擇的便利貼
        public PostIt GetPost(int Id)
        {
            string sql = @"SELECT * FROM PostIt WHERE IsDelete = 0 AND Id = @Id";

            PostIt result = _conn.Query<PostIt>(sql, new { Id }).FirstOrDefault();


            return result;
        }

        //新增便利貼
        public void AddPost(string Message)
        {
            string sql = @"INSERT INTO PostIt (Message, CreateTime, IsDelete) VALUES (@Message, GETDATE(), 0)";

            _conn.Execute(sql, new { Message });
        }

        //移除便利貼
        public void RemovePost(int Id)
        {
            string sql = @"UPDATE PostIt SET IsDelete = 1 WHERE Id = @Id";

            _conn.Execute(sql, new { Id });

        }

        //復原便利貼
        public void RollBackPost(int Id)
        {
            string sql = @"UPDATE PostIt SET IsDelete = 0 WHERE Id = @Id";

            _conn.Execute(sql, new { Id });

        }

        //刪除便利貼
        public void DeletePost(int Id)
        {
            string sql = @"DELETE FROM PostIt WHERE IsDelete = 1 and Id = @Id";

            _conn.Execute(sql, new { Id });
        }

        //查看所有移除的便利貼
        public List<PostIt> AllDeletePost()
        {
            string sql = @"SELECT * FROM PostIt WHERE IsDelete = 1";

            List<PostIt> result = _conn.Query<PostIt>(sql).ToList();

            return result;
        }
    }
}
