namespace AssignmentIOOP
{
    partial class ChefDashboardForm
    {
       
        private System.ComponentModel.IContainer components = null;

      
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefDashboardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPending = new System.Windows.Forms.Panel();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.panelInProgress = new System.Windows.Forms.Panel();
            this.lbl_InProgressCount = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCompletedTodayCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.col_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelPending.SuspendLayout();
            this.panelInProgress.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(231)))), ((int)(((byte)(194)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-14, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProfile.Location = new System.Drawing.Point(822, 37);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(128, 31);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "🧑‍🍳Profile";
            this.btnUpdateProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrders.Location = new System.Drawing.Point(689, 37);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(128, 31);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "📃Orders";
            this.btnViewOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMenu.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMenu.Location = new System.Drawing.Point(556, 37);
            this.btnManageMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(128, 31);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = " 🍽️Menu";
            this.btnManageMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageMenu.UseVisualStyleBackColor = false;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "📈TODAY\'S OVERVIEW";
            // 
            // panelPending
            // 
            this.panelPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPending.Controls.Add(this.lblPendingOrders);
            this.panelPending.Controls.Add(this.lblPendingCount);
            this.panelPending.Location = new System.Drawing.Point(139, 172);
            this.panelPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPending.Name = "panelPending";
            this.panelPending.Size = new System.Drawing.Size(171, 83);
            this.panelPending.TabIndex = 18;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(20, 10);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(129, 21);
            this.lblPendingOrders.TabIndex = 19;
            this.lblPendingOrders.Text = "Pending Orders";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingCount.Location = new System.Drawing.Point(76, 36);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(23, 33);
            this.lblPendingCount.TabIndex = 18;
            this.lblPendingCount.Text = "1";
            this.lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPendingCount.Click += new System.EventHandler(this.lblPendingCount_Click);
            // 
            // panelInProgress
            // 
            this.panelInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelInProgress.Controls.Add(this.lbl_InProgressCount);
            this.panelInProgress.Controls.Add(this.lblInProgress);
            this.panelInProgress.Location = new System.Drawing.Point(470, 172);
            this.panelInProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInProgress.Name = "panelInProgress";
            this.panelInProgress.Size = new System.Drawing.Size(192, 83);
            this.panelInProgress.TabIndex = 19;
            // 
            // lbl_InProgressCount
            // 
            this.lbl_InProgressCount.AutoSize = true;
            this.lbl_InProgressCount.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InProgressCount.Location = new System.Drawing.Point(74, 36);
            this.lbl_InProgressCount.Name = "lbl_InProgressCount";
            this.lbl_InProgressCount.Size = new System.Drawing.Size(23, 33);
            this.lbl_InProgressCount.TabIndex = 19;
            this.lbl_InProgressCount.Text = "1";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(43, 10);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(94, 21);
            this.lblInProgress.TabIndex = 18;
            this.lblInProgress.Text = "In Progress";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblCompletedTodayCount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(779, 172);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 83);
            this.panel3.TabIndex = 20;
            // 
            // lblCompletedTodayCount
            // 
            this.lblCompletedTodayCount.AutoSize = true;
            this.lblCompletedTodayCount.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTodayCount.Location = new System.Drawing.Point(75, 36);
            this.lblCompletedTodayCount.Name = "lblCompletedTodayCount";
            this.lblCompletedTodayCount.Size = new System.Drawing.Size(28, 33);
            this.lblCompletedTodayCount.TabIndex = 19;
            this.lblCompletedTodayCount.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Completed Today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(135, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "📌URGENT ITEMS LOW STOCK";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Item,
            this.colCurrentQty,
            this.colReorder,
            this.colCategory});
            this.dgvLowStock.Location = new System.Drawing.Point(139, 405);
            this.dgvLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowHeadersWidth = 62;
            this.dgvLowStock.RowTemplate.Height = 28;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(729, 124);
            this.dgvLowStock.TabIndex = 22;
            this.dgvLowStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLowStock_CellContentClick);
            // 
            // col_Item
            // 
            this.col_Item.HeaderText = "ITEM";
            this.col_Item.MinimumWidth = 8;
            this.col_Item.Name = "col_Item";
            this.col_Item.ReadOnly = true;
            this.col_Item.Width = 200;
            // 
            // colCurrentQty
            // 
            this.colCurrentQty.HeaderText = "CURRENT QTY";
            this.colCurrentQty.MinimumWidth = 8;
            this.colCurrentQty.Name = "colCurrentQty";
            this.colCurrentQty.ReadOnly = true;
            this.colCurrentQty.Width = 200;
            // 
            // colReorder
            // 
            this.colReorder.HeaderText = "REORDER";
            this.colReorder.MinimumWidth = 8;
            this.colReorder.Name = "colReorder";
            this.colReorder.ReadOnly = true;
            this.colReorder.Width = 200;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "CATEGORY";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 250;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::AssignmentIOOP.Properties.Resources.Screenshot_2025_05_21_233229;
            this.pictureBox3.Location = new System.Drawing.Point(139, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(195, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Welcome Chef !";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(901, 543);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 31);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = " 🔒 Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChefDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelInProgress);
            this.Controls.Add(this.panelPending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChefDashboardForm";
            this.Text = "Chef Dashboard";
            this.Load += new System.EventHandler(this.ChefDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelPending.ResumeLayout(false);
            this.panelPending.PerformLayout();
            this.panelInProgress.ResumeLayout(false);
            this.panelInProgress.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPending;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Panel panelInProgress;
        private System.Windows.Forms.Label lbl_InProgressCount;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCompletedTodayCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}

