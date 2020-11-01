using System.Windows.Forms;

namespace Gestion.Views
{
    public partial class MenuView
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
            this.BttnBuscar = new System.Windows.Forms.Button();
            this.BttnVisualizar = new System.Windows.Forms.Button();
            this.BttnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnBuscar
            // 
            this.BttnBuscar.Location = new System.Drawing.Point(133, 83);
            this.BttnBuscar.Name = "bttnBuscar";
            this.BttnBuscar.Size = new System.Drawing.Size(108, 46);
            this.BttnBuscar.TabIndex = 0;
            this.BttnBuscar.Text = "Buscar Alumno";
            this.BttnBuscar.UseVisualStyleBackColor = true;
            this.BttnBuscar.Click += new System.EventHandler(this.BttnBuscar_Click);
            // 
            // bttnVisualizar
            // 
            this.BttnVisualizar.Location = new System.Drawing.Point(133, 148);
            this.BttnVisualizar.Name = "bttnVisualizar";
            this.BttnVisualizar.Size = new System.Drawing.Size(108, 44);
            this.BttnVisualizar.TabIndex = 1;
            this.BttnVisualizar.Text = "Visualizar Alumno";
            this.BttnVisualizar.UseVisualStyleBackColor = true;
            this.BttnVisualizar.Click += new System.EventHandler(this.BttnVisualizar_Click);
            // 
            // bttnSalir
            // 
            this.BttnSalir.Location = new System.Drawing.Point(133, 209);
            this.BttnSalir.Name = "bttnSalir";
            this.BttnSalir.Size = new System.Drawing.Size(108, 44);
            this.BttnSalir.TabIndex = 2;
            this.BttnSalir.Text = "Salir";
            this.BttnSalir.UseVisualStyleBackColor = true;
            this.BttnSalir.Click += new System.EventHandler(this.BttnSalir_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 344);
            this.Controls.Add(this.BttnSalir);
            this.Controls.Add(this.BttnVisualizar);
            this.Controls.Add(this.BttnBuscar);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnBuscar;
        private System.Windows.Forms.Button BttnVisualizar;
        private System.Windows.Forms.Button BttnSalir;

        
    }
}