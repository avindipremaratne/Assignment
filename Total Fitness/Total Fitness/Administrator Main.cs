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
    public partial class Administrator_Main : Form
    {
        Connection db = new Connection();
        


        SqlDataAdapter DA;
        DataSet DS = new DataSet();
        int rcount;
        int pos = 0;
        public Administrator_Main()
        {
            InitializeComponent();
        }

        private void usergrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Users";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            dgv.DataSource = gridDS.Tables["selectAll"];

            dgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }

       
        private void Fillcustomers()
        {
            String temp = (String)txtsearchname.Text + "%";
            String sql = ("SELECT * FROM Customers WHERE Name like '" + temp + "'");
            try
            {

                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLTBL");

                int noofrows = DS.Tables["SelectALLTBL"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbname.Items.Add(DS.Tables["SelectALLTBL"].Rows[x][0].ToString());
                }


            }
            catch (SqlException ex)
            {

            }

        }

        private void user()
        {
           

        }
        private void clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtnicno.Text = "";
            txtgender.Text = "";
            txtdob.Text = "";
            txtemail.Text = "";
            txttelno.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            cmbname.Text = "";
            txtusertype.Text = "";
            


        }

        private void adminadd()
        {
            //Administrator inserting users

          
        }

        
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }
                if ((txtid.Text == "") && (txtnicno.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without User ID and Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Users VALUES(' " + txtid.Text.Trim() + " ',' " + txtname.Text.Trim() + " ',' "
                    + txtaddress.Text.Trim() + " ',' " + txtnicno.Text.Trim() + " ',' " + txtgender.Text.Trim() + " ',' " + txtdob.Text.Trim() + " ',' "
                    + txtemail.Text.Trim() + " ',' " + txttelno.Text.Trim() + " ',' " + txtusername.Text.Trim() + " ',' " + txtpassword.Text.Trim()
                    +" ',' "+txtusertype.Text.Trim()+ " ')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New user added into the table", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                    usergrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
          
        }
        private void tbcreateuser_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        public void cmbnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Conn.Open();
            string selectid = cmbname.Text.Trim();

            string searchid = "SELECT * FROM Users WHERE User_ID ='" + selectid + "'";
            try
            {
                DA = new SqlDataAdapter(searchid, db.Conn);

                DataSet selectc = new DataSet();

                DA.Fill(DS, "searchid");

                DA.Fill(selectc, "searchid");

                if (DS.Tables["searchid"].Rows.Count > 0)
                {
                    MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtid.Text = DS.Tables["searchid"].Rows[0][0].ToString();
                    txtname.Text = DS.Tables["searchid"].Rows[0][1].ToString();
                    txtaddress.Text = DS.Tables["searchid"].Rows[0][2].ToString();
                    txtnicno.Text = DS.Tables["searchid"].Rows[0][3].ToString();
                    txtgender.Text = DS.Tables["searchid"].Rows[0][4].ToString();
                    txtdob.Text = DS.Tables["searchid"].Rows[0][5].ToString();
                    txtemail.Text = DS.Tables["searchid"].Rows[0][6].ToString();
                    txttelno.Text = DS.Tables["searchid"].Rows[0][7].ToString();
                    txtusername.Text = DS.Tables["searchid"].Rows[0][8].ToString();
                    txtpassword.Text = DS.Tables["searchid"].Rows[0][9].ToString();
                    txtusertype.Text = DS.Tables["searchid"].Rows[0][10].ToString();

                    DS.Tables["searchid"].Clear();
                }

                else
                {
                    MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                }

                db.Conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void searchadmin()
        {
            string searchSQL = " SELECT * FROM Users WHERE User_ID='" + txtsearchid.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtnicno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtgender.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtdob.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtemail.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txttelno.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();
                txtusername.Text = DS.Tables["searchTBL"].Rows[0][8].ToString();
                txtpassword.Text = DS.Tables["searchTBL"].Rows[0][9].ToString();
               txtusertype.Text = DS.Tables["searchTBL"].Rows[0][10].ToString();
                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }
       
        public void btnsearch_Click(object sender, EventArgs e)
        {
            int usertype = cmbsearchtype.SelectedIndex;
            if (usertype == 0)
            {
                searchadmin();
            }
            else if (usertype == 1)
            {
                //searchpharmacist();
            }
        }

        private void tbcreateuser_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Administrator_Main_Load(object sender, EventArgs e)
        {
            
            db.DBConn();
            Fillcustomers();
            usergrid();           
            timet.Start();
            label13.Text = DateTime.Now.ToLongTimeString();       
                       
        }
        //label17.Text = Connection.username;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }

                db.Conn.Open();

                string updateSQL = "UPDATE Users SET Name=' " + txtname.Text.Trim() +
                    " ',Address=' " + txtaddress.Text.Trim() + " ',NIC_No=' "
                    + txtnicno.Text.Trim() + " ',Gender=' " + txtgender.Text.Trim() + " ',Date_of_Birth=' "
                    + txtdob.Text.Trim() + " ', Email=' " + txtemail.Text.Trim() + " ', Telephone_No=' " + txttelno.Text.Trim() +
                    " ', Username=' " + txtusername.Text.Trim() + " ', Password=' " + txtpassword.Text.Trim() + " ', User_Type=' " + txtusertype.Text.Trim()
                   + " ' where User_ID='" + txtid.Text.Trim() + " ' ";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
                usergrid();
                db.Conn.Close();
            }


            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
            }
        

       
        

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Users where User_ID='" + txtid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clear();
                    usergrid();

                }
                else
                {

                }
                db.Conn.Close();
            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tbcreateuser;
        }

        private void icouserconf_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbcreateuser;
        }

        private void linkuserconf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tbcreateuser;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrow = e.RowIndex;

            txtid.Text = dgv.Rows[selectedrow].Cells[0].Value.ToString();
            txtname.Text = dgv.Rows[selectedrow].Cells[1].Value.ToString();
            txtaddress.Text = dgv.Rows[selectedrow].Cells[2].Value.ToString();
            txtnicno.Text = dgv.Rows[selectedrow].Cells[3].Value.ToString();
            txtgender.Text =dgv.Rows[selectedrow].Cells[4].Value.ToString();
            txtdob.Text = dgv.Rows[selectedrow].Cells[5].Value.ToString();
            txtemail.Text = dgv.Rows[selectedrow].Cells[6].Value.ToString();
            txttelno.Text = dgv.Rows[selectedrow].Cells[7].Value.ToString();
            txtusername.Text = dgv.Rows[selectedrow].Cells[8].Value.ToString();
            txtpassword.Text = dgv.Rows[selectedrow].Cells[9].Value.ToString();
            txtusertype.Text = dgv.Rows[selectedrow].Cells[10].Value.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
          //  Brush BackBrush = new Brush(Color.Transparent);

        }

        private void timet_Tick(object sender, EventArgs e)
        {
            timet.Start();
            label13.Text = DateTime.Now.ToLongTimeString();
            label17.Text = DateTime.Now.ToLongDateString();
        }

        private void tbstocks_Click(object sender, EventArgs e)
        {
            Pharmacy_Main Pharmacy = new Pharmacy_Main();
              Pharmacy.Show();
              Pharmacy.tbstocks.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pharmacy_Main pharmacy = new Pharmacy_Main();
            pharmacy.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pharmacy_Main pharmacy = new Pharmacy_Main();
            pharmacy.Show();
        }

        
    }
    }



