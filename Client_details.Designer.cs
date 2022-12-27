namespace TJ_Lanka_PLC_PLM
{
    partial class Client_details
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
            this.ClientDetails = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ClientNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.ContactTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.DGVclient = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ToOrderPageBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.CompanyTxtBox = new System.Windows.Forms.ComboBox();
            this.SearchBrandTxtbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclient)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientDetails
            // 
            this.ClientDetails.AutoSize = true;
            this.ClientDetails.Location = new System.Drawing.Point(358, 14);
            this.ClientDetails.Name = "ClientDetails";
            this.ClientDetails.Size = new System.Drawing.Size(88, 14);
            this.ClientDetails.TabIndex = 0;
            this.ClientDetails.Text = "Client Details";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(63, 51);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(81, 14);
            this.ClientName.TabIndex = 1;
            this.ClientName.Text = "Client Name";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(437, 51);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(41, 14);
            this.Brand.TabIndex = 2;
            this.Brand.Text = "Brand";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(63, 90);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(55, 14);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(437, 90);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(52, 14);
            this.Contact.TabIndex = 4;
            this.Contact.Text = "Contact";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(63, 129);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(40, 14);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // ClientNameTxtBox
            // 
            this.ClientNameTxtBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTxtBox.Location = new System.Drawing.Point(160, 51);
            this.ClientNameTxtBox.Name = "ClientNameTxtBox";
            this.ClientNameTxtBox.Size = new System.Drawing.Size(180, 23);
            this.ClientNameTxtBox.TabIndex = 6;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtBox.Location = new System.Drawing.Point(160, 90);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(180, 23);
            this.AddressTxtBox.TabIndex = 8;
            // 
            // ContactTxtBox
            // 
            this.ContactTxtBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTxtBox.Location = new System.Drawing.Point(550, 90);
            this.ContactTxtBox.Name = "ContactTxtBox";
            this.ContactTxtBox.Size = new System.Drawing.Size(180, 23);
            this.ContactTxtBox.TabIndex = 9;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.Location = new System.Drawing.Point(160, 129);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(180, 23);
            this.EmailTxtBox.TabIndex = 10;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(658, 132);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(72, 30);
            this.SubmitBtn.TabIndex = 11;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click_1);
            // 
            // DGVclient
            // 
            this.DGVclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclient.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVclient.Location = new System.Drawing.Point(76, 216);
            this.DGVclient.Name = "DGVclient";
            this.DGVclient.Size = new System.Drawing.Size(644, 208);
            this.DGVclient.TabIndex = 12;
            this.DGVclient.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVclient_CellMouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteClientToolStripMenuItem,
            this.editClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editClientToolStripMenuItem.Text = "Edit Client";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.editClientToolStripMenuItem_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(66, 178);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(72, 30);
            this.newBtn.TabIndex = 13;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(66, 435);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(72, 30);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ToOrderPageBtn
            // 
            this.ToOrderPageBtn.Location = new System.Drawing.Point(622, 435);
            this.ToOrderPageBtn.Name = "ToOrderPageBtn";
            this.ToOrderPageBtn.Size = new System.Drawing.Size(108, 30);
            this.ToOrderPageBtn.TabIndex = 17;
            this.ToOrderPageBtn.Text = "To Order Page";
            this.ToOrderPageBtn.UseVisualStyleBackColor = true;
            this.ToOrderPageBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(550, 132);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(74, 30);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // CompanyTxtBox
            // 
            this.CompanyTxtBox.FormattingEnabled = true;
            this.CompanyTxtBox.Items.AddRange(new object[] {
            "ADIDAS",
            "AMAZON",
            "AMBRA",
            "ANN TAYLOR",
            "AMERICAN EAGLE",
            "ADITYA BIRLA",
            "A&F(LOCAL MARKET)",
            "SAXX2XIST"});
            this.CompanyTxtBox.Location = new System.Drawing.Point(550, 48);
            this.CompanyTxtBox.Name = "CompanyTxtBox";
            this.CompanyTxtBox.Size = new System.Drawing.Size(180, 22);
            this.CompanyTxtBox.TabIndex = 20;
            // 
            // SearchBrandTxtbox
            // 
            this.SearchBrandTxtbox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBrandTxtbox.FormattingEnabled = true;
            this.SearchBrandTxtbox.Items.AddRange(new object[] {
            "ADIDAS",
            "AMAZON",
            "AMBRA",
            "ANN TAYLOR",
            "AMERICAN EAGLE",
            "ADITYA BIRLA",
            "A&F(LOCAL MARKET)",
            "SAXX2XIST"});
            this.SearchBrandTxtbox.Location = new System.Drawing.Point(550, 183);
            this.SearchBrandTxtbox.Name = "SearchBrandTxtbox";
            this.SearchBrandTxtbox.Size = new System.Drawing.Size(180, 22);
            this.SearchBrandTxtbox.TabIndex = 21;
            this.SearchBrandTxtbox.Text = "Search By Brand";
            this.SearchBrandTxtbox.SelectedIndexChanged += new System.EventHandler(this.SearchBrandTxtbox_SelectedIndexChanged);
            // 
            // Client_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.SearchBrandTxtbox);
            this.Controls.Add(this.CompanyTxtBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.ToOrderPageBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.DGVclient);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.ContactTxtBox);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.ClientNameTxtBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientDetails);
            this.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Client_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_details";
            this.Load += new System.EventHandler(this.Client_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclient)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientDetails;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox ClientNameTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TextBox ContactTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.DataGridView DGVclient;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ToOrderPageBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ComboBox CompanyTxtBox;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ComboBox SearchBrandTxtbox;
    }
}

