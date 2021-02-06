using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Micro Service
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService _userValidationService)
        {
            _userValidationService = _userValidationService;
        }

        public void  Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız!!");
            }
            Console.WriteLine("Kayıt oldu");
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
