using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btcuoiki.DTO
{
    public class Bill
    {
        //datetime? cho phep lay gia tri null
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status,int discouunt=0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;

            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if(dateCheckOutTemp.ToString()!="")
            this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];
            if (row["Discount"].ToString()!=" ")
            this.Discount = (int)row["discount"]; 
        }
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckOut; // dau ? de datetime co the lay gia tri null
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
