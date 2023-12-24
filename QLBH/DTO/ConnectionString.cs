using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
    public class ConnectionString
    {
        public static string connectData = "";
        public static string ConnectToFile(string filename)
        {
            string filePath = @$"{connectData}\{filename}";
            return filePath;
        }
        public static string ConnectToPicture()
        {
            string filePath = @$"{connectData}\QLBH\Pictures";
            return filePath;
        }
    }
}
