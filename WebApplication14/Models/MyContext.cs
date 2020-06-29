using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApplication14.Models
{

    public class MyContext : DbContext
    {
        //コンストラクタ
        public MyContext(DbContextOptions<MyContext>options) : base(options) { }
        //モデルクラスへのアクセサー
        public DbSet<Book>Book { get; set; }
    }


}
