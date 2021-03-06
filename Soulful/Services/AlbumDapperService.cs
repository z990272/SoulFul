﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using Soulful.Models;
using Soulful.ViewModels;

namespace Soulful.Services
{
    public class AlbumDapperService
    {
        public static string connString;
        public SqlConnection conn;
        public AlbumDapperService()
        {
            if (string.IsNullOrEmpty(connString))
            {
                connString = ConfigurationManager.ConnectionStrings["SoulfulContext"].ConnectionString;
            }
            if(conn == null)
            {
                conn = new SqlConnection(connString);
            }
        }

        public List<Language> getLanguages()
        {
            List<Language> languages = null;
            using (conn = new SqlConnection(connString))
            {
                string sql = @"select * from Language";
                languages = conn.Query<Language>(sql).ToList();
            }
            return languages;
        }

        public List<AlbumCard> getAlbums(string language) 
        {
            List<AlbumCard> albums = null;
            using(conn = new SqlConnection(connString))
            {
                string sql;
                if (language == "All")
                {
                    sql = @"select a.Album_id ,a.Pic ,a.About , a.Album_Name , s.Name,a.Price
                            from Album a
                            inner join Singer s on s.Singer_id = a.Singer_id
                            inner join [Language] l on l.Language_id = s.Language_id";
                }
                else
                {
                    sql = $"select a.Album_id ,a.Pic ,a.About , a.Album_Name , s.Name , a.Price from Album a inner join Singer s on s.Singer_id = a.Singer_id inner join[Language] l on l.Language_id = s.Language_id where l.Language_type = '{language}'";
                }
                albums = conn.Query<AlbumCard>(sql).ToList();

                return albums;
            }
        }
        public IEnumerable<AlbumCard> searchAlbums()
        {
            List<AlbumCard> albums = null;
            using (conn = new SqlConnection(connString))
            {
                string sql;
                sql = $"select a.Album_id ,a.Pic ,a.About , a.Album_Name , s.Name,a.Price from Album a inner join Singer s on s.Singer_id = a.Singer_id inner join [Language] l on l.Language_id = s.Language_id";
                
                albums = conn.Query<AlbumCard>(sql).ToList();

                return albums;
            }
        }
       
        #region AlbumCard
        public class AlbumCard
        {
            public int Album_id { get; set; }
            public string Pic { get; set; }
            public decimal Price { get; set; }
            public string About { get; set; }
            public string Album_Name { get; set; }
            public string Name { get; set; }
        }
        #endregion
    }
}