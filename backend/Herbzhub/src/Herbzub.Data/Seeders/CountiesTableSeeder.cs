﻿using Herbzhub.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Herbzhub.Data.Seeders
{
    public class CountiesTableSeeder : IEntityTypeConfiguration<Counties>
    {
        public void Configure(EntityTypeBuilder<Counties> builder)
        {
            builder.HasData(GetCounties());
        }

        public static List<Counties> GetCounties()
        {
            var counties = new List<string>
            {
                "Adair", "Andrew", "Atchison", "Audrain", "Barry", "Barton", "Bates", "Benton", "Bollinger",
                "Boone", "Buchanan", "Butler", "Caldwell", "Callaway", "Camden", "Cape Girardeau", "Carroll",
                "Carter", "Cass", "Cedar", "Chariton", "Christian", "Clark", "Clay", "Clinton", "Cole",
                "Cooper", "Crawford", "Dade", "Dallas", "Daviess", "DeKalb", "Dent", "Douglas", "Dunklin",
                "Franklin", "Gasconade", "Gentry", "Greene", "Grundy", "Harrison", "Henry", "Hickory",
                "Holt", "Howard", "Howell", "Iron", "Jackson", "Jasper", "Jefferson", "Johnson",
                "Knox", "Laclede", "Lafayette", "Lawrence", "Lewis", "Lincoln", "Linn", "Livingston",
                "Macon", "Madison", "Maries", "Marion", "McDonald", "Mercer", "Miller", "Mississippi",
                "Moniteau", "Monroe", "Montgomery", "Morgan", "New Madrid", "Newton", "Nodaway",
                "Oregon", "Osage", "Ozark", "Pemiscot", "Perry", "Pettis", "Phelps", "Pike", "Platte",
                "Polk", "Pulaski", "Putnam", "Ralls", "Randolph", "Ray", "Reynolds", "Ripley", "St. Charles",
                "St. Clair", "St. Francois", "St. Louis", "Ste. Genevieve", "Saline", "Schuyler",
                "Scotland", "Scott", "Shannon", "Shelby", "Stoddard", "Stone", "Sullivan", "Taney",
                "Texas", "Vernon", "Warren", "Washington", "Wayne", "Webster", "Worth", "Wright",
                "City of St. Louis"
            };

            var countyEntities = new List<Counties>();

            for (int i = 0; i < counties.Count; i++)
            {
                countyEntities.Add(new Counties { Id = i + 1, Name = counties[i] });
            }

            return countyEntities;
        }
    }
}
