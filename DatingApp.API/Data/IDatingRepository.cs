using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        // Dit is een generieke methode. De <T> kan op photo's en users betrekking hebben.
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         // Controleert of er null of meer wijzigen hebben plaats gevonden.
         Task<bool> SaveAll();

         // Lijst van users
         Task<IEnumerable<User>> GetUsers();

         // Een enkele user
         Task<User> GetUser(int id);
    }
}