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
    public partial class Login : Form
    {
        Connection db = new Connection();

        //SqlConnection Conn;
        SqlDataAdapter DA;
        DataSet myDS = new DataSet();
      
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;
            String usertype = "";

            db.Conn.Open();
           
            String LoginSQL = ("SELECT User_Type FROM Users WHERE Username='" + txtusername.Text + "' AND Password='" + txtpassword.Text + "'");
            DA = new SqlDataAdapter(LoginSQL, db.Conn);
            DA.Fill(myDS, "searchTBL");

            if (myDS.Tables["searchTBL"].Rows.Count > 0)
            {

                usertype = myDS.Tables["searchTBL"].Rows[0][0].ToString();
            }


            if (usertype.Equals("Administrator"))
            {
                MessageBox.Show("LOGIN SUCCESSFUL", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Administrator_Main admin = new Administrator_Main();
                admin.Show();
                Pharmacy_Main ph = new Pharmacy_Main();
                ph.Close();
            }
            else if (usertype.Equals("Pharmacist"))
            {
                MessageBox.Show("LOGIN SUCCESSFUL", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pharmacy_Main pharmacy = new Pharmacy_Main();
                pharmacy.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.Conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db.DBConn();
            
        }

        private void cmbnames_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void cmbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
