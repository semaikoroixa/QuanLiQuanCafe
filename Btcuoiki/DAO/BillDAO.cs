using Btcuoiki.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Btcuoiki.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance 
        {
            get{ if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set{ BillDAO.instance = value;  }
        
        }
        private BillDAO() { }
        //thanh cong hien ra bill ID
        //that bai -1
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.Bill where idTable="+id+" and status=0");
            if(data.Rows.Count > 0) //neu so truong tra ve > 0
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1; // neu k co hien ra truong nao tuc la kho ng co ban id=-1
        }
        public void CheckOut(int id,int discount,float totalPrice)
        {
            string query = "update dbo.Bill set dateCheckOut = GETDATE(), status=1, " +"discount= "+discount+", totalPrice = "+totalPrice+" where id= "+id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void InsertBill(int id)
        {

            string query = "exec USP_InsertBill @idTable";
            DataProvider.Instance.ExcuteNonQuery(query,new object[]{id});
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }
        public int GetMaxIDBill()
        {
            try {
                return (int)DataProvider.Instance.ExcuteScalar("select max(id) from dbo.Bill");
            }
            catch {
                return 1;
            }
            }
    }
}
