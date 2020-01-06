namespace ThemeGenerator
{
    partial class Main
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
            this.btnButton = new System.Windows.Forms.Button();
            this.ppg = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearObject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tlp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(6, 19);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(83, 32);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Add Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // ppg
            // 
            this.ppg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppg.Location = new System.Drawing.Point(456, 12);
            this.ppg.Name = "ppg";
            this.ppg.Size = new System.Drawing.Size(265, 386);
            this.ppg.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tlp);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 259);
            this.panel1.TabIndex = 2;
            // 
            // tlp
            // 
            this.tlp.AutoScroll = true;
            this.tlp.AutoSize = true;
            this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Controls.Add(this.flp, 0, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(436, 257);
            this.tlp.TabIndex = 0;
            // 
            // flp
            // 
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Location = new System.Drawing.Point(218, 3);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(0, 251);
            this.flp.TabIndex = 0;
            // 
            // btnRemoveObject
            // 
            this.btnRemoveObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveObject.Location = new System.Drawing.Point(12, 340);
            this.btnRemoveObject.Name = "btnRemoveObject";
            this.btnRemoveObject.Size = new System.Drawing.Size(126, 58);
            this.btnRemoveObject.TabIndex = 3;
            this.btnRemoveObject.Text = "&Remove Object";
            this.btnRemoveObject.UseVisualStyleBackColor = true;
            this.btnRemoveObject.Click += new System.EventHandler(this.btnRemoveObject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnClearObject
            // 
            this.btnClearObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearObject.Location = new System.Drawing.Point(144, 340);
            this.btnClearObject.Name = "btnClearObject";
            this.btnClearObject.Size = new System.Drawing.Size(126, 58);
            this.btnClearObject.TabIndex = 5;
            this.btnClearObject.Text = "&Clear Object";
            this.btnClearObject.UseVisualStyleBackColor = true;
            this.btnClearObject.Click += new System.EventHandler(this.btnClearObject_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 410);
            this.Controls.Add(this.btnClearObject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveObject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ppg);
            this.MinimumSize = new System.Drawing.Size(739, 449);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.PropertyGrid ppg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btnRemoveObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearObject;
    }
}

