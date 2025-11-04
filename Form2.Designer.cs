namespace AssignmentIOOP
{
    partial class ManageMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMenuForm));
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnDeleteSelectedItem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowUserToAddRows = false;
            this.dgvMenuItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(210, 198);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.RowHeadersWidth = 62;
            this.dgvMenuItems.RowTemplate.Height = 28;
            this.dgvMenuItems.Size = new System.Drawing.Size(902, 188);
            this.dgvMenuItems.TabIndex = 0;
            this.dgvMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellContentClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(551, 114);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(223, 37);
            this.cmbCategory.TabIndex = 7;
            this.cmbCategory.Text = "CATEGORY";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(906, 114);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 37);
            this.cmbStatus.TabIndex = 8;
            this.cmbStatus.Text = "STATUS";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.Location = new System.Drawing.Point(499, 420);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(248, 54);
            this.btnAddNewItem.TabIndex = 9;
            this.btnAddNewItem.Text = "+ Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnDeleteSelectedItem
            // 
            this.btnDeleteSelectedItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedItem.Location = new System.Drawing.Point(499, 517);
            this.btnDeleteSelectedItem.Name = "btnDeleteSelectedItem";
            this.btnDeleteSelectedItem.Size = new System.Drawing.Size(248, 55);
            this.btnDeleteSelectedItem.TabIndex = 11;
            this.btnDeleteSelectedItem.Text = "Delete Selected Item";
            this.btnDeleteSelectedItem.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedItem.Click += new System.EventHandler(this.btnDeleteSelectedItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(210, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 37);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(1147, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 101);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 17;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(231)))), ((int)(((byte)(194)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(661, 27);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 37);
            this.btnDashboard.TabIndex = 35;
            this.btnDashboard.Text = "🏠Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrders.Location = new System.Drawing.Point(816, 27);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(149, 37);
            this.btnViewOrders.TabIndex = 36;
            this.btnViewOrders.Text = "📃Orders";
            this.btnViewOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(193, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 41);
            this.label1.TabIndex = 37;
            this.label1.Text = "📖 Manage Menu";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProfile.Location = new System.Drawing.Point(971, 27);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(149, 37);
            this.btnUpdateProfile.TabIndex = 38;
            this.btnUpdateProfile.Text = "🧑‍🍳Profile";
            this.btnUpdateProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveItem.Location = new System.Drawing.Point(871, 579);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(149, 37);
            this.btnSaveItem.TabIndex = 40;
            this.btnSaveItem.Text = "✅ Save";
            this.btnSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowDrop = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1066, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 37);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "🚫 Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(231)))), ((int)(((byte)(194)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 643);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteSelectedItem);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dgvMenuItems);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ManageMenuForm";
            this.Text = "Manage Menu";
            this.Load += new System.EventHandler(this.ManageMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnDeleteSelectedItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnCancel;
    }
}