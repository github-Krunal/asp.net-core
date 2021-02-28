using Application.Models;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IRegistration
    {
         bool RegisterUser(Registration register);
       IEnumerable<Registration> GetRegisteredsUser();
    }
}
