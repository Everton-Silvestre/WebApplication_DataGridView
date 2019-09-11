using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //// Example list.
            //List<string[]> list = new List<string[]>();
            //list.Add(new string[] { "CustomerID", "ContactName", "City", "Country" });
            //list.Add(new string[] { "Row 2", "Row 2" });
            //list.Add(new string[] { "Row 3" });

            //// Convert to DataTable.
            //DataTable table = ConvertListToDataTable(list);
            //GridView1.DataSource = table;
            //GridView1.DataBind();

            //DataTable dt = new DataTable();

            //dt.Columns.Add("CustomerID");
            //dt.Columns.Add("ContactName");
            //dt.Columns.Add("City");
            //dt.Columns.Add("Country");

            //for (int i = 0; i < 30; i++)
            //{

            //    var row = dt.NewRow();
            //    row["CustomerID"] = i;
            //    row["ContactName"] = "TESTE";
            //    row["City"] = "TESTE";
            //    row["Country"] = "TESTe";
            //    dt.Rows.Add(row);


            //}           


            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            if (!this.IsPostBack)
            {
                this.BindGrid(GridView1.PageIndex);
            }

        }

        private void BindGrid(int numPag)
        {


            DataTable dt = new DataTable();

            dt.Columns.Add("CustomerID");
            dt.Columns.Add("ContactName");
            dt.Columns.Add("City");
            dt.Columns.Add("Country");

            
            if (numPag == 0)
            {
                for (int i = 0; i < 10; i++)
                {

                    var row = dt.NewRow();
                    row["CustomerID"] = i;
                    row["ContactName"] = "TESTE";
                    row["City"] = "TESTE";
                    row["Country"] = "TESTe";
                    dt.Rows.Add(row);


                }
            }
            else if(numPag == 1) 
            {

                for (int i = 0; i < 10; i++)
                {

                    var row = dt.NewRow();
                    row["CustomerID"] = i;
                    row["ContactName"] = "TESTE";
                    row["City"] = "TESTE";
                    row["Country"] = "TESTe";
                    dt.Rows.Add(row);


                }

            }
            else if (numPag == 2)
            {

                for (int i = 0; i < 3; i++)
                {

                    var row = dt.NewRow();
                    row["CustomerID"] = i;
                    row["ContactName"] = "TESTE";
                    row["City"] = "TESTE";
                    row["Country"] = "TESTe";
                    dt.Rows.Add(row);


                }

            }

            else if (numPag == 3)
            {

                for (int i = 0; i < 40; i++)
                {

                    var row = dt.NewRow();
                    row["CustomerID"] = i;
                    row["ContactName"] = "TESTE";
                    row["City"] = "TESTE";
                    row["Country"] = "TESTe";
                    dt.Rows.Add(row);


                }

            }

            GridView1.VirtualItemCount = 30;



            GridView1.DataSource = dt;
            GridView1.DataBind();

            //Value2.Text = e.ToString();




            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SELECT CustomerId, ContactName, City, Country FROM Customers"))
            //    {
            //        using (SqlDataAdapter sda = new SqlDataAdapter())
            //        {
            //            cmd.Connection = con;
            //            sda.SelectCommand = cmd;
            //            using (DataTable dt = new DataTable())
            //            {
            //                sda.Fill(dt);
            //                GridView1.DataSource = dt;
            //                GridView1.DataBind();
            //            }
            //        }
            //    }
            //}
        }

        //static DataTable ConvertListToDataTable(List<string[]> list)
        //{
        //    // New table.
        //    DataTable table = new DataTable();

        //    // Get max columns.
        //    int columns = 0;
        //    foreach (var array in list)
        //    {
        //        if (array.Length > columns)
        //        {
        //            columns = array.Length;
        //        }
        //    }

        //    // Add columns.
        //    for (int i = 0; i < columns; i++)
        //    {
        //        table.Columns.Add();
        //    }

        //    // Add rows.
        //    foreach (var array in list)
        //    {
        //        table.Rows.Add(array);
        //    }

        //    return table;
        //}

        //static DataTable ConvertToDatatable(List<String[]> list)
        //{
        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("Name");
        //    dt.Columns.Add("Price");
        //    dt.Columns.Add("URL");
        //    foreach (var item in list)
        //    {
        //        var row = dt.NewRow();

        //        row["Name"] = item.Name;
        //        row["Price"] = Convert.ToString(item.Price);
        //        row["URL"] = item.URL;

        //        dt.Rows.Add(row);
        //    }

        //    return dt;
        //}

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            //Value2.Text = .ToString();
            this.BindGrid(e.NewPageIndex);
            //Search(e.NewPageIndex);

        }

        protected void Search(int pageNo)
        {
            //gridView.PageSize = 10;
            //int totalRecords;
            //GridView1.VirtualItemCount = 150;
            this.BindGrid(pageNo);

            //Call the Custom Paging Stored Procedure to fetch the records of 
            //the page (value contained by pageNo). The Stored procedure should 
            //return the total number of records. Set the total number of 
            //records to the totalRecords variable.

          
            //GridView1.DataSource = myDataTable;
            //GridView1.DataBind();
        }
    }
}