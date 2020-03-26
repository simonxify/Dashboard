namespace Dashboard
{
    partial class Result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblResultDisplacement = new System.Windows.Forms.Label();
            this.txtTotalDisplacement = new System.Windows.Forms.TextBox();
            this.lblResultForce = new System.Windows.Forms.Label();
            this.txtTotalForce = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.pnlColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.gridResult);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 315);
            this.panel1.TabIndex = 0;
            // 
            // gridResult
            // 
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(3, 3);
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(292, 309);
            this.gridResult.TabIndex = 0;
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlColor.Controls.Add(this.txtFileName);
            this.pnlColor.Controls.Add(this.lblResultDisplacement);
            this.pnlColor.Controls.Add(this.txtTotalDisplacement);
            this.pnlColor.Controls.Add(this.lblResultForce);
            this.pnlColor.Controls.Add(this.txtTotalForce);
            this.pnlColor.Controls.Add(this.lblResult);
            this.pnlColor.Location = new System.Drawing.Point(317, 13);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(402, 315);
            this.pnlColor.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(34, 8);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(244, 26);
            this.txtFileName.TabIndex = 5;
            // 
            // lblResultDisplacement
            // 
            this.lblResultDisplacement.AutoSize = true;
            this.lblResultDisplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDisplacement.Location = new System.Drawing.Point(34, 141);
            this.lblResultDisplacement.Name = "lblResultDisplacement";
            this.lblResultDisplacement.Size = new System.Drawing.Size(145, 20);
            this.lblResultDisplacement.TabIndex = 4;
            this.lblResultDisplacement.Text = "Total Displacement";
            // 
            // txtTotalDisplacement
            // 
            this.txtTotalDisplacement.Enabled = false;
            this.txtTotalDisplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDisplacement.Location = new System.Drawing.Point(244, 138);
            this.txtTotalDisplacement.Name = "txtTotalDisplacement";
            this.txtTotalDisplacement.Size = new System.Drawing.Size(100, 26);
            this.txtTotalDisplacement.TabIndex = 3;
            // 
            // lblResultForce
            // 
            this.lblResultForce.AutoSize = true;
            this.lblResultForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultForce.Location = new System.Drawing.Point(34, 106);
            this.lblResultForce.Name = "lblResultForce";
            this.lblResultForce.Size = new System.Drawing.Size(89, 20);
            this.lblResultForce.TabIndex = 2;
            this.lblResultForce.Text = "Total Force";
            // 
            // txtTotalForce
            // 
            this.txtTotalForce.Enabled = false;
            this.txtTotalForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalForce.Location = new System.Drawing.Point(244, 106);
            this.txtTotalForce.Name = "txtTotalForce";
            this.txtTotalForce.Size = new System.Drawing.Size(100, 26);
            this.txtTotalForce.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(34, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Total";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.panel1);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtTotalForce;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultDisplacement;
        private System.Windows.Forms.TextBox txtTotalDisplacement;
        private System.Windows.Forms.Label lblResultForce;
        private System.Windows.Forms.TextBox txtFileName;
    }
}