using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using waterwork.Models;


namespace waterwork.DAL
{
    public class DALamphur
    {
        public static IEnumerable Getamphur(int id)
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.amphur.Where(x=>x.province_id ==id).ToList();
        }
    }
}