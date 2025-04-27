using BootCampProject.Entities;
using BootCampProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampProject.Business
{
    public class UserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int id)
        {
            return _userRepository.Get(u => u.Id == id);
        }

        public IList<User> GetAllUsers()
        {
            return _userRepository.GetList();
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            _userRepository.Delete(user);
        }
    }
}
