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
    public partial class Thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand Thesis = new SqlCommand("getThesis", conn);
            Thesis.CommandType = CommandType.StoredProcedure;
            Thesis.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Session["user"];

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
                TableCell serialNumberr = new TableCell();
                serialNumberr.Controls.Add(new LiteralControl("serialNumber :" + serialNumber));

                TableCell fieldd = new TableCell();
                fieldd.Controls.Add(new LiteralControl("field :" + field));

                TableCell typee = new TableCell();
                typee.Controls.Add(new LiteralControl("type : " + type));

                TableCell titlee = new TableCell();
                titlee.Controls.Add(new LiteralControl("title :" + title));

                TableCell startDatee = new TableCell();
                startDatee.Controls.Add(new LiteralControl("startDate :" + startDate));

                TableCell endDatee = new TableCell();
                endDatee.Controls.Add(new LiteralControl("endDate :" + endDate));

                TableCell DefenseDatee = new TableCell();
                DefenseDatee.Controls.Add(new LiteralControl("DefenseDate :" + DefenseDate));

                TableCell yearss = new TableCell();
                yearss.Controls.Add(new LiteralControl("years :" + years));

                TableCell gradee = new TableCell();
                gradee.Controls.Add(new LiteralControl("grade :" + grade));

                TableCell payment_idd = new TableCell();
                payment_idd.Controls.Add(new LiteralControl("payment_id :" + payment_id));

                TableCell noExtensionn = new TableCell();
                noExtensionn.Controls.Add(new LiteralControl("noExtensions :" + noExtension));



                r.Cells.Add(serialNumberr);
                r.Cells.Add(fieldd);
                r.Cells.Add(typee);
                r.Cells.Add(titlee);
                r.Cells.Add(startDatee);
                r.Cells.Add(endDatee);
                r.Cells.Add(DefenseDatee);
                r.Cells.Add(yearss);
                r.Cells.Add(gradee);
                r.Cells.Add(payment_idd);
                r.Cells.Add(noExtensionn);
                Table1.Rows.Add(r);



            }
            conn.Close();
        }
    }
}