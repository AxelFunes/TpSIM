namespace TpSIM.Formularios
{
    partial class Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bNormal = new System.Windows.Forms.Button();
            this.bUniforme = new System.Windows.Forms.Button();
            this.bExponencial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "DISTRIBUCIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elija una distribución para la generación de numeros aleatorios";
            // 
            // bNormal
            // 
            this.bNormal.BackColor = System.Drawing.Color.Silver;
            this.bNormal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNormal.Location = new System.Drawing.Point(215, 284);
            this.bNormal.Name = "bNormal";
            this.bNormal.Size = new System.Drawing.Size(328, 38);
            this.bNormal.TabIndex = 9;
            this.bNormal.Text = "Normal";
            this.bNormal.UseVisualStyleBackColor = false;
            this.bNormal.Click += new System.EventHandler(this.bNormal_Click);
            // 
            // bUniforme
            // 
            this.bUniforme.BackColor = System.Drawing.Color.Silver;
            this.bUniforme.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUniforme.Location = new System.Drawing.Point(215, 175);
            this.bUniforme.Name = "bUniforme";
            this.bUniforme.Size = new System.Drawing.Size(328, 38);
            this.bUniforme.TabIndex = 6;
            this.bUniforme.Text = "Uniforme";
            this.bUniforme.UseVisualStyleBackColor = false;
            this.bUniforme.Click += new System.EventHandler(this.bUniforme_Click);
            // 
            // bExponencial
            // 
            this.bExponencial.BackColor = System.Drawing.Color.Silver;
            this.bExponencial.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExponencial.Location = new System.Drawing.Point(215, 228);
            this.bExponencial.Name = "bExponencial";
            this.bExponencial.Size = new System.Drawing.Size(328, 38);
            this.bExponencial.TabIndex = 7;
            this.bExponencial.Text = "Exponencial";
            this.bExponencial.UseVisualStyleBackColor = false;
            this.bExponencial.Click += new System.EventHandler(this.bExponencial_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNormal);
            this.Controls.Add(this.bUniforme);
            this.Controls.Add(this.bExponencial);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bNormal;
        private System.Windows.Forms.Button bUniforme;
        private System.Windows.Forms.Button bExponencial;
    }
}