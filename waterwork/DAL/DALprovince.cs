using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using waterwork.Models;

namespace waterwork.DAL
{
    public class DALprovince
    {
        public static IEnumerable Getprovince()
        {
            AssetDbContext Context = new AssetDbContext();
            return Context.province.ToList();
        }
    }
}