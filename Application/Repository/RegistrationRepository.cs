using Application.ApplicationDBContext;
using Application.Helper;
using Application.Interface;
using Application.Models;
using System;
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

        public bool Registration(Registration register)
        {
            if(string.IsNullOrEmpty(register.Password))
            {
                register.Password = Encryption.PasswordEncryption(_password_generator.GeneratePassword());
            }
            else
            {
                register.Password = Encryption.PasswordEncryption(register.Password);
            }
            _dbContext.Registration.Add(register);
            _dbContext.SaveChanges();
            return true;
        }
        public IEnumerable<Registration> GetAllRegistration()
        {
            var _registration_list = _dbContext.Registration.ToList();
            return GetAllRegistartion(_registration_list);
        }
        private IEnumerable<Registration> GetAllRegistartion(IEnumerable<Registration> _registration_list)
        {
            foreach(Registration registration in _registration_list)
            {
                registration.Password= Encryption.PasswordDecryption(registration.Password);
            }
            return _registration_list;
        }
        public IEnumerable<Registration> GetSingleRegistration(Guid id)
        {
            var _single_registartion= _dbContext.Registration.Where(registartion=> registartion.RecordID == id);
            return GetAllRegistartion(_single_registartion);
        }
     
    }
}
