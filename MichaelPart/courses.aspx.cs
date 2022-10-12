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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand NonGucianCourseAndGrade = new SqlCommand("NonGucianCourse", conn);
            NonGucianCourseAndGrade.CommandType = CommandType.StoredProcedure;
            NonGucianCourseAndGrade.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Session["user"];

            conn.Open();
            SqlDataReader rdr3 = NonGucianCourseAndGrade.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr3.Read())
            {
                Int32 id_course = rdr3.GetInt32(rdr3.GetOrdinal("id"));
                Int32 fees = rdr3.GetInt32(rdr3.GetOrdinal("fees"));
                Int32 creditHours = rdr3.GetInt32(rdr3.GetOrdinal("creditHours"));
                String code = rdr3.GetString(rdr3.GetOrdinal("code"));
                Decimal grade = rdr3.GetDecimal(rdr3.GetOrdinal("grade"));

                TableRow k = new TableRow();
                TableCell id_coursee = new TableCell();
                id_coursee.Controls.Add(new LiteralControl("Course_id :" + id_course));

                TableCell feess = new TableCell();
                feess.Controls.Add(new LiteralControl("Fees :" + fees));

                TableCell CreditHourss = new TableCell();
                CreditHourss.Controls.Add(new LiteralControl("CreditHours : " + creditHours));

                TableCell codee = new TableCell();
                codee.Controls.Add(new LiteralControl("Code :" + code));

                TableCell gradee = new TableCell();
                gradee.Controls.Add(new LiteralControl("Grade :" + grade));


                k.Cells.Add(id_coursee);
                k.Cells.Add(feess);
                k.Cells.Add(CreditHourss);
                k.Cells.Add(codee);
                k.Cells.Add(gradee);
                Table3.Rows.Add(k);

            }
            conn.Close();

        }
    }
}