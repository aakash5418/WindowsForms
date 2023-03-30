namespace Tickects
{
    partial class FrmTickets
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
            this.btnTickects = new System.Windows.Forms.Button();
            this.btnGas = new System.Windows.Forms.Button();
            this.btnHydro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTickects
            // 
            this.btnTickects.Location = new System.Drawing.Point(237, 97);
            this.btnTickects.Name = "btnTickects";
            this.btnTickects.Size = new System.Drawing.Size(280, 48);
            this.btnTickects.TabIndex = 0;
            this.btnTickects.Text = "DetermineTickets";
            this.btnTickects.UseVisualStyleBackColor = true;
            this.btnTickects.Click += new System.EventHandler(this.btnTickects_Click);
            // 
            // btnGas
            // 
            this.btnGas.Location = new System.Drawing.Point(237, 233);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(280, 47);
            this.btnGas.TabIndex = 1;
            this.btnGas.Text = "Gas";
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHydro
            // 
            this.btnHydro.Location = new System.Drawing.Point(237, 362);
            this.btnHydro.Name = "btnHydro";
            this.btnHydro.Size = new System.Drawing.Size(280, 47);
            this.btnHydro.TabIndex = 2;
            this.btnHydro.Text = "HydroGas";
            this.btnHydro.UseVisualStyleBackColor = true;
            this.btnHydro.Click += new System.EventHandler(this.btnHydro_Click);
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHydro);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.btnTickects);
            this.Name = "FrmTickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTickects;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnHydro;
    }
}

