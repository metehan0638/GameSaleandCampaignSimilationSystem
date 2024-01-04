using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    internal class AuthManager : IAuthService
    {
        ValidationManager _validationManager;

        public AuthManager(IUserValidationService userValidationService)
        {
            UserValidationService = userValidationService;
        }

       

        public IUserValidationService UserValidationService { get; }

        public void Register(Person person)
        {
            if (UserValidationService.CheckUser(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + "kullanıcısı sisteme kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Mernis'de böyle bir kullanıcı yoktur.");
            }
        }

        public void Unregister(Person person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + "kullanıcısı sistemden silindi.");
        }

        public void UpdateUserInfo(Person person)
        {
           Console.WriteLine(person.FirstName + " " + person.LastName + " " + "kullanıcı bilgileri güncellendi.");
        }
    }
}
