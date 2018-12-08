namespace ColorVisionTest
{
    partial class SaveBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YourName = new System.Windows.Forms.TextBox();
            this.YourProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourName
            // 
            this.YourName.Location = new System.Drawing.Point(310, 169);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(274, 22);
            this.YourName.TabIndex = 1;
            // 
            // YourProperty
            // 
            this.YourProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YourProperty.FlatAppearance.BorderSize = 0;
            this.YourProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YourProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourProperty.Location = new System.Drawing.Point(0, 0);
            this.YourProperty.Name = "YourProperty";
            this.YourProperty.Size = new System.Drawing.Size(802, 149);
            this.YourProperty.TabIndex = 4;
            this.YourProperty.Text = "Your color vision is superb. You wouldn\'t have any problems surviving in the jung" +
    "le. You can see when the neighbouring tiger visits the bathroom faaaar away.";
            this.YourProperty.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Your Name To Save";
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok.Location = new System.Drawing.Point(626, 149);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(154, 67);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // SaveBox
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(792, 228);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourProperty);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.YourName);
            this.Name = "SaveBox";
            this.Text = "End Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox YourName;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button YourProperty;
        private System.Windows.Forms.Label label1;
    }
}