﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btcuoiki.DAO
{
   public class AccountDAO
    {
        private static AccountDAO instance;
            public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "select * from dbo.Account where UserName = N'"+userName + "' and PassWord =  N'"+ passWord+" '";

            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count>0;
        }
    }
    
}
