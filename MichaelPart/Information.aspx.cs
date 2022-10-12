using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MichaelPart
{
    public partial class Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand data = new SqlCommand("GucianandNonStudentData", conn);
            data.CommandType = CommandType.StoredProcedure;
            data.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Session["user"];

            conn.Open();
            SqlDataReader rdr = data.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                Int32 id = rdr.GetInt32(rdr.GetOrdinal("id"));
                String firstName = rdr.GetString(rdr.GetOrdinal("firstName"));
                String lastName = rdr.GetString(rdr.GetOrdinal("lastName"));
                String type = rdr.GetString(rdr.GetOrdinal("type"));
                String faculty = rdr.GetString(rdr.GetOrdinal("faculty"));
                Decimal GPA = rdr.GetDecimal(rdr.GetOrdinal("GPA"));
                String address = rdr.GetString(rdr.GetOrdinal("address"));


                TableRow r0 = new TableRow();
                TableCell id1 = new TableCell();
                id1.Controls.Add(new LiteralControl("ID"));
                r0.Cells.Add(id1);
                TableCell id2 = new TableCell();
                id2.Controls.Add(new LiteralControl(id+""));
                r0.Cells.Add(id2);
                Table2.Rows.Add(r0);


                TableRow r1 = new TableRow();
                TableCell firstName1 = new TableCell();
                firstName1.Controls.Add(new LiteralControl("First Name"));
                r1.Cells.Add(firstName1);
                TableCell firstName2 = new TableCell();
                firstName2.Controls.Add(new LiteralControl(firstName));
                r1.Cells.Add(firstName2);
                Table2.Rows.Add(r1);

                TableRow r2 = new TableRow();
                TableCell lastName1 = new TableCell();
                lastName1.Controls.Add(new LiteralControl("lastName"));
                r2.Cells.Add(lastName1);
                TableCell lastName2 = new TableCell();
                lastName2.Controls.Add(new LiteralControl(lastName));
                r2.Cells.Add(lastName2);
                Table2.Rows.Add(r2);

                TableRow r3 = new TableRow();
                TableCell type1 = new TableCell();
                type1.Controls.Add(new LiteralControl("type"));
                r3.Cells.Add(type1);
                TableCell type2 = new TableCell();
                type2.Controls.Add(new LiteralControl(type));
                r3.Cells.Add(type2);
                Table2.Rows.Add(r3);

                TableRow r4 = new TableRow();
                TableCell faculty1 = new TableCell();
                faculty1.Controls.Add(new LiteralControl("faculty"));
                r4.Cells.Add(faculty1);
                TableCell faculty2 = new TableCell();
                faculty2.Controls.Add(new LiteralControl(faculty));
                r4.Cells.Add(faculty2);
                Table2.Rows.Add(r4);

                TableRow r5 = new TableRow();
                TableCell GPA1 = new TableCell();
                GPA1.Controls.Add(new LiteralControl("GPA"));
                r5.Cells.Add(GPA1);
                TableCell GPA2 = new TableCell();
                GPA2.Controls.Add(new LiteralControl(GPA + ""));
                r5.Cells.Add(GPA2);
                Table2.Rows.Add(r5);

                TableRow r6 = new TableRow();
                TableCell address1 = new TableCell();
                address1.Controls.Add(new LiteralControl("address"));
                r6.Cells.Add(address1);
                TableCell address2 = new TableCell();
                address2.Controls.Add(new LiteralControl(address));
                r6.Cells.Add(address2);
                Table2.Rows.Add(r6);
                if (Session["type"].ToString() == "GucianStudent")
                {
                    Int32 undergradID = rdr.GetInt32(rdr.GetOrdinal("undergradID"));
                    TableRow r7 = new TableRow();
                    TableCell undergradID1 = new TableCell();
                    undergradID1.Controls.Add(new LiteralControl("undergradID"));
                    r7.Cells.Add(undergradID1);
                    TableCell undergradID2 = new TableCell();
                    undergradID2.Controls.Add(new LiteralControl(undergradID + ""));
                    r7.Cells.Add(undergradID2);
                    Table2.Rows.Add(r7);
                }




            }
            conn.Close();

        }
    }
}