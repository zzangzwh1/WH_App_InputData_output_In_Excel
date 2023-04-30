
namespace WH_App_InputData_output_In_Excel
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
            this._idText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._salary = new System.Windows.Forms.TextBox();
            this._addBtn = new System.Windows.Forms.Button();
            this._show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._caldenr = new System.Windows.Forms.DateTimePicker();
            this._createExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // _idText
            // 
            this._idText.Location = new System.Drawing.Point(28, 166);
            this._idText.Multiline = true;
            this._idText.Name = "_idText";
            this._idText.Size = new System.Drawing.Size(237, 36);
            this._idText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emplyee Name";
            // 
            // _nameText
            // 
            this._nameText.Location = new System.Drawing.Point(28, 251);
            this._nameText.Multiline = true;
            this._nameText.Name = "_nameText";
            this._nameText.Size = new System.Drawing.Size(237, 36);
            this._nameText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary";
            // 
            // _salary
            // 
            this._salary.Location = new System.Drawing.Point(28, 436);
            this._salary.Multiline = true;
            this._salary.Name = "_salary";
            this._salary.Size = new System.Drawing.Size(237, 36);
            this._salary.TabIndex = 7;
            // 
            // _addBtn
            // 
            this._addBtn.Location = new System.Drawing.Point(28, 504);
            this._addBtn.Name = "_addBtn";
            this._addBtn.Size = new System.Drawing.Size(100, 41);
            this._addBtn.TabIndex = 8;
            this._addBtn.Text = "Add";
            this._addBtn.UseVisualStyleBackColor = true;
            // 
            // _show
            // 
            this._show.Location = new System.Drawing.Point(165, 504);
            this._show.Name = "_show";
            this._show.Size = new System.Drawing.Size(100, 41);
            this._show.TabIndex = 9;
            this._show.Text = "Show";
            this._show.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 100);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(198, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 306);
            this.dataGridView1.TabIndex = 11;
            // 
            // _caldenr
            // 
            this._caldenr.Location = new System.Drawing.Point(28, 355);
            this._caldenr.Name = "_caldenr";
            this._caldenr.Size = new System.Drawing.Size(237, 22);
            this._caldenr.TabIndex = 13;
            // 
            // _createExcel
            // 
            this._createExcel.Location = new System.Drawing.Point(477, 504);
            this._createExcel.Name = "_createExcel";
            this._createExcel.Size = new System.Drawing.Size(126, 41);
            this._createExcel.TabIndex = 14;
            this._createExcel.Text = "Create Excel";
            this._createExcel.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this._createExcel);
            this.Controls.Add(this._caldenr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._show);
            this.Controls.Add(this._addBtn);
            this.Controls.Add(this._salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._idText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _salary;
        private System.Windows.Forms.Button _addBtn;
        private System.Windows.Forms.Button _show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker _caldenr;
        private System.Windows.Forms.Button _createExcel;
    }
}

