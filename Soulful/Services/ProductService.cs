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
        SoulfulContext _context  ;
        SoulfulRepository<Singer> _singerRepo ;
        SoulfulRepository<Album> _albumRepo ;
        public ProductService()
        {
            _context = new SoulfulContext();
            _singerRepo = new SoulfulRepository<Singer>(_context);
            _albumRepo = new SoulfulRepository<Album>(_context);
        }
        public Album GetProductById(int Id)
        {
            var ProductById = _albumRepo.GetAll().FirstOrDefault(x => x.Album_id == Id);
            return ProductById;
        }

        public IEnumerable<CardViewModel> GetSingerName()
        {
            var SingerName = from album in _albumRepo.GetAll()
                             join singer in _singerRepo.GetAll()
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
            var albumContext = from Album in _albumRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.WeekHits descending
                               select new HitViewModel
                               {
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   WeekHits = Album.WeekHits,
                                   Price=Album.Price
                               };
            return albumContext.Take(10).ToList();
        }

        public List<HitViewModel> GetMonthHits()
        {
            var albumContext = from Album in _albumRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.MonthHits descending
                               select new HitViewModel
                               {
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   MonthHits = Album.MonthHits
                               };
            return albumContext.Take(10).ToList();
        }
        public List<HitViewModel> GetTotalHits()
        {
            var albumContext = from Album in _albumRepo.GetAll()
                               join Singer in _singerRepo.GetAll()
                               on Album.Singer_id equals Singer.Singer_id
                               orderby Album.Hits descending
                               select new HitViewModel
                               {
                                   Id = Album.Album_id,
                                   Name = Album.Album_Name,
                                   Pic = Album.Pic,
                                   Singer = Singer.Name,
                                   TotalHits = Album.Hits,
                                   VideoUrl = Album.Video
                               };
            return albumContext.Take(10).ToList();
        }

        public void UpdateHit(int id)
        {
            var product = GetProductById(id);

            product.Hits++;
            product.WeekHits++;
            product.MonthHits++;

            _albumRepo.Update(product);
            _context.SaveChanges();
        }

        public string GetVideoById(int Id)
        {
            var ProductById = _albumRepo.GetAll().FirstOrDefault(x => x.Album_id == Id);
            return ProductById.Video;
        }
    }
}