using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private field list of staff
        private List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count {
            get
            {
                return mStaffList.Count;
            }

            set
            {
                //TODO
            }

         }

        public clsStaff ThisStaff { get; set; }

        //constructors
        public clsStaffCollection()
        {
            int i = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (i < RecordCount)
            {
                clsStaff StaffMember = new clsStaff();

                StaffMember.FirstName = Convert.ToString(DB.DataTable.Rows[i]["FirstName"]);
                StaffMember.LastName = Convert.ToString(DB.DataTable.Rows[i]["LastName"]);
                StaffMember.StartDate = Convert.ToDateTime(DB.DataTable.Rows[i]["StartDate"]);
                StaffMember.PhoneNumber = Convert.ToString(DB.DataTable.Rows[i]["PhoneNumber"]);
                StaffMember.IsManager = Convert.ToBoolean(DB.DataTable.Rows[i]["IsManager"]);
                StaffMember.HourlyRate = Convert.ToDecimal(DB.DataTable.Rows[i]["HourlyRate"]);

                mStaffList.Add(StaffMember);

                i++;
            }
        }

        //methods










    }
}