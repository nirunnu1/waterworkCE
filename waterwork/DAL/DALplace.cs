using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using waterwork.Models;



namespace waterwork.DAL
{
    public class DALplace
    {
        public static IEnumerable Getplace(int id)
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.place.Where(x => x.amphur_id == id).ToList();
        }
    }
}