using PBLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBL3.Models.BUS
{
    public class PBLBus
    {
        public static IEnumerable<GIANGVIEN> DanhSach()
        {
            var DB = new PBLConnectionDB();
            return DB.Query<GIANGVIEN>("select * from GIANGVIEN where Status = 0");
        }
        public static GIANGVIEN Chitiet(string a)
        {
            var DB = new PBLConnectionDB();
            return DB.SingleOrDefault<GIANGVIEN> ("select * from GIANGVIEN where MaGV =@0", a);
        }
        public static GIANGVIEN home(string a)
        {
            var DB = new PBLConnectionDB();
            return DB.SingleOrDefault<GIANGVIEN>("select * from GIANGVIEN where MaGV = @0",a);
        }
    }
}