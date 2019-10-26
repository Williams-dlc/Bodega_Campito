using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static string username { set; get; }
        public static Int32 Telefono { set; get; }
        public static string Correo { set; get; }
        public static string Perfil { set; get; }
        public static string estado { set; get; }
    }
}
