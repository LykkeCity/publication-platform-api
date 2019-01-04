using PublicationPlatform.Domains.PublisherRoles;

namespace PublicationPlatform.api.Models
{
    public class PublisherRoleContract
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static PublisherRoleContract Create(IPublisherRole publisherRole)
        {
            return new PublisherRoleContract
            {
                Id = publisherRole.Id,
                Name = publisherRole.Name
            };
        }

    }
}