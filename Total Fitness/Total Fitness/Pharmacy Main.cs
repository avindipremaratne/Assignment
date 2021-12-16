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
    public partial class Pharmacy_Main : Form
    {
        Connection db = new Connection();
        SqlDataAdapter DA;
        DataSet DS = new DataSet();

        int rcount;
        int pos = 0;
        public Pharmacy_Main()
        {
            InitializeComponent();
        }

        private void dealergrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Dealers ";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            dealersdgv.DataSource = gridDS.Tables["selectAll"];

            dealersdgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }
        private void stockgrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Stocks";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            stockdgv.DataSource = gridDS.Tables["selectAll"];

            stockdgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }

        private void distributiongrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Distribution";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            distributiondgv.DataSource = gridDS.Tables["selectAll"];

            distributiondgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }
        private void suppliergrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Suppliers";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            supplierdgv.DataSource = gridDS.Tables["selectAll"];

            supplierdgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }
        private void Fillstocks()
        {
            String temp = (String)txtsearchsname.Text + "%";
            String sql = ("SELECT * FROM Stocks WHERE Name like '" + temp + "'");
            try
            {

                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLTBL");

                int noofrows = DS.Tables["SelectALLTBL"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbsname.Items.Add(DS.Tables["SelectALLTBL"].Rows[x][0].ToString());
                }
            }
            catch (SqlException ex)
            {

            }

        }      

        private void clearstock()
        {
            txtstockid.Text = "";
            txtsname.Text = "";
            txttype.Text = "";
            txtdosageweight.Text = "";
            txtprice.Text = "";
            txtstockno.Text = "";
            txtmanufacturer.Text = "";
            cmbsupplier.Text = "";

        }
        private void clearsupplier()
        {
            txtsuid.Text = "";
            txtsuname.Text = "";
            txtsuaddress.Text = "";
            txtsutelno.Text = "";
            txtsucontp.Text = "";
            txtsuemail.Text = "";
            txtsuaccno.Text = "";
            txtsubankname.Text = "";

        }
        private void cleardistribution()
        {
            txtdid.Text = "";
            txtddealer.Text = "";
            txtitemd.Text = "";
            txtdtotal.Text = "";
            txtdamountpaid.Text = "";
            txtddue.Text = "";
            txtdistributedate.Text = "";
            txtreceived.Text = "";

        }

        private void Pharmacy_Main_Load(object sender, EventArgs e)
        {
            db.DBConn();
            Fillstocks();
            stockgrid();
            timer1.Start();
            label58.Text = DateTime.Now.ToLongTimeString();   
            dealergrid();
            suppliergrid();
            customergrid();
            distributiongrid();
            Fillcustomers();
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        private void clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txttelno.Text = "";
            txtcontactperson.Text = "";
            txtemail.Text = "";
            txtaccno.Text = "";
            txtbankname.Text = "";

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }
                if ((txtid.Text == "") && (txtname.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without Pharmacist ID and Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Dealers VALUES('" + txtid.Text.Trim() + "','" + txtname.Text.Trim() + "','"
                    + txtaddress.Text.Trim() + "','" + txttelno.Text.Trim() + "','" + txtcontactperson.Text.Trim() + "','" + txtemail.Text.Trim() + "','"
                    + txtaccno.Text.Trim() + "','" + txtbankname.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New Dealer added into the table", "New Pharmacist", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.clear();
                    dealergrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Dealers SET Name='" + txtname.Text.Trim() +
                    "',Address='" + txtaddress.Text.Trim() + "',Telephone_No='"
                    + txttelno.Text.Trim() + "', Contact_Person='" + txtcontactperson.Text.Trim() + "', Email='" + txtemail.Text.Trim() + "',Account_No ='" + txtaccno.Text.Trim() + "', Bank_Name='" + txtbankname.Text.Trim()
                    + "' where Dealer_ID='" + txtid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
                dealergrid();
                db.Conn.Close();
            }

            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void searchid()
        {
            string searchSQL = " SELECT * FROM Dealers WHERE Dealer_ID='" + txtsearch.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txttelno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtcontactperson.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtemail.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtaccno.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txtbankname.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();
                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }

      
        private void btnsearch_Click(object sender, EventArgs e)
        {          
                searchid();           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Dealers where Dealer_ID='" + txtid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clear();
                    dealergrid();

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

        private void btnstockadd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtstockid.Text == "") && (txtname.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without Stock ID and Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Stocks VALUES('" + txtstockid.Text.Trim() + "','" + txtsname.Text.Trim() + "','"
                    + txttype.Text.Trim() + "','" + txtdosageweight.Text.Trim() + "','" + txtprice.Text.Trim() + "','" + txtstockno.Text.Trim() + "','"
                    + txtmanufacturer.Text.Trim() + "','" + cmbsupplier.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New Item  added into the table", "New Item", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    this.clearstock();
                    stockgrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }



        private void cmbsname_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnstocksearch_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Stocks WHERE Stock_ID='" + txtsearchsid.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtstockid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtsname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txttype.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtdosageweight.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtprice.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtstockno.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtmanufacturer.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                cmbsupplier.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();

                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearstock();
            }
        }

        private void btnstockupdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Stocks SET Name='" + txtsname.Text.Trim() +
               "',Type='" + txttype.Text.Trim() + "',Dosage_Weight='"
               + txtdosageweight.Text.Trim() + "',Price='" + txtprice.Text.Trim() + "',Stocks_in_Hand='"
               + txtstockno.Text.Trim() + "', Manufacturer='" + txtmanufacturer.Text.Trim() + "', Supplier='" + cmbsupplier.Text.Trim() + "' where Stock_ID='" + txtstockid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearstock();
                stockgrid();
                db.Conn.Close();
            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e) { }

        private void btnstockdelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Stocks where Stock_ID='" + txtstockid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clearstock();
                    stockgrid();
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

        private void btnstockclear_Click(object sender, EventArgs e)
        {
            this.clearstock();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void customergrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM Customers";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            customerdgv.DataSource = gridDS.Tables["selectAll"];

            customerdgv.Refresh();

            // myDS.Tables["selectAll"].Clear();
        }

        private void Fillcustomers()
        {
            String temp = (String)txtsearchsname.Text + "%";
            String sql = ("SELECT * FROM Customers WHERE Name like '" + temp + "'");
            try
            {

                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLTBL");

                int noofrows = DS.Tables["SelectALLTBL"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbsname.Items.Add(DS.Tables["SelectALLTBL"].Rows[x][0].ToString());
                }


            }
            catch (SqlException ex)
            {

            }

        }

        private void clearcustomers()
        {
            txtcustomerid.Text = "";
            txtcname.Text = "";
            txtcaddress.Text = "";
            txtcnicno.Text = "";
            txtcgender.Text = "";
            txtcdob.Text = "";
            txtcemail.Text = "";
            txtctelno.Text = "";
            txtsearchc.Text = "";
            txtsearchcid.Text = "";
            cmbcnames.Text = "";



        }

        private void textBox13_TextChanged(object sender, EventArgs e) { }

        private void btncadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }
                if ((txtcustomerid.Text == "") && (txtcname.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without Customer ID and Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Customers VALUES('" + txtcustomerid.Text.Trim() + "','" + txtcname.Text.Trim() + "','"
                     + txtcaddress.Text.Trim() + "','" + txtcnicno.Text.Trim() + "','" + txtcgender.Text.Trim() + "','" + txtcdob.Text.Trim() + "','"
                     + txtcemail.Text.Trim() + "','" + txtctelno.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New Customer added into the table", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                    customergrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void supplierdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow = e.RowIndex;

                txtsuid.Text = supplierdgv.Rows[selectedrow].Cells[0].Value.ToString();
                txtsuname.Text = supplierdgv.Rows[selectedrow].Cells[1].Value.ToString();
                txtsuaddress.Text = supplierdgv.Rows[selectedrow].Cells[2].Value.ToString();
                txtsucontp.Text = supplierdgv.Rows[selectedrow].Cells[3].Value.ToString();
                txtsutelno.Text = supplierdgv.Rows[selectedrow].Cells[4].Value.ToString();
                txtsuemail.Text = supplierdgv.Rows[selectedrow].Cells[5].Value.ToString();

                txtsuaccno.Text = supplierdgv.Rows[selectedrow].Cells[6].Value.ToString();
                txtsubankname.Text = supplierdgv.Rows[selectedrow].Cells[7].Value.ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnaddsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }
                if ((txtsuid.Text == "") && (txtsuname.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without Supplier ID and Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Suppliers VALUES('" + txtsuid.Text.Trim() + "','" + txtsuname.Text.Trim() + "','"
                    + txtsuaddress.Text.Trim() + "','" + txttelno.Text.Trim() + "','" + txtsucontp.Text.Trim() + "','" + txtemail.Text.Trim() + "','"
                    + txtaccno.Text.Trim() + "','" + txtbankname.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New Supplier added into the table", "New Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.clear();
                    suppliergrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnsuupdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Suppliers SET Name='" + txtsuname.Text.Trim() +
                    "',Address='" + txtsuaddress.Text.Trim() + "',Telephone_No='"
                    + txtsutelno.Text.Trim() + "', Contact_Person='" + txtsucontp.Text.Trim() + "', Email='" + txtsuemail.Text.Trim() + "',Account_No ='" + txtsuaccno.Text.Trim() + "', Bank_Name='" + txtsubankname.Text.Trim()
                    + "' where Supplier_ID='" + txtsuid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearsupplier();
                suppliergrid();
                db.Conn.Close();
            }

            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnsudelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Suppliers where Supplier_ID='" + txtsuid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clear();
                    suppliergrid();
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

        private void tbsuppliers_Enter(object sender, EventArgs e){ }

        private void supplierdgv_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void supplierdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dealersdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow = e.RowIndex;
                txtid.Text = dealersdgv.Rows[selectedrow].Cells[0].Value.ToString();
                txtname.Text = dealersdgv.Rows[selectedrow].Cells[1].Value.ToString();
                txtaddress.Text = dealersdgv.Rows[selectedrow].Cells[2].Value.ToString();
                txtcontactperson.Text = dealersdgv.Rows[selectedrow].Cells[3].Value.ToString();
                txttelno.Text = dealersdgv.Rows[selectedrow].Cells[4].Value.ToString();
                txtemail.Text = dealersdgv.Rows[selectedrow].Cells[5].Value.ToString();

                txtaccno.Text = dealersdgv.Rows[selectedrow].Cells[6].Value.ToString();
                txtbankname.Text = dealersdgv.Rows[selectedrow].Cells[7].Value.ToString();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }


        private void customerdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow = e.RowIndex;
                txtcustomerid.Text = customerdgv.Rows[selectedrow].Cells[0].Value.ToString();
                txtcname.Text = customerdgv.Rows[selectedrow].Cells[1].Value.ToString();
                txtcaddress.Text = customerdgv.Rows[selectedrow].Cells[2].Value.ToString();
                txtcnicno.Text = customerdgv.Rows[selectedrow].Cells[3].Value.ToString();
                txtcgender.Text = customerdgv.Rows[selectedrow].Cells[4].Value.ToString();
                txtcdob.Text = customerdgv.Rows[selectedrow].Cells[5].Value.ToString();
                txtcemail.Text = customerdgv.Rows[selectedrow].Cells[6].Value.ToString();
                txtctelno.Text = customerdgv.Rows[selectedrow].Cells[7].Value.ToString();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void stockdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow = e.RowIndex;
                txtstockid.Text = stockdgv.Rows[selectedrow].Cells[0].Value.ToString();
                txtsname.Text = stockdgv.Rows[selectedrow].Cells[1].Value.ToString();
                txttype.Text = stockdgv.Rows[selectedrow].Cells[2].Value.ToString();
                txtdosageweight.Text = stockdgv.Rows[selectedrow].Cells[3].Value.ToString();
                txtprice.Text = stockdgv.Rows[selectedrow].Cells[4].Value.ToString();
                txtstockno.Text = stockdgv.Rows[selectedrow].Cells[5].Value.ToString();
                txtmanufacturer.Text = stockdgv.Rows[selectedrow].Cells[6].Value.ToString();
                cmbsupplier.SelectedText = stockdgv.Rows[selectedrow].Cells[7].Value.ToString();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void icouserconf_Click(object sender, EventArgs e)
        {

        }

        private void linkuserconf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkuserconf_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacytabControl.SelectedTab = tbstocks;
        }

        private void icouserconf_Click_1(object sender, EventArgs e)
        {
            pharmacytabControl.SelectedTab = tbstocks;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacytabControl.SelectedTab = tbdealers;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pharmacytabControl.SelectedTab = tbdealers;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacytabControl.SelectedTab = tbdistribution;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pharmacytabControl.SelectedTab = tbdistribution;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacytabControl.SelectedTab = tbcustomer;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pharmacytabControl.SelectedTab = tbcustomer;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pharmacytabControl.SelectedTab = tbsuppliers;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pharmacytabControl.SelectedTab = tbsuppliers;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label58.Text = DateTime.Now.ToLongTimeString();
            label57.Text = DateTime.Now.ToLongDateString();
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Customers SET Name='" + txtcname.Text.Trim() +
                    "',Address='" + txtcaddress.Text.Trim() + "',NIC_NO='"
                    + txtcnicno.Text.Trim() + "', Gender='" + txtcgender.Text.Trim() + "', Date_of_Birth='" + txtcdob.Text.Trim() + "',Email ='" + txtcemail.Text.Trim() + "', Telephone_No='" + txtctelno.Text.Trim()
                    + "' where Customer_ID='" + txtcustomerid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clearcustomers();
                customergrid();
                db.Conn.Close();
            }

            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btncclear_Click(object sender, EventArgs e)
        {
            clearcustomers();
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Customers where Customer_ID='" + txtcustomerid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clearcustomers();
                    customergrid();
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

        private void btncsearch_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Customers WHERE Customer_ID='" + txtsearchcid.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcustomerid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtcname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtcaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtcnicno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtcgender.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtcdob.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtcemail.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txtctelno.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();
                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Suppliers WHERE Suppliers_ID='" + txtssearchid.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtsuid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtsuname.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtsuaddress.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtsutelno.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtsucontp.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtsuemail.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtsuaccno.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txtsubankname.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();


                DS.Tables["searchTBL"].Clear();
            }

            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.Conn.State == ConnectionState.Open)
                {
                    db.Conn.Close();
                }
                if ((txtdid.Text == "") && (txtddealer.Text == ""))
                {
                    MessageBox.Show("You are not allow to add a new record without Distribution ID and Dealer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    db.Conn.Open();

                    string insertSQL = "INSERT INTO Distribution VALUES('" + txtdid.Text.Trim() + "','" + txtddealer.Text.Trim() + "','"
                    + txtitemd.Text.Trim() + "','" + txtdtotal.Text.Trim() + "','" + txtdamountpaid.Text.Trim() + "','" + txtddue.Text.Trim() + "','"
                    + txtdistributedate.Text.Trim() + "','" + txtreceived.Text.Trim() + "')";

                    //by writting and assigning SQL statement in to the string variable we can easily check the SQL statement for the errors.

                    SqlCommand sqlCMD = new SqlCommand(insertSQL, db.Conn);

                    //command object is used to execute por SQL statement on the top of the database. This object required sql statement and connection as parameters.

                    sqlCMD.ExecuteNonQuery();

                    MessageBox.Show("New Distribution detail added into the table", "New Distribution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cleardistribution();
                    distributiongrid();
                    db.Conn.Close();
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();

                string updateSQL = "UPDATE Distribution SET Dealer='" + txtddealer.Text.Trim() +
                    "',Item_Distributed='" + txtitemd.Text.Trim() + "',Total_Amount='"
                    + txtdtotal.Text.Trim() + "', Amount_Paid='" + txtdamountpaid.Text.Trim() + "', Due_Amount='" + txtddue.Text.Trim() + "',Distributed_Date ='" + txtdistributedate.Text.Trim() + "', Received_Date='" + txtreceived.Text.Trim()
                    + "' where Distribution_ID='" + txtdid.Text.Trim() + "'";

                SqlCommand sqlCMD = new SqlCommand(updateSQL, db.Conn);

                sqlCMD.ExecuteNonQuery();

                MessageBox.Show("Selected Recorded updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cleardistribution();
                distributiongrid();
                db.Conn.Close();
            }

            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleardistribution();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM Distribution where Distribution_ID='" + txtdid.Text.Trim() + "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.cleardistribution();
                    distributiongrid();
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

        private void distributiondgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow = e.RowIndex;
                txtdid.Text = distributiondgv.Rows[selectedrow].Cells[0].Value.ToString();
                txtddealer.Text = distributiondgv.Rows[selectedrow].Cells[1].Value.ToString();
                txtitemd.Text = distributiondgv.Rows[selectedrow].Cells[2].Value.ToString();
                txtdtotal.Text = distributiondgv.Rows[selectedrow].Cells[3].Value.ToString();
                txtdamountpaid.Text = distributiondgv.Rows[selectedrow].Cells[4].Value.ToString();
                txtddue.Text = distributiondgv.Rows[selectedrow].Cells[5].Value.ToString();
                txtdistributedate.Text = distributiondgv.Rows[selectedrow].Cells[6].Value.ToString();
                txtreceived.Text = distributiondgv.Rows[selectedrow].Cells[7].Value.ToString();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string searchSQL = " SELECT * FROM Distribution WHERE Distribution_ID='" + textBox18.Text.Trim() + "'";

            DA = new SqlDataAdapter(searchSQL, db.Conn);
            DA.Fill(DS, "searchTBL");

            if (DS.Tables["searchTBL"].Rows.Count > 0)
            {
                MessageBox.Show("Record Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdid.Text = DS.Tables["searchTBL"].Rows[0][0].ToString();
                txtddealer.Text = DS.Tables["searchTBL"].Rows[0][1].ToString();
                txtitemd.Text = DS.Tables["searchTBL"].Rows[0][2].ToString();
                txtdtotal.Text = DS.Tables["searchTBL"].Rows[0][3].ToString();
                txtdamountpaid.Text = DS.Tables["searchTBL"].Rows[0][4].ToString();
                txtddue.Text = DS.Tables["searchTBL"].Rows[0][5].ToString();
                txtdistributedate.Text = DS.Tables["searchTBL"].Rows[0][6].ToString();
                txtreceived.Text = DS.Tables["searchTBL"].Rows[0][7].ToString();
                DS.Tables["searchTBL"].Clear();
            }
            else
            {
                MessageBox.Show("Record Not Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
        }
    }
}