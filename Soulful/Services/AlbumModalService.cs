using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Soulful.Models;
using Soulful.Repositories;
namespace Soulful.Services
{
    public class AlbumModalService
    {
        public List<AlbumViewModel> GetModalinform()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);
            SoulfulRepository<Language> LanguageRespository = new SoulfulRepository<Language>(context);
            var albumContext = from Album in AlbumRepository.GetAll()
                               join Singer in SingerRepository.GetAll()
                                on Album.Singer_id equals Singer.Singer_id
                                join Language in LanguageRespository.GetAll()
                                on Singer.Language_id equals Language.Language_id
                               select new AlbumViewModel
                               {
                                   Name = Album.Album_Name,
                                   About = Album.About,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   Id = Album.Album_id,
                                   Language=Language.Language_type
                                  
                               };
            return albumContext.ToList();
        }

    }
}