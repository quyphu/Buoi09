﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bai7
{  
    
    public class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data Source=A209PC28;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
