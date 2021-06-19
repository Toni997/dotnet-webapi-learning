using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjektiTEST.Data.Models;
using ProjektiTEST.Data.ViewModels;

namespace ProjektiTEST.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name,
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }

    }
}
