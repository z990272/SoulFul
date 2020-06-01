using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Soulful.Services
{
    public class NewsService
    {
        public List<NewsViewModel> GetAll()
        {
            SoulfulContext context = new SoulfulContext();
            var NewsRepository = new SoulfulRepository<News>(context);
            var SingerRepository = new SoulfulRepository<Singer>(context);

            var GetNewsDetail = from news in NewsRepository.GetAll()
                                join singer in SingerRepository.GetAll()
                                on news.Singer_id equals singer.Singer_id
                                select new NewsViewModel
                                {
                                    Singer = singer.Name,
                                    About = news.About,
                                    Pic = news.Pic,
                                    Title = news.News_title
                                };
            return GetNewsDetail.ToList();
        }
    }
}