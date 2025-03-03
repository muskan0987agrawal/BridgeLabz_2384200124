
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Service;

namespace RepositoryLayer.Context
{
   public class UserRegistrationContext: DbContext

    {
        public UserRegistrationContext(DbContextOptions<UserRegistrationContext> options) : base(options)
        {

        }

        public virtual DbSet<Entity.UserEntity> User{ get; set; }
    }
}
