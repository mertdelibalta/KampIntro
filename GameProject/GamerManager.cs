using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
    //MicroService
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;
        
        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
