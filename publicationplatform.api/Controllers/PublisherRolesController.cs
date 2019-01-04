using System.Collections.Generic;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Mvc;
using PublicationPlatform.api.Models;
using PublicationPlatform.Domains.PublisherRoles;

namespace PublicationPlatform.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherRolesController : ControllerBase
    {
        private readonly IPublisherRolesRepository _publisherRolesRepository;

        public PublisherRolesController(IPublisherRolesRepository publisherRolesRepository)
        {
            _publisherRolesRepository = publisherRolesRepository;
        }
        
        [HttpGet]
        public async Task<IEnumerable<PublisherRoleContract>> Get()
        {
            return await _publisherRolesRepository
                .GetAsync()
                .SelectAsync(PublisherRoleContract.Create);
        }
       
    }
    
}