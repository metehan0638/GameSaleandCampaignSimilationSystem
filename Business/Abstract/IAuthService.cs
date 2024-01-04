using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstract
{
      public interface IAuthService
    {
        void Register(Person person); // kayıt oluşturma
        void Unregister(Person person); // kayıt silme
        void UpdateUserInfo(Person person);  // kullanıcı bilgisi güncelleme
    }
}
