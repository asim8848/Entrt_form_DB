namespace lab6
{
    partial class record
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
            this.lname2 = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.showall = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contactno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warehouseno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warehousename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lname2
            // 
            this.lname2.Location = new System.Drawing.Point(158, 47);
            this.lname2.Name = "lname2";
            this.lname2.Size = new System.Drawing.Size(203, 22);
            this.lname2.TabIndex = 4;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(30, 49);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "Last Name";
            // 
            // showall
            // 
            this.showall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showall.Location = new System.Drawing.Point(608, 42);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(152, 28);
            this.showall.TabIndex = 21;
            this.showall.Text = "Show Record";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(405, 42);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 28);
            this.search.TabIndex = 20;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullname,
            this.Contactno,
            this.Gender,
            this.address,
            this.warehouseno,
            this.warehousename});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1134, 329);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // fullname
            // 
            this.fullname.Text = "Full name";
            this.fullname.Width = 137;
            // 
            // Contactno
            // 
            this.Contactno.Text = "Contact No";
            this.Contactno.Width = 97;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 134;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 124;
            // 
            // warehouseno
            // 
            this.warehouseno.Text = "Wharehouse No";
            this.warehouseno.Width = 156;
            // 
            // warehousename
            // 
            this.warehousename.Text = "Warehouse Name";
            this.warehousename.Width = 200;
            // 
            // record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lname2);
            this.Controls.Add(this.lastname);
            this.Name = "record";
            this.Text = "record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lname2;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader fullname;
        private System.Windows.Forms.ColumnHeader Contactno;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader warehouseno;
        private System.Windows.Forms.ColumnHeader warehousename;
    }
}