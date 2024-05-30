namespace Exam_Prep___Group_2
{
    partial class MainForm
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
            this.SISgb = new System.Windows.Forms.GroupBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.SISdgv = new System.Windows.Forms.DataGridView();
            this.studentnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEASDataSet2 = new Exam_Prep___Group_2.CEASDataSet2();
            this.snBox = new System.Windows.Forms.TextBox();
            this.fnBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.FNlabel = new System.Windows.Forms.Label();
            this.classlabel = new System.Windows.Forms.Label();
            this.studentlabel = new System.Windows.Forms.Label();
            this.SIBox = new System.Windows.Forms.TextBox();
            this.cEASDataSet1 = new Exam_Prep___Group_2.CEASDataSet1();
            this.cEASDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new Exam_Prep___Group_2.CEASDataSet2TableAdapters.STUDENTSTableAdapter();
            this.SISgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SISdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SISgb
            // 
            this.SISgb.Controls.Add(this.exitbutton);
            this.SISgb.Controls.Add(this.deletebutton);
            this.SISgb.Controls.Add(this.updatebutton);
            this.SISgb.Controls.Add(this.insertbutton);
            this.SISgb.Controls.Add(this.SISdgv);
            this.SISgb.Controls.Add(this.snBox);
            this.SISgb.Controls.Add(this.fnBox);
            this.SISgb.Controls.Add(this.cBox);
            this.SISgb.Controls.Add(this.surnamelabel);
            this.SISgb.Controls.Add(this.FNlabel);
            this.SISgb.Controls.Add(this.classlabel);
            this.SISgb.Controls.Add(this.studentlabel);
            this.SISgb.Controls.Add(this.SIBox);
            this.SISgb.Font = new System.Drawing.Font("Lucida Fax", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SISgb.Location = new System.Drawing.Point(12, 12);
            this.SISgb.Name = "SISgb";
            this.SISgb.Size = new System.Drawing.Size(1010, 544);
            this.SISgb.TabIndex = 0;
            this.SISgb.TabStop = false;
            this.SISgb.Text = "System Information System";
            this.SISgb.Enter += new System.EventHandler(this.SISgb_Enter);
            // 
            // exitbutton
            // 
            this.exitbutton.AutoSize = true;
            this.exitbutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(801, 440);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(107, 36);
            this.exitbutton.TabIndex = 12;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.AutoSize = true;
            this.deletebutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(585, 440);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(107, 36);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.AutoSize = true;
            this.updatebutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(346, 440);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(107, 36);
            this.updatebutton.TabIndex = 10;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.AutoSize = true;
            this.insertbutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.Location = new System.Drawing.Point(111, 440);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(107, 36);
            this.insertbutton.TabIndex = 9;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SISdgv
            // 
            this.SISdgv.AllowUserToOrderColumns = true;
            this.SISdgv.AutoGenerateColumns = false;
            this.SISdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SISdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SISdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnoDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.SISdgv.DataSource = this.sTUDENTSBindingSource;
            this.SISdgv.Location = new System.Drawing.Point(429, 54);
            this.SISdgv.Name = "SISdgv";
            this.SISdgv.Size = new System.Drawing.Size(562, 332);
            this.SISdgv.TabIndex = 8;
            // 
            // studentnoDataGridViewTextBoxColumn
            // 
            this.studentnoDataGridViewTextBoxColumn.DataPropertyName = "studentno";
            this.studentnoDataGridViewTextBoxColumn.HeaderText = "studentno";
            this.studentnoDataGridViewTextBoxColumn.Name = "studentnoDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource.DataSource = this.cEASDataSet2;
            // 
            // cEASDataSet2
            // 
            this.cEASDataSet2.DataSetName = "CEASDataSet2";
            this.cEASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snBox
            // 
            this.snBox.Location = new System.Drawing.Point(218, 159);
            this.snBox.Name = "snBox";
            this.snBox.Size = new System.Drawing.Size(176, 32);
            this.snBox.TabIndex = 7;
            // 
            // fnBox
            // 
            this.fnBox.Location = new System.Drawing.Point(218, 245);
            this.fnBox.Name = "fnBox";
            this.fnBox.Size = new System.Drawing.Size(176, 32);
            this.fnBox.TabIndex = 6;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(218, 330);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(176, 32);
            this.cBox.TabIndex = 5;
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelabel.Location = new System.Drawing.Point(73, 168);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(82, 23);
            this.surnamelabel.TabIndex = 4;
            this.surnamelabel.Text = "Surname";
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(73, 254);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(98, 23);
            this.FNlabel.TabIndex = 3;
            this.FNlabel.Text = "First Name";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.Location = new System.Drawing.Point(73, 339);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(51, 23);
            this.classlabel.TabIndex = 2;
            this.classlabel.Text = "Class";
            // 
            // studentlabel
            // 
            this.studentlabel.AutoSize = true;
            this.studentlabel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlabel.Location = new System.Drawing.Point(73, 81);
            this.studentlabel.Name = "studentlabel";
            this.studentlabel.Size = new System.Drawing.Size(95, 23);
            this.studentlabel.TabIndex = 1;
            this.studentlabel.Text = "Student ID";
            // 
            // SIBox
            // 
            this.SIBox.Location = new System.Drawing.Point(218, 72);
            this.SIBox.Name = "SIBox";
            this.SIBox.Size = new System.Drawing.Size(176, 32);
            this.SIBox.TabIndex = 0;
            // 
            // cEASDataSet1
            // 
            this.cEASDataSet1.DataSetName = "CEASDataSet1";
            this.cEASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cEASDataSet1BindingSource
            // 
            this.cEASDataSet1BindingSource.DataSource = this.cEASDataSet1;
            this.cEASDataSet1BindingSource.Position = 0;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.SISgb);
            this.Name = "MainForm";
            this.Text = "Student Information System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SISgb.ResumeLayout(false);
            this.SISgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SISdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEASDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SISgb;
        private System.Windows.Forms.DataGridView SISdgv;
        private System.Windows.Forms.TextBox snBox;
        private System.Windows.Forms.TextBox fnBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label surnamelabel;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label studentlabel;
        private System.Windows.Forms.TextBox SIBox;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.BindingSource cEASDataSet1BindingSource;
        private CEASDataSet1 cEASDataSet1;
        private CEASDataSet2 cEASDataSet2;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private CEASDataSet2TableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}

