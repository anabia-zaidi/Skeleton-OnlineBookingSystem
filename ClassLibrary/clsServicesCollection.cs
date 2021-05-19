using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ClassLibrary
{
    public class clsServicesCollection
    {
     

            
            List<clsServices> mServiceList = new List<clsServices>();


        clsServices mThisService = new clsServices();


            public clsServices ThisService
        {
                get
                {
                    
                    return mThisService;
                }
                set
                {

                mThisService = value;
                }
            }

           

            public void Update()
            {
                
                clsDataConnection DB = new clsDataConnection();

                //set the parameters for the stored procedure
                DB.AddParameter("ServiceName", mThisService.ServiceName);
                DB.AddParameter("Staff", mThisService.Staff);
                DB.AddParameter("Price", mThisService.Price);
                DB.AddParameter("Duration", mThisService.Duration);
                DB.AddParameter("Discount", mThisService.Discount);
                

                //execute the stored procedure
                DB.Execute("sproc_tblServices_Update");
            }

            public List<clsServices> ServiceList
        {

                get
                {
                    //return the private data
                    return mServiceList;

                }


                set
                {
                mServiceList = value;
                }
            }




            public int Count
            {


                get
                {
                    //return the count of the list
                    return mServiceList.Count;
                }


                set
                {
                    // do this later
                }
            }

            public void Delete()
            {
               
                clsDataConnection DB = new clsDataConnection();

                //set the parameters for the stored procedure
                DB.AddParameter("@ServiceName", mThisService.ServiceName);

                //execute the stored procedure
                DB.Execute("sproc_tblServices_Delete");
            }



            void PopulateArray(clsDataConnection DB)
            {
                //populates the array list based on the data table in the parameter DB
                //var for the Index
                Int32 Index = 0;

                //var to store the record count
                Int32 RecordCount;

                //get the count of records
                RecordCount = DB.Count;

            //clear the private array list
            mServiceList = new List<clsServices>();

                //while there are records to process
                while (Index < RecordCount)
                {
                //create a blank address
                clsServices AService = new clsServices();

                //read in the fields from the current record
                AService.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
               
                AService.Duration = Convert.ToInt32(DB.DataTable.Rows[Index]["Duration"]);
                AService.Discount = Convert.ToBoolean(DB.DataTable.Rows[Index]["Discount"]);
                AService.ServiceName = Convert.ToString(DB.DataTable.Rows[Index]["ServiceName"]);
                AService.Staff = Convert.ToString(DB.DataTable.Rows[Index]["Staff"]);
                //add the record to the private data member
                mServiceList.Add(AService);

                    //point to the next record
                    Index++;

                }
            }

        public void ServiceByStaff(string v)
        {
            throw new NotImplementedException();
        }

        public void ServiceByStaff(object text)
        {
            throw new NotImplementedException();
        }




        //constructor for the class
        public clsServicesCollection()
            {
                //object for data connection
                clsDataConnection DB = new clsDataConnection();

                //execute the stored procedure
                DB.Execute("sproc_tblServices_SelectAll");

                //populate the arraylist with the data table
                PopulateArray(DB);

            }

            public void ServicesByServiceName(string ServiceName)
            {
                
                clsDataConnection DB = new clsDataConnection();

               
                DB.AddParameter("@ServiceName", ServiceName);

                //execute the stored procedure
                DB.Execute("sproc_tblServices_FilterByServiceName");

                //populate array list with the data table
                PopulateArray(DB);
            }

            public int Add()
            {
                              clsDataConnection DB = new clsDataConnection();

                //set the parameters for the stored procedures
                DB.AddParameter("ServiceName", mThisService.ServiceName);
                DB.AddParameter("Duration", mThisService.Duration);
                DB.AddParameter("Price", mThisService.Price);
                DB.AddParameter("Staff", mThisService.Staff);
                DB.AddParameter("Discount", mThisService.Discount);

                //execute the query returning the primary key value
                return DB.Execute("sproc_tblServices_Insert");
            }
        }
    }