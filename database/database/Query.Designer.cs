namespace database
{
    partial class Query
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
            this.bank_SystemDataSet = new database.Bank_SystemDataSet();
            this.bankSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new database.Bank_SystemDataSetTableAdapters.ADMINTableAdapter();
            this.bankSystemDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bank_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_SystemDataSet
            // 
            this.bank_SystemDataSet.DataSetName = "Bank_SystemDataSet";
            this.bank_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankSystemDataSetBindingSource
            // 
            this.bankSystemDataSetBindingSource.DataSource = this.bank_SystemDataSet;
            this.bankSystemDataSetBindingSource.Position = 0;
            // 
            // bankSystemDataSetBindingSource1
            // 
            this.bankSystemDataSetBindingSource1.DataSource = this.bank_SystemDataSet;
            this.bankSystemDataSetBindingSource1.Position = 0;
            // 
            // bankSystemDataSetBindingSource2
            // 
            this.bankSystemDataSetBindingSource2.DataSource = this.bank_SystemDataSet;
            this.bankSystemDataSetBindingSource2.Position = 0;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.bankSystemDataSetBindingSource2;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // bankSystemDataSetBindingSource3
            // 
            this.bankSystemDataSetBindingSource3.DataSource = this.bank_SystemDataSet;
            this.bankSystemDataSetBindingSource3.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(117, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(271, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 241);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(117, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::database.Properties.Resources.WhatsApp_Image_2022_05_30_at_10_21_18_PM__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private Bank_SystemDataSet bank_SystemDataSet;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource2;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource1;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private Bank_SystemDataSetTableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button6;
    }
}