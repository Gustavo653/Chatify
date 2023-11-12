using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class GraduationRepository : BaseRepository<Graduation, ChatifyContext>, IGraduationRepository
    {
        public GraduationRepository(ChatifyContext context) : base(context)
        {
        }
        public override IQueryable<Graduation> GetEntities()
        {
            return base.GetEntities().Where(x => x.Name != "Admin");
        }
    }
}
