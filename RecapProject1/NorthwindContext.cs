using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Entities;

namespace RecapProject1
{
    //EntityFramework u kullanabilmek için Context sınıfının
    //DbContext en oluşturulması gerek
    public class NorthwindContext:DbContext
    {
        //Burada nesnelerin veritabanı ile bağlantısı gerçekleştiriliyor
        //Veritabanında tabloya karşılık gelen nesneye ihtiyaç var

        //Benim bir dbsetim var veritabanındaki Products alanına karşılık geliyor anlamında
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
