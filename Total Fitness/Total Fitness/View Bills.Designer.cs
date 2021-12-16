namespace Total_Fitness
{
    partial class View_Bills
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
            this.customerbilldgv = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new Total_Fitness.DataSet1();
            this.viewbillsbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerbilldgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbillsbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerbilldgv
            // 
            this.customerbilldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerbilldgv.Location = new System.Drawing.Point(57, 171);
            this.customerbilldgv.Name = "customerbilldgv";
            this.customerbilldgv.Size = new System.Drawing.Size(963, 400);
            this.customerbilldgv.TabIndex = 0;
          
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 693);
            this.Controls.Add(this.customerbilldgv);
            this.Name = "View_Bills";
            this.Text = "View_Bills";
            ((System.ComponentModel.ISupportInitialize)(this.customerbilldgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewbillsbindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerbilldgv;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource viewbillsbindingSource1;
    }
}