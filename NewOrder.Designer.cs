namespace TJ_Lanka_PLC_PLM
{
    partial class NewOrder
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
            this.NewbrandDropDown = new System.Windows.Forms.ComboBox();
            this.NewclientIdTxtBox = new System.Windows.Forms.TextBox();
            this.clientId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSubmitBtn = new System.Windows.Forms.Button();
            this.NewDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.NewQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.NewUnitPriceTxtBox = new System.Windows.Forms.TextBox();
            this.NewDueDateBox = new System.Windows.Forms.DateTimePicker();
            this.NewOrderCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.NewOrderPriorityTxtBox = new System.Windows.Forms.ComboBox();
            this.Discount = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.Label();
            this.OrderCategory = new System.Windows.Forms.Label();
            this.OrderPriority = new System.Windows.Forms.Label();
            this.OrderDetails = new System.Windows.Forms.Label();
            this.NewOrderDGV = new System.Windows.Forms.DataGridView();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.NewStatusTxtBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NewbrandDropDown
            // 
            this.NewbrandDropDown.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewbrandDropDown.FormattingEnabled = true;
            this.NewbrandDropDown.Items.AddRange(new object[] {
            "ADIDAS",
            "AMAZON",
            "AMBRA",
            "ANN TAYLOR",
            "AMERICAN EAGLE",
            "ADITYA BIRLA",
            "A&F(LOCAL MARKET)",
            "SAXX2XIST"});
            this.NewbrandDropDown.Location = new System.Drawing.Point(147, 92);
            this.NewbrandDropDown.Name = "NewbrandDropDown";
            this.NewbrandDropDown.Size = new System.Drawing.Size(234, 22);
            this.NewbrandDropDown.TabIndex = 51;
            // 
            // NewclientIdTxtBox
            // 
            this.NewclientIdTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewclientIdTxtBox.Location = new System.Drawing.Point(147, 46);
            this.NewclientIdTxtBox.Name = "NewclientIdTxtBox";
            this.NewclientIdTxtBox.Size = new System.Drawing.Size(234, 20);
            this.NewclientIdTxtBox.TabIndex = 50;
            // 
            // clientId
            // 
            this.clientId.AutoSize = true;
            this.clientId.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientId.Location = new System.Drawing.Point(43, 49);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(59, 14);
            this.clientId.TabIndex = 49;
            this.clientId.Text = "Client Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Brand";
            // 
            // NewSubmitBtn
            // 
            this.NewSubmitBtn.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSubmitBtn.Location = new System.Drawing.Point(682, 213);
            this.NewSubmitBtn.Name = "NewSubmitBtn";
            this.NewSubmitBtn.Size = new System.Drawing.Size(72, 30);
            this.NewSubmitBtn.TabIndex = 44;
            this.NewSubmitBtn.Text = "SUBMIT";
            this.NewSubmitBtn.UseVisualStyleBackColor = true;
            this.NewSubmitBtn.Click += new System.EventHandler(this.NewSubmitBtn_Click);
            // 
            // NewDiscountTxtBox
            // 
            this.NewDiscountTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDiscountTxtBox.Location = new System.Drawing.Point(520, 177);
            this.NewDiscountTxtBox.Name = "NewDiscountTxtBox";
            this.NewDiscountTxtBox.Size = new System.Drawing.Size(234, 20);
            this.NewDiscountTxtBox.TabIndex = 43;
            // 
            // NewQuantityTxtBox
            // 
            this.NewQuantityTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuantityTxtBox.Location = new System.Drawing.Point(520, 134);
            this.NewQuantityTxtBox.Name = "NewQuantityTxtBox";
            this.NewQuantityTxtBox.Size = new System.Drawing.Size(234, 20);
            this.NewQuantityTxtBox.TabIndex = 42;
            // 
            // NewUnitPriceTxtBox
            // 
            this.NewUnitPriceTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUnitPriceTxtBox.Location = new System.Drawing.Point(519, 94);
            this.NewUnitPriceTxtBox.Name = "NewUnitPriceTxtBox";
            this.NewUnitPriceTxtBox.Size = new System.Drawing.Size(234, 20);
            this.NewUnitPriceTxtBox.TabIndex = 41;
            // 
            // NewDueDateBox
            // 
            this.NewDueDateBox.Location = new System.Drawing.Point(519, 46);
            this.NewDueDateBox.Name = "NewDueDateBox";
            this.NewDueDateBox.Size = new System.Drawing.Size(234, 20);
            this.NewDueDateBox.TabIndex = 40;
            // 
            // NewOrderCategoryDropDown
            // 
            this.NewOrderCategoryDropDown.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderCategoryDropDown.FormattingEnabled = true;
            this.NewOrderCategoryDropDown.Items.AddRange(new object[] {
            "Solid",
            "Cuff & Collar",
            "Lase"});
            this.NewOrderCategoryDropDown.Location = new System.Drawing.Point(147, 132);
            this.NewOrderCategoryDropDown.Name = "NewOrderCategoryDropDown";
            this.NewOrderCategoryDropDown.Size = new System.Drawing.Size(234, 22);
            this.NewOrderCategoryDropDown.TabIndex = 39;
            // 
            // NewOrderPriorityTxtBox
            // 
            this.NewOrderPriorityTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderPriorityTxtBox.FormattingEnabled = true;
            this.NewOrderPriorityTxtBox.Items.AddRange(new object[] {
            "Top Urgent",
            "Urgent",
            "Not Urgent"});
            this.NewOrderPriorityTxtBox.Location = new System.Drawing.Point(147, 175);
            this.NewOrderPriorityTxtBox.Name = "NewOrderPriorityTxtBox";
            this.NewOrderPriorityTxtBox.Size = new System.Drawing.Size(234, 22);
            this.NewOrderPriorityTxtBox.TabIndex = 38;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(430, 178);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(60, 14);
            this.Discount.TabIndex = 37;
            this.Discount.Text = "Discount";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(430, 135);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(59, 14);
            this.Quantity.TabIndex = 36;
            this.Quantity.Text = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.Location = new System.Drawing.Point(430, 95);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(65, 14);
            this.UnitPrice.TabIndex = 35;
            this.UnitPrice.Text = "Unit Price";
            // 
            // DueDate
            // 
            this.DueDate.AutoSize = true;
            this.DueDate.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(430, 49);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(62, 14);
            this.DueDate.TabIndex = 34;
            this.DueDate.Text = "Due Date";
            // 
            // OrderCategory
            // 
            this.OrderCategory.AutoSize = true;
            this.OrderCategory.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCategory.Location = new System.Drawing.Point(41, 135);
            this.OrderCategory.Name = "OrderCategory";
            this.OrderCategory.Size = new System.Drawing.Size(97, 14);
            this.OrderCategory.TabIndex = 33;
            this.OrderCategory.Text = "Order Category";
            // 
            // OrderPriority
            // 
            this.OrderPriority.AutoSize = true;
            this.OrderPriority.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPriority.Location = new System.Drawing.Point(41, 178);
            this.OrderPriority.Name = "OrderPriority";
            this.OrderPriority.Size = new System.Drawing.Size(89, 14);
            this.OrderPriority.TabIndex = 32;
            this.OrderPriority.Text = "Oredr Priority";
            // 
            // OrderDetails
            // 
            this.OrderDetails.AutoSize = true;
            this.OrderDetails.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDetails.Location = new System.Drawing.Point(347, 9);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(86, 14);
            this.OrderDetails.TabIndex = 31;
            this.OrderDetails.Text = "Order Details";
            // 
            // NewOrderDGV
            // 
            this.NewOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewOrderDGV.Location = new System.Drawing.Point(44, 249);
            this.NewOrderDGV.Name = "NewOrderDGV";
            this.NewOrderDGV.Size = new System.Drawing.Size(709, 204);
            this.NewOrderDGV.TabIndex = 52;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(584, 213);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(78, 30);
            this.ResetBtn.TabIndex = 53;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(195, 221);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(49, 14);
            this.total.TabIndex = 55;
            this.total.Text = "Total : ";
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtBox.Location = new System.Drawing.Point(238, 218);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(141, 20);
            this.totalTxtBox.TabIndex = 54;
            // 
            // NewStatusTxtBox
            // 
            this.NewStatusTxtBox.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStatusTxtBox.FormattingEnabled = true;
            this.NewStatusTxtBox.Items.AddRange(new object[] {
            "Active",
            "In Progress",
            "Inactive",
            "Completed"});
            this.NewStatusTxtBox.Location = new System.Drawing.Point(460, 216);
            this.NewStatusTxtBox.Name = "NewStatusTxtBox";
            this.NewStatusTxtBox.Size = new System.Drawing.Size(105, 22);
            this.NewStatusTxtBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 57;
            this.label2.Text = "Status";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewStatusTxtBox);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.NewOrderDGV);
            this.Controls.Add(this.NewbrandDropDown);
            this.Controls.Add(this.NewclientIdTxtBox);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewSubmitBtn);
            this.Controls.Add(this.NewDiscountTxtBox);
            this.Controls.Add(this.NewQuantityTxtBox);
            this.Controls.Add(this.NewUnitPriceTxtBox);
            this.Controls.Add(this.NewDueDateBox);
            this.Controls.Add(this.NewOrderCategoryDropDown);
            this.Controls.Add(this.NewOrderPriorityTxtBox);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.OrderCategory);
            this.Controls.Add(this.OrderPriority);
            this.Controls.Add(this.OrderDetails);
            this.Controls.Add(this.total);
            this.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewOrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NewbrandDropDown;
        private System.Windows.Forms.TextBox NewclientIdTxtBox;
        private System.Windows.Forms.Label clientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewSubmitBtn;
        private System.Windows.Forms.TextBox NewDiscountTxtBox;
        private System.Windows.Forms.TextBox NewQuantityTxtBox;
        private System.Windows.Forms.TextBox NewUnitPriceTxtBox;
        private System.Windows.Forms.DateTimePicker NewDueDateBox;
        private System.Windows.Forms.ComboBox NewOrderCategoryDropDown;
        private System.Windows.Forms.ComboBox NewOrderPriorityTxtBox;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label DueDate;
        private System.Windows.Forms.Label OrderCategory;
        private System.Windows.Forms.Label OrderPriority;
        private System.Windows.Forms.Label OrderDetails;
        private System.Windows.Forms.DataGridView NewOrderDGV;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.ComboBox NewStatusTxtBox;
        private System.Windows.Forms.Label label2;
    }
}