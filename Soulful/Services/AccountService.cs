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
        SoulfulContext _context;
        SoulfulRepository<GiveBacks> _repository ;
        public AccountService()
        {
            _context = new SoulfulContext();
            _repository = new SoulfulRepository<GiveBacks>(_context);
        }

        public void CreateGiveBack(GiveBackViewModel giveBack)
        {

            GiveBacks data = new GiveBacks()
            {
                Name = giveBack.Name,
                Email = giveBack.Email,
                Subject = giveBack.Subject,
                Message = giveBack.Message,
                Status = "未處理"
            };
            _repository.Create(data);

            _context.SaveChanges();      
        }
    }

}