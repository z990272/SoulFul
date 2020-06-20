using Microsoft.Ajax.Utilities;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soulful.Services
{
    public class ProductService
    {
        SoulfulContext context = new SoulfulContext();
        public Album GetProductById(int Id)
        {
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);
            var ProductById = AlbumRepository.GetAll().FirstOrDefault(x => x.Album_id == Id);
            return ProductById;
        }

        public IEnumerable<CardViewModel> GetSingerName()
        {
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);
            var SingerName = from album in AlbumRepository.GetAll()
                             join singer in SingerRepository.GetAll()
                             on album.Singer_id equals singer.Singer_id
                             select new CardViewModel
                             {
                                 Pic = album.Pic,
                                 Name = album.Album_Name,
                                 Singer = singer.Name
                             };

            return SingerName;

        }

        public List<HitViewModel> GetWeekHits()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);

            var albumContext = from Album in AlbumRepository.GetAll()
                               join Singer in SingerRepository.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.WeekHits descending
                               select new HitViewModel
                               {
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   WeekHits = Album.WeekHits,
                                   MonthHits = Album.MonthHits,
                                   TotalHits = Album.Hits
                               };
            return albumContext.ToList();
        }

        public List<HitViewModel> GetMonthHits()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);

            var albumContext = from Album in AlbumRepository.GetAll()
                               join Singer in SingerRepository.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.MonthHits descending
                               select new HitViewModel
                               {
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   WeekHits = Album.WeekHits,
                                   MonthHits = Album.MonthHits,
                                   TotalHits = Album.Hits
                               };
            return albumContext.ToList();
        }
        public List<HitViewModel> GetTotalHits()
        {
            SoulfulContext context = new SoulfulContext();
            SoulfulRepository<Singer> SingerRepository = new SoulfulRepository<Singer>(context);
            SoulfulRepository<Album> AlbumRepository = new SoulfulRepository<Album>(context);

            var albumContext = from Album in AlbumRepository.GetAll()
                               join Singer in SingerRepository.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.Hits descending
                               select new HitViewModel
                               {
                                   Id = Album.Album_id,
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   WeekHits = Album.WeekHits,
                                   MonthHits = Album.MonthHits,
                                   TotalHits = Album.Hits,
                                   VideoUrl = Album.Video
                               };
            return albumContext.ToList();
        }

    }
}