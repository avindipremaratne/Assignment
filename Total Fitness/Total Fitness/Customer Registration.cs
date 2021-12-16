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
    public partial class Customer_Registration : Form
    {
        Connection db = new Connection();



        SqlDataAdapter DA;
        DataSet DS = new DataSet();
        int rcount;
        int pos = 0;
        public Customer_Registration()
        {
            InitializeComponent();
        }
        private void Fillcustomers()
        {
            String temp = (String)txtsearchname.Text +"%";
            String sql = ("SELECT * FROM Customers WHERE Name like '" + temp + "'");
            try
            {
               
                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLTBL");

                int noofrows = DS.Tables["SelectALLTBL"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbnames.Items.Add(DS.Tables["SelectALLTBL"].Rows[x][0].ToString());
                }

              
            }
            catch (SqlException ex)
            {

            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtcustomerid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtnicno.Text = "";
            txtgender.Text = "";
            txtdob.Text = "";
            txtemail.Text = "";
            txttelno.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //INSERT
            try
            {
                if (db.Conn.State == ConnectionState.Closed)
                {
                    db.Conn.Open();
                }

                if( (txtcustomerid.Text == "") &&(txtnicno.Text==""))
                {
                    MessageBox.Show("You are not allow to add a new record without Customer ID and NIC no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string insertSQL = "INSERT INTO Customers VALUES('" + txtcustomerid.Text.Trim() + "','" + txtname.Text.Trim() + "','"
                    + txtaddress.Text.Trim() + "','" + txtnicno.Text.Trim() + "','" + txtgender.Text.Trim() + "','" + txtdob.Text.Trim() + "','"
                    + txtemail.Text.Trim() + "','" + txttelno.Text.Trim() + "','" + txtusername.Text.Trim() + "','" + txtpassword.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New record added into the table", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.clear();

                    db.Conn.Close();
                }
            }

            catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
        {
            db.DBConn();
            Fillcustomers();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Customers SET Name='" + txtname.Text.Trim() +
                    "',Address='" + txtaddress.Text.Trim() + "',NIC_No='"
                    + txtnicno.Text.Trim() + "',Gender='" + txtgender.Text.Trim() + "',Date_of_Birth='"
                    + txtdob.Text.Trim() + "', Email='" + txtemail.Text.Trim() + "', Telephone_No='" + txttelno.Text.Trim() + "', Username='" + txtusername.Text.Trim() + "', Password='" + txtpassword.Text.Trim()
                    + "' where Customer_ID='" + txtcustomerid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();

                db.Conn.Close();
            }

            catch(SqlException es )
            {
                MessageBox.Show(es.Message);
            }
        }

        

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Customers WHERE Customer_ID='" + txtsearchid.Text.Trim() + "'";
            
            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcustomerid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtnicno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtgender.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtdob.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtemail.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txttelno.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();
                txtusername.Text = DS.Tables["searchTBL"].Rows[0][8].ToString();
                txtpassword.Text = DS.Tables["searchTBL"].Rows[0][9].ToString();
                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete
            db.Conn.Open();
            string deletesql = "DELETE FROM Customers where Customer_ID='" + txtcustomerid.Text.Trim() + "'";

            DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                sqlCMD.ExecuteNonQuery();
                MessageBox.Show("Record deleted from the table", "Delete");
                this.clear();

            }
            else
            { 
                
            }
            db.Conn.Close();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmbnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Conn.Open();
            string selectid = cmbnames.Text.Trim();

            string searchid = "SELECT * FROM Customers WHERE Customer_ID ='" + selectid + "'";
            try
            {
                DA = new SqlDataAdapter(searchid, db.Conn);

                DataSet selectc = new DataSet();

                DA.Fill(DS, "searchid");

                DA.Fill(selectc, "searchid");

                if (DS.Tables["searchid"].Rows.Count > 0)
                {
                    MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtcustomerid.Text = DS.Tables["searchid"].Rows[0][0].ToString();
                    txtname.Text = DS.Tables["searchid"].Rows[0][1].ToString();
                    txtaddress.Text = DS.Tables["searchid"].Rows[0][2].ToString();
                    txtnicno.Text = DS.Tables["searchid"].Rows[0][3].ToString();
                    txtgender.Text = DS.Tables["searchid"].Rows[0][4].ToString();
                    txtdob.Text = DS.Tables["searchid"].Rows[0][5].ToString();
                    txtemail.Text = DS.Tables["searchid"].Rows[0][6].ToString();
                    txttelno.Text = DS.Tables["searchid"].Rows[0][7].ToString();
                    txtusername.Text = DS.Tables["searchid"].Rows[0][8].ToString();
                    txtpassword.Text = DS.Tables["searchid"].Rows[0][9].ToString();

                    DS.Tables["searchid"].Clear();
                }

                else
                {
                    MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

                db.Conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        }
    }


