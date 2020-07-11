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
        SoulfulContext _context;
        SoulfulRepository<Singer> _singerRepo;
        SoulfulRepository<Album> _albumRepo;
        SoulfulRepository<Language> _languageRepo ;
        public AlbumModalService()
        {
            _context = new SoulfulContext();
            _singerRepo = new SoulfulRepository<Singer>(_context);
            _albumRepo = new SoulfulRepository<Album>(_context);
            _languageRepo = new SoulfulRepository<Language>(_context);
        }
        public List<AlbumViewModel> GetModalinform()
        {

       
            var albumContext = from Album in _albumRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
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
            var language = from Language in _languageRepo.GetAll()

                           select new AlbumViewModel
                           {
                               Language = Language.Language_type
                           };
            return language.ToList();
            
        }
       
    }
}