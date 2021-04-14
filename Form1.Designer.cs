namespace DemoLocalDataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvOldData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qualification:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(152, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(152, 114);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(196, 20);
            this.txtQualification.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brnUpdate
            // 
            this.brnUpdate.Enabled = false;
            this.brnUpdate.Location = new System.Drawing.Point(171, 168);
            this.brnUpdate.Name = "brnUpdate";
            this.brnUpdate.Size = new System.Drawing.Size(75, 23);
            this.brnUpdate.TabIndex = 7;
            this.brnUpdate.Text = "Update";
            this.brnUpdate.UseVisualStyleBackColor = true;
            this.brnUpdate.Click += new System.EventHandler(this.brnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(266, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvOldData
            // 
            this.dgvOldData.AllowUserToAddRows = false;
            this.dgvOldData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOldData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvOldData.Location = new System.Drawing.Point(6, 243);
            this.dgvOldData.Name = "dgvOldData";
            this.dgvOldData.Size = new System.Drawing.Size(450, 201);
            this.dgvOldData.TabIndex = 9;
            this.dgvOldData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOldData_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Select";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Age";
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Qualification";
            this.Column4.HeaderText = "Qualification";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(380, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "hdnId";
            this.lblId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvOldData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.brnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Save Data in Local DB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvOldData;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblId;
    }
}

