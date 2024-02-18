namespace Restaurant_Reservation_system
{
    partial class DeleteEmployee
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
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(307, 280);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // nameText
            // 
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.DefaultText = "";
            this.nameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameText.Location = new System.Drawing.Point(254, 126);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.PlaceholderText = "enter employee first name";
            this.nameText.SelectedText = "";
            this.nameText.Size = new System.Drawing.Size(293, 53);
            this.nameText.TabIndex = 3;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.nameText);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
    }
}