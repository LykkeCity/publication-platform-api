using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicationPlatform.Domains.PublisherRoles
{

    public interface IPublisherRole
    {
        string Id { get; }
        string Name { get; }
    }
    
    public interface IPublisherRolesRepository
    {
        Task<IEnumerable<IPublisherRole>> GetAsync();
    }
    
}