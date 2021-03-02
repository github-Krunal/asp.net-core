using Application.Models;
using System;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IRegistration
    {
       bool Registration(Registration register);
       IEnumerable<Registration> GetAllRegistration();

        IEnumerable<Registration> GetSingleRegistration(Guid id);
    }
}
