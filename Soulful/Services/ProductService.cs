using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.Services
{
    public class ProductService
    {
        public List<CardViewModel> GetSingerName()
        {
            SoulfulContext context = new SoulfulContext();
            ProductRepository<Singer> SingerRepository = new ProductRepository<Singer>(context);
            ProductRepository<Album> AlbumRepository = new ProductRepository<Album>(context);
            var SingerName = from album in AlbumRepository.GetAll()
                             join singer in SingerRepository.GetAll()
                             on album.Singer_id equals singer.Singer_id
                             select new CardViewModel { Pic = album.Pic, Name = album.Album_Name, Singer = singer.Name };

            return SingerName.ToList();
        }
    }
}