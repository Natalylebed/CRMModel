
namespace CRMVinForm
{
    partial class Catalog<T>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Changebutton2 = new System.Windows.Forms.Button();
            this.Deletebutton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 306);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Addbutton1
            // 
            this.Addbutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Addbutton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addbutton1.Location = new System.Drawing.Point(147, 330);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(100, 38);
            this.Addbutton1.TabIndex = 1;
            this.Addbutton1.Text = "Добавить";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.AddCatalog_Click);
            // 
            // Changebutton2
            // 
            this.Changebutton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Changebutton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Changebutton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Changebutton2.Location = new System.Drawing.Point(253, 330);
            this.Changebutton2.Name = "Changebutton2";
            this.Changebutton2.Size = new System.Drawing.Size(105, 38);
            this.Changebutton2.TabIndex = 2;
            this.Changebutton2.Text = "Изменить";
            this.Changebutton2.UseVisualStyleBackColor = true;
            this.Changebutton2.Click += new System.EventHandler(this.ChangeCatalog_Click);
            // 
            // Deletebutton3
            // 
            this.Deletebutton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletebutton3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Deletebutton3.Location = new System.Drawing.Point(364, 330);
            this.Deletebutton3.Name = "Deletebutton3";
            this.Deletebutton3.Size = new System.Drawing.Size(100, 38);
            this.Deletebutton3.TabIndex = 3;
            this.Deletebutton3.Text = "Удалить";
            this.Deletebutton3.UseVisualStyleBackColor = true;
            this.Deletebutton3.Click += new System.EventHandler(this.DeleteCatalog_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 374);
            this.Controls.Add(this.Deletebutton3);
            this.Controls.Add(this.Changebutton2);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Catalog";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Changebutton2;
        private System.Windows.Forms.Button Deletebutton3;
    }
}