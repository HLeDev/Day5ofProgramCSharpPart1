
namespace Week5Day3Ex1._1
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
            this.gridEmpList = new System.Windows.Forms.DataGridView();
            this.lblEmpListHEader = new System.Windows.Forms.Label();
            this.grpEmpInsert = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.grpDelEmployee = new System.Windows.Forms.GroupBox();
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.lblDelID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpList)).BeginInit();
            this.grpEmpInsert.SuspendLayout();
            this.grpDelEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmpList
            // 
            this.gridEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpList.Location = new System.Drawing.Point(3, 346);
            this.gridEmpList.Name = "gridEmpList";
            this.gridEmpList.Size = new System.Drawing.Size(501, 248);
            this.gridEmpList.TabIndex = 0;
            // 
            // lblEmpListHEader
            // 
            this.lblEmpListHEader.AutoSize = true;
            this.lblEmpListHEader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpListHEader.Location = new System.Drawing.Point(-2, 314);
            this.lblEmpListHEader.Name = "lblEmpListHEader";
            this.lblEmpListHEader.Size = new System.Drawing.Size(203, 29);
            this.lblEmpListHEader.TabIndex = 1;
            this.lblEmpListHEader.Text = "List of Employees";
            // 
            // grpEmpInsert
            // 
            this.grpEmpInsert.Controls.Add(this.btnAddEmp);
            this.grpEmpInsert.Controls.Add(this.txtLN);
            this.grpEmpInsert.Controls.Add(this.txtFN);
            this.grpEmpInsert.Controls.Add(this.txtID);
            this.grpEmpInsert.Controls.Add(this.lblLN);
            this.grpEmpInsert.Controls.Add(this.lblFN);
            this.grpEmpInsert.Controls.Add(this.lblEmpID);
            this.grpEmpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmpInsert.Location = new System.Drawing.Point(3, 51);
            this.grpEmpInsert.Name = "grpEmpInsert";
            this.grpEmpInsert.Size = new System.Drawing.Size(719, 260);
            this.grpEmpInsert.TabIndex = 2;
            this.grpEmpInsert.TabStop = false;
            this.grpEmpInsert.Text = "New Employee";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(7, 46);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(129, 25);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(7, 101);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(204, 25);
            this.lblFN.TabIndex = 1;
            this.lblFN.Text = "Employee First Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(6, 154);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(204, 25);
            this.lblLN.TabIndex = 2;
            this.lblLN.Text = "Employee Last Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(217, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(284, 30);
            this.txtID.TabIndex = 3;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(217, 96);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(284, 30);
            this.txtFN.TabIndex = 4;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(217, 149);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(284, 30);
            this.txtLN.TabIndex = 5;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(217, 210);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(284, 44);
            this.btnAddEmp.TabIndex = 6;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // grpDelEmployee
            // 
            this.grpDelEmployee.Controls.Add(this.btnDelete);
            this.grpDelEmployee.Controls.Add(this.lblDelID);
            this.grpDelEmployee.Controls.Add(this.txtDelID);
            this.grpDelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelEmployee.Location = new System.Drawing.Point(511, 317);
            this.grpDelEmployee.Name = "grpDelEmployee";
            this.grpDelEmployee.Size = new System.Drawing.Size(211, 277);
            this.grpDelEmployee.TabIndex = 3;
            this.grpDelEmployee.TabStop = false;
            this.grpDelEmployee.Text = "Delete Employee";
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(95, 61);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(100, 30);
            this.txtDelID.TabIndex = 0;
            // 
            // lblDelID
            // 
            this.lblDelID.AutoSize = true;
            this.lblDelID.Location = new System.Drawing.Point(6, 66);
            this.lblDelID.Name = "lblDelID";
            this.lblDelID.Size = new System.Drawing.Size(82, 25);
            this.lblDelID.TabIndex = 1;
            this.lblDelID.Text = "Emp ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete!!!";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 597);
            this.Controls.Add(this.grpDelEmployee);
            this.Controls.Add(this.grpEmpInsert);
            this.Controls.Add(this.lblEmpListHEader);
            this.Controls.Add(this.gridEmpList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpList)).EndInit();
            this.grpEmpInsert.ResumeLayout(false);
            this.grpEmpInsert.PerformLayout();
            this.grpDelEmployee.ResumeLayout(false);
            this.grpDelEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmpList;
        private System.Windows.Forms.Label lblEmpListHEader;
        private System.Windows.Forms.GroupBox grpEmpInsert;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpDelEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDelID;
        private System.Windows.Forms.TextBox txtDelID;
    }
}

