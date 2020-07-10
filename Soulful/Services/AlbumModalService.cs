using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Soulful.Models;
using Soulful.Repositories;
using static Soulful.Services.AlbumDapperService;

namespace Soulful.Services
{
    public class AlbumModalService
    {
        public List<AlbumViewModel> GetModalinform()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);
       
            var albumContext = from Album in AlbumRepository.GetAll()
                               join Singer in SingerRepository.GetAll()
                                on Album.Singer_id equals Singer.Singer_id
                              
                              
                               select new AlbumViewModel
                               {
                                   Name = Album.Album_Name,
                                   About = Album.About,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   Id = Album.Album_id,                                  
                               };
            return albumContext.ToList();
        }
        public List<AlbumViewModel> GetLanguage()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Language> LanguageRepository = new SoulfulRepository<Language>(context);
            var language = from Language in LanguageRepository.GetAll()

                           select new AlbumViewModel
                           {
                               Language = Language.Language_type
                           };
            return language.ToList();
            
        }
       
    }
}