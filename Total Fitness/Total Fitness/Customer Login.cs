using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Total_Fitness
{
    public partial class Customer_Login : Form
    {
        Connection db = new Connection();

        //SqlConnection Conn;
        
         //this is creating a virtual table  
        int rcount;
        int pos = 0;
        
        public Customer_Login()
        {
            InitializeComponent();
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {
            db.DBConn();
        }

        private void btnclogin_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
               
                String CustomerloginSQL = ("SELECT * FROM Customers WHERE Username='" + txtcusername.Text + "' AND Password='" + txtcpassword.Text + "'");
                SqlCommand sqlCMD = new SqlCommand(CustomerloginSQL, db.Conn);
                sqlCMD.ExecuteNonQuery();
                
                SqlDataAdapter da = new SqlDataAdapter(sqlCMD);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    MessageBox.Show("WELCOME TO TOTAL FITNESS CUSTOMER INFORMATION SYSTEM.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.Conn.Close();
                                  
            }

            catch (Exception ex)
            {

                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
