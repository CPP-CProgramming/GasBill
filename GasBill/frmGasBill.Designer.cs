namespace GasBill
{
    partial class billFrm
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
            this.btnGas = new System.Windows.Forms.Button();
            this.btnHydroBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGas
            // 
            this.btnGas.Location = new System.Drawing.Point(222, 106);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(174, 76);
            this.btnGas.TabIndex = 0;
            this.btnGas.Text = "Gas";
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // btnHydroBill
            // 
            this.btnHydroBill.Location = new System.Drawing.Point(222, 253);
            this.btnHydroBill.Name = "btnHydroBill";
            this.btnHydroBill.Size = new System.Drawing.Size(174, 72);
            this.btnHydroBill.TabIndex = 1;
            this.btnHydroBill.Text = "Hydro Bill";
            this.btnHydroBill.UseVisualStyleBackColor = true;
            this.btnHydroBill.Click += new System.EventHandler(this.btnHydroBill_Click);
            // 
            // billFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 429);
            this.Controls.Add(this.btnHydroBill);
            this.Controls.Add(this.btnGas);
            this.Name = "billFrm";
            this.Text = "Bill Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnHydroBill;
    }
}

