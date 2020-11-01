using System.Windows.Forms;

namespace Gestion.Views
{
    public partial class ListView
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BttnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(13, 13);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(439, 291);
            this.DataGridView.TabIndex = 0;
            // 
            // BttnVolver
            // 
            this.BttnVolver.Location = new System.Drawing.Point(12, 360);
            this.BttnVolver.Name = "BttnVolver";
            this.BttnVolver.Size = new System.Drawing.Size(109, 30);
            this.BttnVolver.TabIndex = 1;
            this.BttnVolver.Text = "<= Atrás";
            this.BttnVolver.UseVisualStyleBackColor = true;
            this.BttnVolver.Click += new System.EventHandler(this.BttnVolver_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 407);
            this.Controls.Add(this.BttnVolver);
            this.Controls.Add(this.DataGridView);
            this.Name = "ListView";
            this.Text = "ListView";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BttnVolver;

        public DataGridView GetDataGridView
        {
            get
            {
                return DataGridView;
            }
        }

        public Button GetBttnVolver
        {
            get 
            {
                return BttnVolver;
            }
        }
    }
}