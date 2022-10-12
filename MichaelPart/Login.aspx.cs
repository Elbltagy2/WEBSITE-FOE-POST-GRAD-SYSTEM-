using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Windows;

namespace MichaelPart
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void  login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            string mail = email.Value.ToString();
            string pass = password.Value.ToString();

            SqlCommand loginProc = new SqlCommand("userLogin", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar)).Value = mail;
            loginProc.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar)).Value = pass;

            SqlParameter id = loginProc.Parameters.Add("@id", SqlDbType.Int );
            id.Direction = System.Data.ParameterDirection.Output;

            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Bit);
            sucess.Direction = System.Data.ParameterDirection.Output;

            SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.VarChar,20);
            type.Direction = System.Data.ParameterDirection.Output;
           
                conn.Open();
                loginProc.ExecuteNonQuery();
                conn.Close();
                if (sucess.Value.ToString() == "True")
                {
                    Session["user"] = id.Value;
                    Session["type"] = type.Value;
                    

                    if (type.Value.ToString() == "Supervisor")
                    {

                        Response.Redirect("Supervisor.aspx");
                    }
                    else if (type.Value.ToString() == "NonGucianStudent")
                    {
                        Response.Redirect("Student2.aspx");
                    }
                    else if (type.Value.ToString() == "GucianStudent")
                    {
                        Response.Redirect("Student1.aspx");
                    }
                    else if (type.Value.ToString() == "Admin")
                    {
                        Response.Redirect("AdminView.aspx");
                    }
                    else if (type.Value.ToString() == "Examiner")
                    {
                        Response.Redirect("Examiner.aspx");
                    }
                }
               else
                    MessageBox.Show(sucess.Value.ToString());
            }

        protected void Register(object sender, EventArgs e)
        {

        }
    }
    }
