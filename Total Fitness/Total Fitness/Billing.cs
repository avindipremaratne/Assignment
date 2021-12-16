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
    public partial class Billing : Form
    {
        Connection db = new Connection();
        SqlDataAdapter DA;
        DataSet DS = new DataSet();
        int rcount;
        int pos = 0;

        int invoiceamount;
        float billamount;
        double totalamount = 0;
        public Billing()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e) {}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}
        private void tbinvoice_Click(object sender, EventArgs e){}

        private void clear()
        {
            cmbselectcustomer.Text = "";
            txtcustomerno.Text = "";
            cmbselectproduct.Text = "";
            txtproductno.Text = "";
            txtprice.Text = "";
            txtqty.Text = "";
            txtamount.Text = "";
        }

        private void customerbill()
        {

            DataSet gridDS = new DataSet();

            string selectAll = "SELECT * FROM ViewBills";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            customerbilldgv.DataSource = gridDS.Tables["selectAll"];

            customerbilldgv.Refresh();

        }
        private void billgrid()
        {
            DataSet gridDS = new DataSet();

            string selectAll = "SELECT *  FROM ItemAdd";

            DA = new SqlDataAdapter(selectAll, db.Conn);

            DA.Fill(gridDS, "selectAll");

            itemadddgv.DataSource = gridDS.Tables["selectAll"];

            itemadddgv.Refresh();
            
            // myDS.Tables["selectAll"].Clear();
        }
        private void FillCustomers()
        {
            String temp = (String)txtcustomerno.Text + "%";
            String sql = ("SELECT DISTINCT Name FROM Customers");
            try
            {

                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLTBL");

                int noofrows = DS.Tables["SelectALLTBL"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbselectcustomer.Items.Add(DS.Tables["SelectALLTBL"].Rows[x][0].ToString());

                }
            }
            catch (SqlException ex)
            {

            }

        }

        private void Fillproducts()
        {
            String temp = (String)txtproductno.Text + "%";
            String sql = ("SELECT * FROM Stocks WHERE Name like '" + temp + "'");
            try
            {

                DA = new SqlDataAdapter(sql, db.Conn);
                DA.Fill(DS, "SelectALLproducts");

                int noofrows = DS.Tables["SelectALLproducts"].Rows.Count - 1;

                for (int x = 0; x <= noofrows; x++)
                {
                    cmbselectproduct.Items.Add(DS.Tables["SelectALLproducts"].Rows[x][1].ToString());
                    //txtprice.Text = (DS.Tables["SelectALLproducts"].Rows[x][4].ToString());
                     
                }
            }
            catch (SqlException ex)
            {

            }

        }

        private void amountcalc()
        {
            try
            {
                int itemprice;
                int itemno;
                int noofitems;


                itemprice = int.Parse(txtprice.Text);
                noofitems = int.Parse(txtqty.Text);


                invoiceamount = itemprice * noofitems;
                txtamount.Text = invoiceamount.ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discount()
        {
            
          

            
        }

        private void totaladd()
        { 
            
        
            for (int i = 0; i < itemadddgv.Rows.Count; ++i)
            {
            totalamount += Convert.ToDouble(itemadddgv.Rows[i].Cells[4].Value);
            }
            txttotalamount.Text = totalamount.ToString();

           
        }

        private void autoproducttotal()
        {

            int autono = 0;
            for (int i = 0; i < itemadddgv.Rows.Count; ++i)
            {
                autono = Convert.ToInt32(itemadddgv.Rows[i].Cells[0].Value);
            }
            txtproductno.Text = autono.ToString(); 

        }

        private void qtyadd()
        {
            int qtytotal = 0;
            for (int i = 0; i < itemadddgv.Rows.Count; ++i)
            {
                qtytotal += Convert.ToInt32(itemadddgv.Rows[i].Cells[3].Value);
            }

            txttotalquantity.Text = qtytotal.ToString();
        }
        
        private void Billing_Load(object sender, EventArgs e)
        {           
            db.DBConn();
            customerbill();        
            Fillproducts();
            discount();
            autoproducttotal();
            
        }

        private void txtamount_MouseClick(object sender, MouseEventArgs e)
        {
            amountcalc();
        }

        private void txtnet_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if ((txtbillno.Text == "") && (cmbselectcustomer.Text == "") )
            {
                MessageBox.Show("INVOICE NO & CUSTOMER ID AND CUSTOMER NAME MUST NEEDED TO PROCEED", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)itemadddgv.Rows[0].Clone();
                row.Cells[0].Value = txtproductno.Text;
                row.Cells[1].Value = cmbselectproduct.Text;
                row.Cells[2].Value = txtprice.Text;
                row.Cells[3].Value = txtqty.Text;
                row.Cells[4].Value = txtamount.Text;
                itemadddgv.Rows.Add(row);
               
                this.totaladd();
                this.qtyadd();

                try
                {
                    db.Conn.Open();
                    string insertitemSQL = "INSERT INTO ItemAdd VALUES(' " + cmbselectproduct.SelectedItem + "','" + txtprice.Text.Trim() + "','" + txtqty.Text.Trim() + "','" + txtamount.Text.Trim() + "')";


                    SqlCommand CMD = new SqlCommand(insertitemSQL, db.Conn);
                    MessageBox.Show(insertitemSQL);
                    CMD.ExecuteNonQuery();

                    MessageBox.Show("NEW ITEM ADDED", "ADDING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    totaladd();
                    qtyadd();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            db.Conn.Close();
        }

        private void txtdiscount_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

             float discount;
             float totalamount1;
             totalamount1 = float.Parse(txttotalamount.Text);

            discount = float.Parse(txtdiscount.Text);
            billamount = totalamount1 - discount;
            txtnet.Text = billamount.ToString();
        }

        private void txtnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string deletesql = "DELETE FROM ItemAdd where Product_Name='" +itemadddgv.SelectedRows+ "'";

                DialogResult = MessageBox.Show("Are you sure to delete this selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    SqlCommand sqlCMD = new SqlCommand(deletesql, db.Conn);
                    sqlCMD.ExecuteNonQuery();
                    MessageBox.Show("Record deleted from the table", "Delete");
                    this.clear();
                    billgrid();
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

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtamountpaid_MouseClick(object sender, MouseEventArgs e)
        {
            
       
    }

        private void txtbalance_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                float totalamount1;
                
                float paid = float.Parse(txtamountpaid.Text);
                totalamount1 = float.Parse(txttotalamount.Text);
                float balance;
                balance = paid - totalamount1;
                txtbalance.Text = balance.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateitemSQL = "Update Itembuy SET Product_Name='" + cmbselectproduct.SelectedItem + "',Price='" + txtprice.Text.Trim() + "',Quantity='" + txtqty.Text.Trim() + "',Amount='" + txtamount.Text.Trim() + "'";
            try
            {
                SqlCommand CMD = new SqlCommand(updateitemSQL, db.Conn); // Command objec 
                CMD.ExecuteNonQuery();
                MessageBox.Show("RECORD UPDATED", "UPDATING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.billgrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                itemadddgv.Rows.RemoveAt(itemadddgv.SelectedCells[0].RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemadddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Selectedrow = e.RowIndex;
                cmbselectproduct.Text = itemadddgv.Rows[Selectedrow].Cells[0].Value.ToString();
                txtproductno.Text = itemadddgv.Rows[Selectedrow].Cells[1].Value.ToString();
                txtprice.Text = itemadddgv.Rows[Selectedrow].Cells[2].Value.ToString();
                txtqty.Text = itemadddgv.Rows[Selectedrow].Cells[3].Value.ToString();
                txtamount.Text = itemadddgv.Rows[Selectedrow].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnregc_Click(object sender, EventArgs e)
        {
            cmbselectcustomer.Items.Clear();
            
            this.FillCustomers();
            cmbselectcustomer.Text = "";
        }

        private void rbtnunregc_Click(object sender, EventArgs e)
        {
            cmbselectcustomer.Items.Clear();
           
            cmbselectcustomer.Text = "";
        }

        private void btnsavebill_Click(object sender, EventArgs e)
        {
            try
            {
                db.Conn.Open();
                string insertbillSQL = "INSERT INTO ViewBills VALUES('" + txtbillno.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "','" + txtcustomerno.Text.Trim() + "','" + cmbselectcustomer.Text.ToString() + "','" + txttotalamount.Text.Trim() + "','" + txtdiscount.Text.Trim() + "','" + txtamountpaid.Text.Trim() + "','" + txtdueamount.Text.Trim() + "')";

                SqlCommand CMD = new SqlCommand(insertbillSQL, db.Conn);  
                CMD.ExecuteNonQuery();
                MessageBox.Show(insertbillSQL);
                MessageBox.Show("BILL SAVED SUCCESSFULLY", "BILLING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db.Conn.Close();
        }

        private void customerbilldgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }

}
