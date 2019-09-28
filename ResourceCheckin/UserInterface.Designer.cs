namespace ResourceCheckin
{
    partial class UserInterface
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
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.uxNameBox = new System.Windows.Forms.TextBox();
            this.uxOwnerBox = new System.Windows.Forms.TextBox();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxOwnerLabel = new System.Windows.Forms.Label();
            this.uxResourceDropdown = new System.Windows.Forms.ComboBox();
            this.uxResourceLabel = new System.Windows.Forms.Label();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.AllowUserToAddRows = false;
            this.uxDataGrid.AllowUserToDeleteRows = false;
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ResourceType,
            this.ResourceName,
            this.ResourceParent,
            this.ResourceLocation});
            this.uxDataGrid.Location = new System.Drawing.Point(12, 12);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.Size = new System.Drawing.Size(1105, 1017);
            this.uxDataGrid.TabIndex = 0;
            // 
            // uxNameBox
            // 
            this.uxNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxNameBox.Location = new System.Drawing.Point(1350, 50);
            this.uxNameBox.Name = "uxNameBox";
            this.uxNameBox.Size = new System.Drawing.Size(412, 29);
            this.uxNameBox.TabIndex = 1;
            // 
            // uxOwnerBox
            // 
            this.uxOwnerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxOwnerBox.Location = new System.Drawing.Point(1350, 100);
            this.uxOwnerBox.Name = "uxOwnerBox";
            this.uxOwnerBox.Size = new System.Drawing.Size(412, 29);
            this.uxOwnerBox.TabIndex = 2;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxNameLabel.Location = new System.Drawing.Point(1268, 53);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(66, 24);
            this.uxNameLabel.TabIndex = 5;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxOwnerLabel
            // 
            this.uxOwnerLabel.AutoSize = true;
            this.uxOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxOwnerLabel.Location = new System.Drawing.Point(1151, 103);
            this.uxOwnerLabel.Name = "uxOwnerLabel";
            this.uxOwnerLabel.Size = new System.Drawing.Size(183, 24);
            this.uxOwnerLabel.TabIndex = 6;
            this.uxOwnerLabel.Text = "Owner/Organization:";
            // 
            // uxResourceDropdown
            // 
            this.uxResourceDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxResourceDropdown.FormattingEnabled = true;
            this.uxResourceDropdown.Items.AddRange(new object[] {
            "STAFF",
            "CONSOLE",
            "COMPUTER",
            "MONITOR",
            "RADIO",
            "OTHER"});
            this.uxResourceDropdown.Location = new System.Drawing.Point(1350, 150);
            this.uxResourceDropdown.Name = "uxResourceDropdown";
            this.uxResourceDropdown.Size = new System.Drawing.Size(169, 32);
            this.uxResourceDropdown.TabIndex = 7;
            // 
            // uxResourceLabel
            // 
            this.uxResourceLabel.AutoSize = true;
            this.uxResourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxResourceLabel.Location = new System.Drawing.Point(1189, 153);
            this.uxResourceLabel.Name = "uxResourceLabel";
            this.uxResourceLabel.Size = new System.Drawing.Size(145, 24);
            this.uxResourceLabel.TabIndex = 8;
            this.uxResourceLabel.Text = "Resource Type:";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxAddButton.Location = new System.Drawing.Point(1575, 150);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(187, 32);
            this.uxAddButton.TabIndex = 9;
            this.uxAddButton.Text = "Add New Resource";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ResourceType
            // 
            this.ResourceType.HeaderText = "Resource Type";
            this.ResourceType.Name = "ResourceType";
            this.ResourceType.Width = 110;
            // 
            // ResourceName
            // 
            this.ResourceName.HeaderText = "Name";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            this.ResourceName.Width = 250;
            // 
            // ResourceParent
            // 
            this.ResourceParent.HeaderText = "Owner/Organization";
            this.ResourceParent.Name = "ResourceParent";
            this.ResourceParent.ReadOnly = true;
            this.ResourceParent.Width = 250;
            // 
            // ResourceLocation
            // 
            this.ResourceLocation.HeaderText = "Location";
            this.ResourceLocation.Name = "ResourceLocation";
            this.ResourceLocation.Width = 300;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxResourceLabel);
            this.Controls.Add(this.uxResourceDropdown);
            this.Controls.Add(this.uxOwnerLabel);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxOwnerBox);
            this.Controls.Add(this.uxNameBox);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "UserInterface";
            this.Text = "Resource Check-In Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.TextBox uxNameBox;
        private System.Windows.Forms.TextBox uxOwnerBox;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxOwnerLabel;
        private System.Windows.Forms.ComboBox uxResourceDropdown;
        private System.Windows.Forms.Label uxResourceLabel;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceLocation;
    }
}

