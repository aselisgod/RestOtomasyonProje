﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restoran
{
    class cGenel
    {
        public string conString = ("Server=ASELITY\\SQLEXPRESS;Database=Restaurant;Trusted_Connection=True");

        public static int _PersonelId;
        public static int _gorevId;

        public static string _ButtonValue;
        public static string _ButtonName;
        public static int _ServisTurNO;
        public static string _AdisyonId;
    }
}
