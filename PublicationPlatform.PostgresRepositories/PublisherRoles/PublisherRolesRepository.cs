using System.Collections.Generic;
using System.Threading.Tasks;
using PublicationPlatform.Domains.PublisherRoles;

namespace PublicationPlatform.PostgresRepositories.PublisherRoles
{

    public class PublisherRoleEntity : IPublisherRole
    {
        public string Id { get; set; }
        public string Name { get; set; }


        internal static readonly IEnumerable<IPublisherRole> Mock = new []
        {
            new PublisherRoleEntity
            {
                Id = "Id1",
                Name = "Publisher1"
            },
            new PublisherRoleEntity
            {
                Id = "Id2",
                Name = "Publisher2"
            }
        };
    }
    
    public class PublisherRolesRepository : IPublisherRolesRepository
    {
        public Task<IEnumerable<IPublisherRole>> GetAsync()
        {
            return Task.FromResult(PublisherRoleEntity.Mock);
        }
    }
}