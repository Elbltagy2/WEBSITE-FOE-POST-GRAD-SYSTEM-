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
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand data = new SqlCommand("GucianandNonStudentData", conn);
            data.CommandType = CommandType.StoredProcedure;
            data.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value =Session["user"];

            SqlCommand Thesis = new SqlCommand("getThesis", conn);
            Thesis.CommandType = CommandType.StoredProcedure;
            Thesis.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Session["user"];

            SqlCommand NonGucianCourseAndGrade = new SqlCommand("NonGucianCourse", conn);
            NonGucianCourseAndGrade.CommandType = CommandType.StoredProcedure;
            NonGucianCourseAndGrade.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Session["user"];

            conn.Open();
            SqlDataReader rdr = data.ExecuteReader(CommandBehavior.CloseConnection);
            

            while (rdr.Read())
            {
                String firstName = rdr.GetString(rdr.GetOrdinal("firstName"));
                String lastName = rdr.GetString(rdr.GetOrdinal("lastName"));
                String type = rdr.GetString(rdr.GetOrdinal("type"));
                String faculty = rdr.GetString(rdr.GetOrdinal("faculty"));
                Decimal GPA = rdr.GetDecimal(rdr.GetOrdinal("GPA"));
                String address = rdr.GetString(rdr.GetOrdinal("address"));
                

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
                GPA2.Controls.Add(new LiteralControl(GPA+""));
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
            conn.Open();
            SqlDataReader rdr2 = Thesis.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr2.Read())
            {
                Int32 serialNumber = rdr2.GetInt32(rdr2.GetOrdinal("serialNumber"));
                String field = rdr2.GetString(rdr2.GetOrdinal("field"));
                String type = rdr2.GetString(rdr2.GetOrdinal("type"));
                String title = rdr2.GetString(rdr2.GetOrdinal("title"));
                DateTime startDate = rdr2.GetDateTime(rdr2.GetOrdinal("startDate"));
                DateTime endDate = rdr2.GetDateTime(rdr2.GetOrdinal("endDate"));
                DateTime DefenseDate = rdr2.GetDateTime(rdr2.GetOrdinal("defenseDate"));
                Int32 years = rdr2.GetInt32(rdr2.GetOrdinal("years"));
                Decimal grade = rdr2.GetDecimal(rdr2.GetOrdinal("grade"));
                Int32 payment_id = rdr2.GetInt32(rdr2.GetOrdinal("payment_id"));
                Int32 noExtension = rdr2.GetInt32(rdr2.GetOrdinal("noOfExtensions"));
                TableRow r = new TableRow();
                TableCell serialNumber1 = new TableCell();
                serialNumber1.Controls.Add(new LiteralControl("serialNumber :" + serialNumber));

                TableCell field1 = new TableCell();
                field1.Controls.Add(new LiteralControl("field :" + field));

                TableCell type1 = new TableCell();
                type1.Controls.Add(new LiteralControl("type : " + type));

                TableCell title1 = new TableCell();
                title1.Controls.Add(new LiteralControl("title :" + title));

                TableCell startDate1 = new TableCell();
                startDate1.Controls.Add(new LiteralControl("startDate :" + startDate));

                TableCell endDate1 = new TableCell();
                endDate1.Controls.Add(new LiteralControl("endDate :" + endDate));

                TableCell DefenseDate1 = new TableCell();
                DefenseDate1.Controls.Add(new LiteralControl("DefenseDate :" + DefenseDate));

                TableCell years1 = new TableCell();
                years1.Controls.Add(new LiteralControl("years :" + years));

                TableCell grade1 = new TableCell();
                grade1.Controls.Add(new LiteralControl("grade :" + grade));

                TableCell payment_id1 = new TableCell();
                payment_id1.Controls.Add(new LiteralControl("payment_id :" + payment_id));

                TableCell noExtension1 = new TableCell();
                noExtension1.Controls.Add(new LiteralControl("noExtensions :" + noExtension));

                

                r.Cells.Add(serialNumber1);
                r.Cells.Add(field1);
                r.Cells.Add(type1);
                r.Cells.Add(startDate1);
                r.Cells.Add(endDate1);
                r.Cells.Add(DefenseDate1);
                r.Cells.Add(years1);
                r.Cells.Add(grade1);
                r.Cells.Add(payment_id1);
                r.Cells.Add(noExtension1);
                Table1.Rows.Add(r);



            }
            conn.Close();

            conn.Open();
            SqlDataReader rdr3 = NonGucianCourseAndGrade.ExecuteReader(CommandBehavior.CloseConnection);
            if(Session["type"].ToString() == "NonGucianStudent")
            {
                course.InnerHtml = "Your course";
            }
            while (rdr3.Read())
            {
                Int32 id_course = rdr3.GetInt32(rdr3.GetOrdinal("id"));
                Int32 fees = rdr3.GetInt32(rdr3.GetOrdinal("fees"));
                Int32 type = rdr3.GetInt32(rdr3.GetOrdinal("creditHours"));
                String code = rdr3.GetString(rdr3.GetOrdinal("code"));
                Decimal grade = rdr3.GetDecimal(rdr3.GetOrdinal("grade"));

                TableRow r = new TableRow();
                TableCell id_course1 = new TableCell();
                id_course1.Controls.Add(new LiteralControl("serialNumber :" + id_course));

                TableCell fees1 = new TableCell();
                fees1.Controls.Add(new LiteralControl("field :" + fees));

                TableCell type1 = new TableCell();
                type1.Controls.Add(new LiteralControl("type : " + type));

                TableCell code1 = new TableCell();
                code1.Controls.Add(new LiteralControl("title :" + code));

                TableCell grade1 = new TableCell();
                grade1.Controls.Add(new LiteralControl("startDate :" + grade));

                

                r.Cells.Add(id_course1);
                r.Cells.Add(fees1);
                r.Cells.Add(type1);
                r.Cells.Add(code1);
                r.Cells.Add(grade1);
                Table3.Rows.Add(r);

            }
            conn.Close();

        }
    }


     
}