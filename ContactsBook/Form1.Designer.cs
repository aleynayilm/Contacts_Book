namespace ContactsBook
{
    partial class Form1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(21, 19);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 61);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 16);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Location = new System.Drawing.Point(21, 102);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(159, 16);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(524, 22);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(704, 16);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 58);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(524, 22);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Location = new System.Drawing.Point(159, 96);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(524, 22);
            this.phoneNumTextBox.TabIndex = 7;
            this.phoneNumTextBox.TextChanged += new System.EventHandler(this.phoneNumTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(159, 134);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(524, 22);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(704, 58);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(704, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(704, 140);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.Location = new System.Drawing.Point(24, 190);
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.RowHeadersWidth = 51;
            this.contactsDataGrid.RowTemplate.Height = 24;
            this.contactsDataGrid.Size = new System.Drawing.Size(755, 231);
            this.contactsDataGrid.TabIndex = 12;
            this.contactsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsDataGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contactsDataGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.DataGridView contactsDataGrid;
    }
}

