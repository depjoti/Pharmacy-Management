﻿namespace MEDICAL
{
    partial class StockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnitemsearch = new System.Windows.Forms.Button();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncomsearch = new System.Windows.Forms.Button();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GVReports = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(413, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCKIN REPORT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnitemsearch);
            this.groupBox1.Controls.Add(this.txtiname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btncomsearch);
            this.groupBox1.Controls.Add(this.txtcname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(196, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Report";
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
            // btncomsearch
            // 
            this.btncomsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomsearch.Location = new System.Drawing.Point(151, 49);
            this.btncomsearch.Name = "btncomsearch";
            this.btncomsearch.Size = new System.Drawing.Size(100, 28);
            this.btncomsearch.TabIndex = 12;
            this.btncomsearch.Text = "Search";
            this.btncomsearch.UseVisualStyleBackColor = true;
            this.btncomsearch.Click += new System.EventHandler(this.btncomsearch_Click);
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
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Company Name :";
            // 
            // GVReports
            // 
            this.GVReports.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.GVReports.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.GVReports.Location = new System.Drawing.Point(196, 254);
            this.GVReports.Name = "GVReports";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.GVReports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GVReports.Size = new System.Drawing.Size(853, 305);
            this.GVReports.TabIndex = 4;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1225, 742);
            this.Controls.Add(this.GVReports);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnitemsearch;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GVReports;
        private System.Windows.Forms.Button btncomsearch;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label label6;
    }
}