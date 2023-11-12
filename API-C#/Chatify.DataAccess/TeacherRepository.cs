using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class TeacherRepository : BaseRepository<Teacher, ChatifyContext>, ITeacherRepository
    {
        public TeacherRepository(ChatifyContext context) : base(context)
        {
        }

        public override IQueryable<Teacher> GetEntities()
        {
            return base.GetEntities().Where(x => x.Email != "admin@admin.com");
        }
    }
}
