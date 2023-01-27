namespace TJ_Lanka_PLC_PLM
{
    partial class Order_details
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
            this.OrderDetails = new System.Windows.Forms.Label();
            this.OrderPriority = new System.Windows.Forms.Label();
            this.OrderCategory = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.OrderPriorityTxtBox = new System.Windows.Forms.ComboBox();
            this.OrderCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.DueDateBox = new System.Windows.Forms.DateTimePicker();
            this.UnitPriceTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.DiscountTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BackBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.DGVorder = new System.Windows.Forms.DataGridView();
            this.searchBrand = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientIdTxtBox = new System.Windows.Forms.TextBox();
            this.clientId = new System.Windows.Forms.Label();
            this.brandDropDown = new System.Windows.Forms.ComboBox();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusTxtBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVorder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDetails
            // 
            this.OrderDetails.AutoSize = true;
            this.OrderDetails.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDetails.Location = new System.Drawing.Point(359, 9);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(86, 14);
            this.OrderDetails.TabIndex = 1;
            this.OrderDetails.Text = "Order Details";
            // 
            // OrderPriority
            // 
            this.OrderPriority.AutoSize = true;
            this.OrderPriority.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriority.Location = new System.Drawing.Point(37, 174);
            this.OrderPriority.Name = "OrderPriority";
            this.OrderPriority.Size = new System.Drawing.Size(89, 14);
            this.OrderPriority.TabIndex = 2;
            this.OrderPriority.Text = "Oredr Priority";
            // 
            // OrderCategory
            // 
            this.OrderCategory.AutoSize = true;
            this.OrderCategory.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCategory.Location = new System.Drawing.Point(37, 131);
            this.OrderCategory.Name = "OrderCategory";
            this.OrderCategory.Size = new System.Drawing.Size(97, 14);
            this.OrderCategory.TabIndex = 3;
            this.OrderCategory.Text = "Order Category";
            // 
            // DueDate
            // 
            this.DueDate.AutoSize = true;
            this.DueDate.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(426, 45);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(62, 14);
            this.DueDate.TabIndex = 5;
            this.DueDate.Text = "Due Date";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.Location = new System.Drawing.Point(426, 85);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(65, 14);
            this.UnitPrice.TabIndex = 6;
            this.UnitPrice.Text = "Unit Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(426, 128);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(59, 14);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(426, 176);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(60, 14);
            this.Discount.TabIndex = 8;
            this.Discount.Text = "Discount";
            // 
            // OrderPriorityTxtBox
            // 
            this.OrderPriorityTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriorityTxtBox.FormattingEnabled = true;
            this.OrderPriorityTxtBox.Items.AddRange(new object[] {
            "Top Urgent",
            "Urgent",
            "Not Urgent"});
            this.OrderPriorityTxtBox.Location = new System.Drawing.Point(143, 171);
            this.OrderPriorityTxtBox.Name = "OrderPriorityTxtBox";
            this.OrderPriorityTxtBox.Size = new System.Drawing.Size(234, 22);
            this.OrderPriorityTxtBox.TabIndex = 9;
            // 
            // OrderCategoryDropDown
            // 
            this.OrderCategoryDropDown.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCategoryDropDown.FormattingEnabled = true;
            this.OrderCategoryDropDown.Items.AddRange(new object[] {
            "Solid",
            "Cuff & Collar",
            "Lase"});
            this.OrderCategoryDropDown.Location = new System.Drawing.Point(143, 128);
            this.OrderCategoryDropDown.Name = "OrderCategoryDropDown";
            this.OrderCategoryDropDown.Size = new System.Drawing.Size(234, 22);
            this.OrderCategoryDropDown.TabIndex = 10;
            // 
            // DueDateBox
            // 
            this.DueDateBox.Location = new System.Drawing.Point(516, 42);
            this.DueDateBox.Name = "DueDateBox";
            this.DueDateBox.Size = new System.Drawing.Size(234, 20);
            this.DueDateBox.TabIndex = 13;
            // 
            // UnitPriceTxtBox
            // 
            this.UnitPriceTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTxtBox.Location = new System.Drawing.Point(516, 82);
            this.UnitPriceTxtBox.Name = "UnitPriceTxtBox";
            this.UnitPriceTxtBox.Size = new System.Drawing.Size(234, 20);
            this.UnitPriceTxtBox.TabIndex = 14;
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxtBox.Location = new System.Drawing.Point(516, 130);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(234, 20);
            this.QuantityTxtBox.TabIndex = 15;
            // 
            // DiscountTxtBox
            // 
            this.DiscountTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTxtBox.Location = new System.Drawing.Point(516, 173);
            this.DiscountTxtBox.Name = "DiscountTxtBox";
            this.DiscountTxtBox.Size = new System.Drawing.Size(234, 20);
            this.DiscountTxtBox.TabIndex = 16;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(678, 209);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(72, 30);
            this.SubmitBtn.TabIndex = 17;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn1_Click_1);
            // 
            // BackBtn1
            // 
            this.BackBtn1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn1.Location = new System.Drawing.Point(629, 435);
            this.BackBtn1.Name = "BackBtn1";
            this.BackBtn1.Size = new System.Drawing.Size(121, 30);
            this.BackBtn1.TabIndex = 18;
            this.BackBtn1.Text = "To Client Details";
            this.BackBtn1.UseVisualStyleBackColor = true;
            this.BackBtn1.Click += new System.EventHandler(this.BackBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Brand";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(585, 209);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(72, 30);
            this.btnUpdateOrder.TabIndex = 21;
            this.btnUpdateOrder.Text = "UPDATE";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // DGVorder
            // 
            this.DGVorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVorder.Location = new System.Drawing.Point(40, 248);
            this.DGVorder.Name = "DGVorder";
            this.DGVorder.Size = new System.Drawing.Size(710, 178);
            this.DGVorder.TabIndex = 22;
            this.DGVorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVorder_CellClick);
            this.DGVorder.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVorder_CellMouseUp);
            // 
            // searchBrand
            // 
            this.searchBrand.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBrand.FormattingEnabled = true;
            this.searchBrand.Items.AddRange(new object[] {
            "ADIDAS",
            "AMAZON",
            "AMBRA",
            "ANN TAYLOR",
            "AMERICAN EAGLE",
            "ADITYA BIRLA",
            "A&F(LOCAL MARKET)",
            "SAXX2XIST"});
            this.searchBrand.Location = new System.Drawing.Point(41, 214);
            this.searchBrand.Name = "searchBrand";
            this.searchBrand.Size = new System.Drawing.Size(144, 22);
            this.searchBrand.TabIndex = 27;
            this.searchBrand.Text = "Search By Brand";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteOrderToolStripMenuItem,
            this.editOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteOrderToolStripMenuItem.Text = "Delete Order";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // editOrderToolStripMenuItem
            // 
            this.editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            this.editOrderToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editOrderToolStripMenuItem.Text = "Edit Order";
            this.editOrderToolStripMenuItem.Click += new System.EventHandler(this.editOrderToolStripMenuItem_Click);
            // 
            // clientIdTxtBox
            // 
            this.clientIdTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIdTxtBox.Location = new System.Drawing.Point(143, 42);
            this.clientIdTxtBox.Name = "clientIdTxtBox";
            this.clientIdTxtBox.Size = new System.Drawing.Size(234, 20);
            this.clientIdTxtBox.TabIndex = 29;
            // 
            // clientId
            // 
            this.clientId.AutoSize = true;
            this.clientId.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientId.Location = new System.Drawing.Point(39, 45);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(59, 14);
            this.clientId.TabIndex = 28;
            this.clientId.Text = "Client Id";
            // 
            // brandDropDown
            // 
            this.brandDropDown.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandDropDown.FormattingEnabled = true;
            this.brandDropDown.Items.AddRange(new object[] {
            "ADIDAS",
            "AMAZON",
            "AMBRA",
            "ANN TAYLOR",
            "AMERICAN EAGLE",
            "ADITYA BIRLA",
            "A&F(LOCAL MARKET)",
            "SAXX2XIST"});
            this.brandDropDown.Location = new System.Drawing.Point(143, 88);
            this.brandDropDown.Name = "brandDropDown";
            this.brandDropDown.Size = new System.Drawing.Size(234, 22);
            this.brandDropDown.TabIndex = 30;
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBox.Location = new System.Drawing.Point(236, 216);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(141, 20);
            this.totalTxtBox.TabIndex = 31;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(195, 219);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(49, 14);
            this.total.TabIndex = 32;
            this.total.Text = "Total : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "Status";
            // 
            // StatusTxtBox
            // 
            this.StatusTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxtBox.FormattingEnabled = true;
            this.StatusTxtBox.Items.AddRange(new object[] {
            "Active",
            "In Progress",
            "Inactive",
            "Completed"});
            this.StatusTxtBox.Location = new System.Drawing.Point(460, 214);
            this.StatusTxtBox.Name = "StatusTxtBox";
            this.StatusTxtBox.Size = new System.Drawing.Size(105, 22);
            this.StatusTxtBox.TabIndex = 58;
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusTxtBox);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.brandDropDown);
            this.Controls.Add(this.clientIdTxtBox);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.searchBrand);
            this.Controls.Add(this.DGVorder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DiscountTxtBox);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.UnitPriceTxtBox);
            this.Controls.Add(this.DueDateBox);
            this.Controls.Add(this.OrderCategoryDropDown);
            this.Controls.Add(this.OrderPriorityTxtBox);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.OrderCategory);
            this.Controls.Add(this.OrderPriority);
            this.Controls.Add(this.OrderDetails);
            this.Controls.Add(this.total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_details";
            this.Load += new System.EventHandler(this.Order_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVorder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderDetails;
        private System.Windows.Forms.Label OrderPriority;
        private System.Windows.Forms.Label OrderCategory;
        private System.Windows.Forms.Label DueDate;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.ComboBox OrderPriorityTxtBox;
        private System.Windows.Forms.ComboBox OrderCategoryDropDown;
        private System.Windows.Forms.DateTimePicker DueDateBox;
        private System.Windows.Forms.TextBox UnitPriceTxtBox;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.TextBox DiscountTxtBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button BackBtn1;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.DataGridView DGVorder;
        private System.Windows.Forms.ComboBox searchBrand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.TextBox clientIdTxtBox;
        private System.Windows.Forms.Label clientId;
        private System.Windows.Forms.ComboBox brandDropDown;
        private System.Windows.Forms.ToolStripMenuItem editOrderToolStripMenuItem;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StatusTxtBox;
    }
}