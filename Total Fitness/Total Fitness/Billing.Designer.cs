namespace Total_Fitness
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbinvoice = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdueamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txttotalquantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txttotalproducts = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbselectproduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductno = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.itemadddgv = new System.Windows.Forms.DataGridView();
            this.cmbselectcustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustomerno = new System.Windows.Forms.TextBox();
            this.rbtnunregc = new System.Windows.Forms.RadioButton();
            this.rbtnregc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.tbbills = new System.Windows.Forms.TabPage();
            this.dataSet11 = new Total_Fitness.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsavebill = new System.Windows.Forms.Button();
            this.BillingbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbviewbills = new System.Windows.Forms.TabPage();
            this.customerbilldgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbinvoice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.btncalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemadddgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingbindingSource1)).BeginInit();
            this.tbviewbills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerbilldgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbinvoice);
            this.tabControl1.Controls.Add(this.tbbills);
            this.tabControl1.Controls.Add(this.tbviewbills);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 732);
            this.tabControl1.TabIndex = 0;
            // 
            // tbinvoice
            // 
            this.tbinvoice.Controls.Add(this.groupBox2);
            this.tbinvoice.Controls.Add(this.btncalculate);
            this.tbinvoice.Controls.Add(this.dateTimePicker1);
            this.tbinvoice.Controls.Add(this.label3);
            this.tbinvoice.Controls.Add(this.itemadddgv);
            this.tbinvoice.Controls.Add(this.cmbselectcustomer);
            this.tbinvoice.Controls.Add(this.label2);
            this.tbinvoice.Controls.Add(this.txtcustomerno);
            this.tbinvoice.Controls.Add(this.rbtnunregc);
            this.tbinvoice.Controls.Add(this.rbtnregc);
            this.tbinvoice.Controls.Add(this.label1);
            this.tbinvoice.Controls.Add(this.txtbillno);
            this.tbinvoice.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbinvoice.Location = new System.Drawing.Point(4, 31);
            this.tbinvoice.Name = "tbinvoice";
            this.tbinvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tbinvoice.Size = new System.Drawing.Size(1362, 697);
            this.tbinvoice.TabIndex = 0;
            this.tbinvoice.Text = "Invoice";
            this.tbinvoice.UseVisualStyleBackColor = true;
            this.tbinvoice.Click += new System.EventHandler(this.tbinvoice_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1176, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsavebill);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtdueamount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtamountpaid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtnet);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtbalance);
            this.groupBox2.Controls.Add(this.txttotalquantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txttotalamount);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txttotalproducts);
            this.groupBox2.Location = new System.Drawing.Point(57, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 121);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(910, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 22);
            this.label16.TabIndex = 29;
            this.label16.Text = "Balance";
            // 
            // txtdueamount
            // 
            this.txtdueamount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdueamount.Location = new System.Drawing.Point(1011, 82);
            this.txtdueamount.Name = "txtdueamount";
            this.txtdueamount.Size = new System.Drawing.Size(156, 26);
            this.txtdueamount.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(641, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "Net";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountpaid.Location = new System.Drawing.Point(748, 78);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(156, 26);
            this.txtamountpaid.TabIndex = 21;
            this.txtamountpaid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtamountpaid_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(891, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Balance";
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.Location = new System.Drawing.Point(710, 36);
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(156, 26);
            this.txtnet.TabIndex = 26;
            this.txtnet.TextChanged += new System.EventHandler(this.txtnet_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(641, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Amount Paid";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(992, 33);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(156, 26);
            this.txtbalance.TabIndex = 17;
            this.txtbalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbalance_MouseClick);
            // 
            // txttotalquantity
            // 
            this.txttotalquantity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalquantity.Location = new System.Drawing.Point(165, 83);
            this.txttotalquantity.Name = "txttotalquantity";
            this.txttotalquantity.Size = new System.Drawing.Size(156, 26);
            this.txttotalquantity.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(476, 78);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(156, 26);
            this.txtdiscount.TabIndex = 19;
            this.txtdiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiscount_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 22);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total Amount";
            // 
            // txttotalamount
            // 
            this.txttotalamount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamount.Location = new System.Drawing.Point(476, 36);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(156, 26);
            this.txttotalamount.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Total Products";
            // 
            // txttotalproducts
            // 
            this.txttotalproducts.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalproducts.Location = new System.Drawing.Point(165, 32);
            this.txttotalproducts.Name = "txttotalproducts";
            this.txttotalproducts.Size = new System.Drawing.Size(156, 26);
            this.txttotalproducts.TabIndex = 2;
            // 
            // btncalculate
            // 
            this.btncalculate.Controls.Add(this.button2);
            this.btncalculate.Controls.Add(this.btndelete);
            this.btncalculate.Controls.Add(this.btnupdate);
            this.btncalculate.Controls.Add(this.btnadd);
            this.btncalculate.Controls.Add(this.label8);
            this.btncalculate.Controls.Add(this.txtamount);
            this.btncalculate.Controls.Add(this.label7);
            this.btncalculate.Controls.Add(this.txtqty);
            this.btncalculate.Controls.Add(this.label6);
            this.btncalculate.Controls.Add(this.txtprice);
            this.btncalculate.Controls.Add(this.label5);
            this.btncalculate.Controls.Add(this.cmbselectproduct);
            this.btncalculate.Controls.Add(this.label4);
            this.btncalculate.Controls.Add(this.txtproductno);
            this.btncalculate.Location = new System.Drawing.Point(57, 102);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(1244, 144);
            this.btncalculate.TabIndex = 10;
            this.btncalculate.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(799, 83);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 34);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(924, 83);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 34);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(666, 83);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(80, 34);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(657, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(763, 30);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(156, 26);
            this.txtamount.TabIndex = 17;
            this.txtamount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtamount_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantity";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(456, 83);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(156, 26);
            this.txtqty.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(456, 33);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(156, 26);
            this.txtprice.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select Product";
            // 
            // cmbselectproduct
            // 
            this.cmbselectproduct.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselectproduct.FormattingEnabled = true;
            this.cmbselectproduct.Location = new System.Drawing.Point(165, 81);
            this.cmbselectproduct.Name = "cmbselectproduct";
            this.cmbselectproduct.Size = new System.Drawing.Size(156, 28);
            this.cmbselectproduct.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            // 
            // txtproductno
            // 
            this.txtproductno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductno.Location = new System.Drawing.Point(165, 32);
            this.txtproductno.Name = "txtproductno";
            this.txtproductno.Size = new System.Drawing.Size(156, 26);
            this.txtproductno.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1049, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Customer ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // itemadddgv
            // 
            this.itemadddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemadddgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.itemadddgv.Location = new System.Drawing.Point(51, 252);
            this.itemadddgv.Name = "itemadddgv";
            this.itemadddgv.Size = new System.Drawing.Size(1298, 270);
            this.itemadddgv.TabIndex = 9;
            this.itemadddgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemadddgv_CellClick);
            // 
            // cmbselectcustomer
            // 
            this.cmbselectcustomer.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselectcustomer.FormattingEnabled = true;
            this.cmbselectcustomer.Location = new System.Drawing.Point(843, 71);
            this.cmbselectcustomer.Name = "cmbselectcustomer";
            this.cmbselectcustomer.Size = new System.Drawing.Size(156, 28);
            this.cmbselectcustomer.TabIndex = 6;
            this.cmbselectcustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name";
            // 
            // txtcustomerno
            // 
            this.txtcustomerno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerno.Location = new System.Drawing.Point(843, 25);
            this.txtcustomerno.Name = "txtcustomerno";
            this.txtcustomerno.Size = new System.Drawing.Size(156, 26);
            this.txtcustomerno.TabIndex = 4;
            // 
            // rbtnunregc
            // 
            this.rbtnunregc.AutoSize = true;
            this.rbtnunregc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnunregc.Location = new System.Drawing.Point(407, 61);
            this.rbtnunregc.Name = "rbtnunregc";
            this.rbtnunregc.Size = new System.Drawing.Size(202, 26);
            this.rbtnunregc.TabIndex = 3;
            this.rbtnunregc.TabStop = true;
            this.rbtnunregc.Text = "Unregistered Customer";
            this.rbtnunregc.UseVisualStyleBackColor = true;
            this.rbtnunregc.Click += new System.EventHandler(this.rbtnunregc_Click);
            // 
            // rbtnregc
            // 
            this.rbtnregc.AutoSize = true;
            this.rbtnregc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnregc.Location = new System.Drawing.Point(407, 29);
            this.rbtnregc.Name = "rbtnregc";
            this.rbtnregc.Size = new System.Drawing.Size(185, 26);
            this.rbtnregc.TabIndex = 2;
            this.rbtnregc.TabStop = true;
            this.rbtnregc.Text = "Registered Customer";
            this.rbtnregc.UseVisualStyleBackColor = true;
            this.rbtnregc.Click += new System.EventHandler(this.rbtnregc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill No.";
            // 
            // txtbillno
            // 
            this.txtbillno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillno.Location = new System.Drawing.Point(202, 34);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.Size = new System.Drawing.Size(156, 26);
            this.txtbillno.TabIndex = 0;
            // 
            // tbbills
            // 
            this.tbbills.Location = new System.Drawing.Point(4, 31);
            this.tbbills.Name = "tbbills";
            this.tbbills.Padding = new System.Windows.Forms.Padding(3);
            this.tbbills.Size = new System.Drawing.Size(1362, 697);
            this.tbbills.TabIndex = 1;
            this.tbbills.Text = "Purchase Bills";
            this.tbbills.UseVisualStyleBackColor = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(976, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount";
            this.Column5.Name = "Column5";
            // 
            // btnsavebill
            // 
            this.btnsavebill.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavebill.Location = new System.Drawing.Point(1176, 77);
            this.btnsavebill.Name = "btnsavebill";
            this.btnsavebill.Size = new System.Drawing.Size(102, 33);
            this.btnsavebill.TabIndex = 30;
            this.btnsavebill.Text = "Save";
            this.btnsavebill.UseVisualStyleBackColor = true;
            this.btnsavebill.Click += new System.EventHandler(this.btnsavebill_Click);
            // 
            // tbviewbills
            // 
            this.tbviewbills.Controls.Add(this.customerbilldgv);
            this.tbviewbills.Location = new System.Drawing.Point(4, 31);
            this.tbviewbills.Name = "tbviewbills";
            this.tbviewbills.Size = new System.Drawing.Size(1362, 697);
            this.tbviewbills.TabIndex = 2;
            this.tbviewbills.Text = "View Bills";
            this.tbviewbills.UseVisualStyleBackColor = true;
            // 
            // customerbilldgv
            // 
            this.customerbilldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerbilldgv.Location = new System.Drawing.Point(78, 132);
            this.customerbilldgv.Name = "customerbilldgv";
            this.customerbilldgv.Size = new System.Drawing.Size(1155, 355);
            this.customerbilldgv.TabIndex = 0;
            this.customerbilldgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerbilldgv_CellContentClick);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 693);
            this.Controls.Add(this.tabControl1);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbinvoice.ResumeLayout(false);
            this.tbinvoice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.btncalculate.ResumeLayout(false);
            this.btncalculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemadddgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingbindingSource1)).EndInit();
            this.tbviewbills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerbilldgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbinvoice;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbselectcustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustomerno;
        private System.Windows.Forms.GroupBox btncalculate;
        private System.Windows.Forms.DataGridView itemadddgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproductno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbselectproduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotalquantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttotalproducts;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtamountpaid;
        private System.Windows.Forms.RadioButton rbtnunregc;
        private System.Windows.Forms.RadioButton rbtnregc;
        private System.Windows.Forms.TabPage tbbills;
        private System.Windows.Forms.BindingSource BillingbindingSource1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdueamount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnsavebill;
        private System.Windows.Forms.TabPage tbviewbills;
        private System.Windows.Forms.DataGridView customerbilldgv;
    }
}