namespace Restaurant_Reservation_system
{
    partial class employee_details
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FIRST_NAME,
            this.LAST_NAME,
            this.ADDRESS,
            this.position,
            this.telephone});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.HeaderText = "FIST_NAME";
            this.FIRST_NAME.MinimumWidth = 6;
            this.FIRST_NAME.Name = "FIRST_NAME";
            this.FIRST_NAME.Width = 125;
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "LAST_NAME";
            this.LAST_NAME.MinimumWidth = 6;
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.Width = 125;
            // 
            // ADDRESS
            // 
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.MinimumWidth = 6;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 125;
            // 
            // position
            // 
            this.position.HeaderText = "position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 125;
            // 
            // telephone
            // 
            dataGridViewCellStyle1.Format = "N6";
            dataGridViewCellStyle1.NullValue = null;
            this.telephone.DefaultCellStyle = dataGridViewCellStyle1;
            this.telephone.HeaderText = "telephone\t";
            this.telephone.MinimumWidth = 6;
            this.telephone.Name = "telephone";
            this.telephone.Width = 125;
            // 
            // employee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 436);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employee_details";
            this.Text = "employee_details";
            this.Load += new System.EventHandler(this.employee_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
    }
}