namespace MilestonerApp
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
            this.AddPoint = new System.Windows.Forms.Button();
            this.DeletePoint = new System.Windows.Forms.Button();
            this.ChangeName = new System.Windows.Forms.Button();
            this.NameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PointsBox = new System.Windows.Forms.ComboBox();
            this.ResolutionEntry = new System.Windows.Forms.TextBox();
            this.SetResolutionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderEntry = new System.Windows.Forms.TextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SetBackgroundButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPoint
            // 
            this.AddPoint.Location = new System.Drawing.Point(12, 120);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(114, 23);
            this.AddPoint.TabIndex = 1;
            this.AddPoint.Text = "Add a Point";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // DeletePoint
            // 
            this.DeletePoint.Location = new System.Drawing.Point(12, 149);
            this.DeletePoint.Name = "DeletePoint";
            this.DeletePoint.Size = new System.Drawing.Size(114, 23);
            this.DeletePoint.TabIndex = 2;
            this.DeletePoint.Text = "Delete a Point";
            this.DeletePoint.UseVisualStyleBackColor = true;
            // 
            // ChangeName
            // 
            this.ChangeName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeName.Location = new System.Drawing.Point(12, 91);
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(114, 23);
            this.ChangeName.TabIndex = 3;
            this.ChangeName.Text = "Change the Name";
            this.ChangeName.UseVisualStyleBackColor = false;
            this.ChangeName.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameEntry
            // 
            this.NameEntry.Location = new System.Drawing.Point(12, 65);
            this.NameEntry.Name = "NameEntry";
            this.NameEntry.Size = new System.Drawing.Size(114, 20);
            this.NameEntry.TabIndex = 5;
            this.NameEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PointsBox
            // 
            this.PointsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointsBox.FormattingEnabled = true;
            this.PointsBox.Location = new System.Drawing.Point(12, 22);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.Size = new System.Drawing.Size(114, 21);
            this.PointsBox.TabIndex = 9;
            this.PointsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ResolutionEntry
            // 
            this.ResolutionEntry.Location = new System.Drawing.Point(292, 22);
            this.ResolutionEntry.Name = "ResolutionEntry";
            this.ResolutionEntry.Size = new System.Drawing.Size(114, 20);
            this.ResolutionEntry.TabIndex = 10;
            this.ResolutionEntry.Text = "*x*";
            // 
            // SetResolutionButton
            // 
            this.SetResolutionButton.Location = new System.Drawing.Point(292, 48);
            this.SetResolutionButton.Name = "SetResolutionButton";
            this.SetResolutionButton.Size = new System.Drawing.Size(114, 23);
            this.SetResolutionButton.TabIndex = 11;
            this.SetResolutionButton.Text = "Set Resolution";
            this.SetResolutionButton.UseVisualStyleBackColor = true;
            this.SetResolutionButton.Click += new System.EventHandler(this.SetResolutionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resolution";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order";
            // 
            // OrderEntry
            // 
            this.OrderEntry.Location = new System.Drawing.Point(155, 22);
            this.OrderEntry.Name = "OrderEntry";
            this.OrderEntry.Size = new System.Drawing.Size(114, 20);
            this.OrderEntry.TabIndex = 14;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(155, 48);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(114, 23);
            this.OrderButton.TabIndex = 13;
            this.OrderButton.Text = "Change the Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Point";
            // 
            // SetBackgroundButton
            // 
            this.SetBackgroundButton.Location = new System.Drawing.Point(219, 119);
            this.SetBackgroundButton.Name = "SetBackgroundButton";
            this.SetBackgroundButton.Size = new System.Drawing.Size(142, 53);
            this.SetBackgroundButton.TabIndex = 17;
            this.SetBackgroundButton.Text = "Set the Background";
            this.SetBackgroundButton.UseVisualStyleBackColor = true;
            this.SetBackgroundButton.Click += new System.EventHandler(this.SetBackgroundButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(189, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Won\'t work if wallpaper engine is running";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetBackgroundButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderEntry);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetResolutionButton);
            this.Controls.Add(this.ResolutionEntry);
            this.Controls.Add(this.PointsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameEntry);
            this.Controls.Add(this.ChangeName);
            this.Controls.Add(this.DeletePoint);
            this.Controls.Add(this.AddPoint);
            this.Name = "Form1";
            this.Text = "MilestonerBeta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.Button DeletePoint;
        private System.Windows.Forms.Button ChangeName;
        private System.Windows.Forms.TextBox NameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PointsBox;
        private System.Windows.Forms.TextBox ResolutionEntry;
        private System.Windows.Forms.Button SetResolutionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderEntry;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetBackgroundButton;
        private System.Windows.Forms.Label label5;
    }
}

