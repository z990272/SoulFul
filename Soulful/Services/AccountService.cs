using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.Services
{
    public class AccountService
    {
        public void CreateGiveBack(GiveBackViewModel giveBack)
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<GiveBacks> repository = new SoulfulRepository<GiveBacks>(context);
            GiveBacks data = new GiveBacks()
            {
                Name = giveBack.Name,
                Email = giveBack.Email,
                Subject = giveBack.Subject,
                Message = giveBack.Message
            };
            repository.Create(data);

            context.SaveChanges();      
        }
    }

}