using System;
using System.Collections.Generic;
using System.Data.Entity;  //Entityframework kütüphanesini yüklememiz gerekiyor
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33EntityFrameworkDemo
{
    public  class AlisverisDbContext:DbContext  // Bu alanda entity framework classını inherit,  miras olarak alacağımızı belirtiyoruz. 
    {
        public DbSet<Urun> Uruns { get; set; }
       

    }
}
