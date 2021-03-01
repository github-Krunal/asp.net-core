using Application.ApplicationDBContext;
using Application.Helper;
using Application.Interface;
using Application.Models;
using System.Collections.Generic;
using System.Linq;
namespace Application.Repository
{
    public class RegistrationRepository : IRegistration
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly PasswordGenerator _password_generator = new PasswordGenerator();
        public RegistrationRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public bool RegisterUser(Registration register)
        {
            register.Password = Encryption.PasswordEncryption(_password_generator.GeneratePassword());
            _dbContext.Registration.Add(register);
            _dbContext.SaveChanges();
            return true;
        }
        public IEnumerable<Registration> GetRegisteredsUser()
        {
            return GetAllRegistartion();
        }
        private IEnumerable<Registration> GetAllRegistartion()
        {
             var a =_dbContext.Registration.ToList();
            foreach(Registration element in  a)
            {
              element.Password= Encryption.PasswordDecryption(element.Password);
            }

            //for(var i = 0; i <= a.Count; i++)
            //{
            //    a[i].Password = Encryption.decryption(a[i].Password);
            //}

            return a;
        }
    }
}
