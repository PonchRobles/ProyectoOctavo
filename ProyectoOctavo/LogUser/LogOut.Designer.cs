namespace ProyectoOctavo
{
    partial class LogOut
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
            this.txtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(201, 226);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(75, 23);
            this.txtSalir.TabIndex = 0;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtSalir);
            this.Name = "LogOut";
            this.Text = "LogOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtSalir;
    }
}