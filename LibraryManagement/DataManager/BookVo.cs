using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class BookVo
    {
        public string IsBn { get; set; }

        public string BookName { get; set; }

        public string BookPublisher { get; set; }

        public int Page { get; set; }


        public int UserId { get; set; }

        public string UserName { get; set; }

        public bool isBorrowed { get; set; }

        public DateTime BorrowedAt { get; set; }
    }
}
