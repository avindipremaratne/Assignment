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
    public partial class Suppliers : Form
    {
        Connection db = new Connection();



        SqlDataAdapter DA;
        DataSet DS = new DataSet();
        int rcount;
        int pos = 0;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            db.DBConn();
            Fillsuppliers();
        }

        private void clear()
        {
            txtsupplierid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            
            txttelno.Text = "";
            txtemail.Text = "";
            txtaccountno.Text = "";
            txtbankname.Text = "";

        }

        private void Fillsuppliers()
        {
            String temp = (String)txtsearchname.Text + "%";
            String sql = ("SELECT * FROM Suppliers WHERE Name like '" + temp + "'");
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

        private void btnadd_Click(object sender, EventArgs e)
        {
             //INSERT
           db.Conn.Open();

                string insertSQL = "INSERT INTO Suppliers VALUES('" + txtsupplierid.Text.Trim() + "','" + txtname.Text.Trim() + "','"
                + txtaddress.Text.Trim() + "','" + txttelno.Text.Trim() + "','" + txtemail.Text.Trim() + "','" + txtaccountno.Text.Trim() + "','"
                + txtbankname.Text.Trim()+ "')";

            try
            {                
                //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                sqlCMD.ExecuteNonQuery();               
               
                    MessageBox.Show("New record added into the table", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.clear();

                db.Conn.Close();
            }

            catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Suppliers SET Name='" + txtname.Text.Trim() +
                    "',Address='" + txtaddress.Text.Trim() + "',Telephone_No='"
                    + txttelno.Text.Trim() + "',Email='" + txtemail.Text.Trim() +"', Bank_Account_No='" + txtaccountno.Text.Trim() + "', Bank_Name='" + txtbankname.Text.Trim() + 
                     "' where Supplier_ID='" + txtsupplierid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();

                db.Conn.Close();
            }

            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete
            db.Conn.Open();
            string deletesql = "DELETE FROM Suppliers where Supplier_ID='" + txtsupplierid.Text.Trim() + "'";

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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Suppliers WHERE Supplier_No='" + txtsearchid.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtsupplierid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();                              
                txttelno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtemail.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtaccountno.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtbankname.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }

        private void cmbnames_SelectedIndexChanged(object sender, EventArgs e)
        {
              db.Conn.Open();
            string selectid = cmbnames.Text.Trim();

            string searchid = "SELECT * FROM Suppliers WHERE Supplier_No ='" + selectid + "'";
            try
            {
                DA = new SqlDataAdapter(searchid, db.Conn);

                DataSet selectc = new DataSet();

                DA.Fill(DS, "searchid");

                DA.Fill(selectc, "searchid");

                if (DS.Tables["searchid"].Rows.Count > 0)
                {
                    MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtsupplierid.Text = DS.Tables["searchid"].Rows[0][0].ToString();
                    txtname.Text = DS.Tables["searchid"].Rows[0][1].ToString();
                    txtaddress.Text = DS.Tables["searchid"].Rows[0][2].ToString();
                    txttelno.Text = DS.Tables["searchid"].Rows[0][3].ToString();
                    txtemail.Text = DS.Tables["searchid"].Rows[0][4].ToString();                    
                    txtaccountno.Text = DS.Tables["searchid"].Rows[0][5].ToString();
                    txtbankname.Text = DS.Tables["searchid"].Rows[0][6].ToString();

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
    

