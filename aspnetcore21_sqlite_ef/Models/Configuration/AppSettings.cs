using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore21_sqlite_ef.Models.Configuration
{
    public class AppSettings
    {
        public int Setting1 { get; set; }
        public string Setting2 { get; set; }
        public AppSettingsDel Undersetting1 { get; set; } = new AppSettingsDel();
    }

    public class AppSettingsDel
    {
        public int Setting1 { get; set; }
    }
}
