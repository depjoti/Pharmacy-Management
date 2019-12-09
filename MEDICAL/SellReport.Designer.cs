namespace MEDICAL
{
    partial class SellReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVReports = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnitemsearch = new System.Windows.Forms.Button();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncustsearch = new System.Windows.Forms.Button();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVReports
            // 
            this.GVReports.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GVReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVReports.DefaultCellStyle = dataGridViewCellStyle5;
            this.GVReports.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.GVReports.Location = new System.Drawing.Point(186, 260);
            this.GVReports.Name = "GVReports";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Purple;
            this.GVReports.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GVReports.Size = new System.Drawing.Size(853, 305);
            this.GVReports.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnitemsearch);
            this.groupBox1.Controls.Add(this.txtiname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btncustsearch);
            this.groupBox1.Controls.Add(this.txtcname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(186, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Report";
            // 
            // btnitemsearch
            // 
            this.btnitemsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemsearch.Location = new System.Drawing.Point(666, 49);
            this.btnitemsearch.Name = "btnitemsearch";
            this.btnitemsearch.Size = new System.Drawing.Size(100, 28);
            this.btnitemsearch.TabIndex = 15;
            this.btnitemsearch.Text = "Search";
            this.btnitemsearch.UseVisualStyleBackColor = true;
            this.btnitemsearch.Click += new System.EventHandler(this.btnitemsearch_Click);
            // 
            // txtiname
            // 
            this.txtiname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtiname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtiname.BackColor = System.Drawing.Color.Honeydew;
            this.txtiname.Location = new System.Drawing.Point(666, 23);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(160, 20);
            this.txtiname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(568, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item Name :";
            // 
            // btncustsearch
            // 
            this.btncustsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustsearch.Location = new System.Drawing.Point(151, 49);
            this.btncustsearch.Name = "btncustsearch";
            this.btncustsearch.Size = new System.Drawing.Size(100, 28);
            this.btncustsearch.TabIndex = 12;
            this.btncustsearch.Text = "Search";
            this.btncustsearch.UseVisualStyleBackColor = true;
            this.btncustsearch.Click += new System.EventHandler(this.btncustsearch_Click);
            // 
            // txtcname
            // 
            this.txtcname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcname.BackColor = System.Drawing.Color.Honeydew;
            this.txtcname.Location = new System.Drawing.Point(151, 23);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(160, 20);
            this.txtcname.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(443, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "SALES REPORT";
            // 
            // SellReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1225, 742);
            this.Controls.Add(this.GVReports);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SellReport";
            this.Text = "SellReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnitemsearch;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncustsearch;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}