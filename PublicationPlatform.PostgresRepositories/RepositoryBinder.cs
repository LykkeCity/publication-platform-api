using Common;
using PublicationPlatform.Domains.PublisherRoles;
using PublicationPlatform.PostgresRepositories.PublisherRoles;

namespace PublicationPlatform.PostgresRepositories
{
    public static class RepositoryBinder
    {
        public static void UsePublicationPlatformPostgresRepositories(this IDependencyRegistrator dr)
        {
            dr.AddSingleton<IPublisherRolesRepository, PublisherRolesRepository>(new PublisherRolesRepository());
        }
    }
}