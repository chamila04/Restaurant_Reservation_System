namespace Restaurant_Reservation_system
{
    partial class GRIDVIEW
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIRST_NAME,
            this.LAST_NAME,
            this.USER_NAME,
            this.PASSWORD,
            this.ACCESS});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(808, 580);
            this.dataGridView2.TabIndex = 1;
            // 
            // ID
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.HeaderText = "first_name";
            this.FIRST_NAME.MinimumWidth = 6;
            this.FIRST_NAME.Name = "FIRST_NAME";
            this.FIRST_NAME.Width = 125;
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "last_name";
            this.LAST_NAME.MinimumWidth = 6;
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.Width = 125;
            // 
            // USER_NAME
            // 
            this.USER_NAME.HeaderText = "username";
            this.USER_NAME.MinimumWidth = 6;
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.Width = 125;
            // 
            // PASSWORD
            // 
            this.PASSWORD.HeaderText = "password";
            this.PASSWORD.MinimumWidth = 6;
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Width = 125;
            // 
            // ACCESS
            // 
            this.ACCESS.HeaderText = "access";
            this.ACCESS.MinimumWidth = 6;
            this.ACCESS.Name = "ACCESS";
            this.ACCESS.Width = 125;
            // 
            // GRIDVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 580);
            this.Controls.Add(this.dataGridView2);
            this.Name = "GRIDVIEW";
            this.Text = "GRIDVIEW";
            this.Load += new System.EventHandler(this.GRIDVIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCESS;
    }
}