using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class DataManager
    {
        //private static DataManager dm = new DataManager();

        public DataManager()
        {
            Load();
        }

        private void Load()
        {
            throw new NotImplementedException();
        }

        public static void Save()
        { }

        //public static DataManager GetInstance()
        //{
        //    return dm;
        //}
         
        public static List<BookVo> bookList = new List<BookVo>();
        public static List<UserVo> userList = new List<UserVo>();

        
        
    }
}
