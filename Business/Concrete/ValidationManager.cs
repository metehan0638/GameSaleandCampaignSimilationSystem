using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    internal class ValidationManager : IUserValidationService
    {
        public bool CheckUser(Person person)
        {
            if(person.IdentityNum == "12345" && 
               person.FirstName == "Metehan" &&
               person.LastName == "Mete" 
              )
            {
                return true;
            }
            return false;
        }
    }
}
