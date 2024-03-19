﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class OduncVerilenKitaplar : Kutuphane
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public OduncVerilenKitaplar(string bookID, string bookName, string memberId, string memberName, string memberLastName)
        {
            BookId = bookID;
            BookName = bookName;
            MemberID = memberId;
            MemberName = memberName;
            MemberLastName = memberLastName;
        }


    }
}