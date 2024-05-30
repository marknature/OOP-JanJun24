namespace Group_assignment_2___Microsoft_Access
{
    partial class Interface1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface1));
            this.SIS = new System.Windows.Forms.GroupBox();
            this.CEASstudents = new System.Windows.Forms.DataGridView();
            this.studentnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Group_assignment_2___Microsoft_Access.DataSet();
            this.deletebutton = new System.Windows.Forms.Button();
            this.URbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.textBoxclass = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxsur = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.FNlabel = new System.Windows.Forms.Label();
            this.classlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.sTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTSTableAdapter = new Group_assignment_2___Microsoft_Access.DataSetTableAdapters.STUDENTSTableAdapter();
            this.SIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEASstudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SIS
            // 
            this.SIS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SIS.Controls.Add(this.CEASstudents);
            this.SIS.Controls.Add(this.deletebutton);
            this.SIS.Controls.Add(this.URbutton);
            this.SIS.Controls.Add(this.exitbutton);
            this.SIS.Controls.Add(this.insertbutton);
            this.SIS.Controls.Add(this.textBoxclass);
            this.SIS.Controls.Add(this.textBoxFN);
            this.SIS.Controls.Add(this.textBoxsur);
            this.SIS.Controls.Add(this.textBoxID);
            this.SIS.Controls.Add(this.surnamelabel);
            this.SIS.Controls.Add(this.FNlabel);
            this.SIS.Controls.Add(this.classlabel);
            this.SIS.Controls.Add(this.IDlabel);
            this.SIS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIS.ForeColor = System.Drawing.Color.Black;
            this.SIS.Location = new System.Drawing.Point(9, 12);
            this.SIS.Name = "SIS";
            this.SIS.Size = new System.Drawing.Size(1002, 465);
            this.SIS.TabIndex = 0;
            this.SIS.TabStop = false;
            this.SIS.Text = "STUDENT INFORMATION SYSTEM";
            this.SIS.Enter += new System.EventHandler(this.SIS_Enter);
            // 
            // CEASstudents
            // 
            this.CEASstudents.AutoGenerateColumns = false;
            this.CEASstudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CEASstudents.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.CEASstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CEASstudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnoDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.CEASstudents.DataSource = this.sTUDENTSBindingSource1;
            this.CEASstudents.Location = new System.Drawing.Point(360, 65);
            this.CEASstudents.Name = "CEASstudents";
            this.CEASstudents.ReadOnly = true;
            this.CEASstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CEASstudents.Size = new System.Drawing.Size(618, 261);
            this.CEASstudents.TabIndex = 13;
            this.CEASstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.CEASstudents.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentnoDataGridViewTextBoxColumn
            // 
            this.studentnoDataGridViewTextBoxColumn.DataPropertyName = "studentno";
            this.studentnoDataGridViewTextBoxColumn.HeaderText = "studentno";
            this.studentnoDataGridViewTextBoxColumn.Name = "studentnoDataGridViewTextBoxColumn";
            this.studentnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTSBindingSource1
            // 
            this.sTUDENTSBindingSource1.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource1.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletebutton.BackColor = System.Drawing.Color.LightGray;
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Black;
            this.deletebutton.Location = new System.Drawing.Point(360, 357);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(119, 41);
            this.deletebutton.TabIndex = 12;
            this.deletebutton.Text = "Delete Record";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // URbutton
            // 
            this.URbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.URbutton.BackColor = System.Drawing.Color.LightGray;
            this.URbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.URbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URbutton.ForeColor = System.Drawing.Color.Black;
            this.URbutton.Location = new System.Drawing.Point(597, 357);
            this.URbutton.Name = "URbutton";
            this.URbutton.Size = new System.Drawing.Size(119, 41);
            this.URbutton.TabIndex = 11;
            this.URbutton.Text = "Update Record";
            this.URbutton.UseVisualStyleBackColor = false;
            this.URbutton.Click += new System.EventHandler(this.URbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitbutton.BackColor = System.Drawing.Color.LightGray;
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Black;
            this.exitbutton.Location = new System.Drawing.Point(827, 357);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(119, 41);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertbutton.BackColor = System.Drawing.Color.LightGray;
            this.insertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton.ForeColor = System.Drawing.Color.Black;
            this.insertbutton.Location = new System.Drawing.Point(123, 357);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(122, 41);
            this.insertbutton.TabIndex = 9;
            this.insertbutton.Text = "Insert Record";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // textBoxclass
            // 
            this.textBoxclass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxclass.Location = new System.Drawing.Point(180, 255);
            this.textBoxclass.Name = "textBoxclass";
            this.textBoxclass.Size = new System.Drawing.Size(157, 24);
            this.textBoxclass.TabIndex = 8;
            // 
            // textBoxFN
            // 
            this.textBoxFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFN.Location = new System.Drawing.Point(180, 197);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(157, 24);
            this.textBoxFN.TabIndex = 7;
            // 
            // textBoxsur
            // 
            this.textBoxsur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsur.Location = new System.Drawing.Point(180, 136);
            this.textBoxsur.Name = "textBoxsur";
            this.textBoxsur.Size = new System.Drawing.Size(157, 24);
            this.textBoxsur.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Location = new System.Drawing.Point(180, 75);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(157, 24);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelabel.Location = new System.Drawing.Point(93, 140);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(62, 16);
            this.surnamelabel.TabIndex = 4;
            this.surnamelabel.Text = "Surname";
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(93, 201);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(73, 16);
            this.FNlabel.TabIndex = 3;
            this.FNlabel.Text = "First Name";
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.Location = new System.Drawing.Point(93, 259);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(42, 16);
            this.classlabel.TabIndex = 2;
            this.classlabel.Text = "Class";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(93, 79);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(69, 16);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "Student ID";
            // 
            // sTUDENTSBindingSource
            // 
            this.sTUDENTSBindingSource.DataMember = "STUDENTS";
            this.sTUDENTSBindingSource.DataSource = this.dataSet;
            // 
            // sTUDENTSTableAdapter
            // 
            this.sTUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // Interface1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1026, 489);
            this.Controls.Add(this.SIS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student information System iterface";
            this.Load += new System.EventHandler(this.Interface1_Load);
            this.SIS.ResumeLayout(false);
            this.SIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEASstudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SIS;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.TextBox textBoxclass;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxsur;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label surnamelabel;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label classlabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button URbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.DataGridView CEASstudents;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource;
        private DataSetTableAdapters.STUDENTSTableAdapter sTUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTUDENTSBindingSource1;
    }
}

