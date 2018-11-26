using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    class Borrow
    {
        public int BorrowId { get; set; }

        public DateTime BorrowDay { get; set; }

        public int BorrowBookId { get; set; }

        public int BorrowUserId { get; set; }
    }
}
