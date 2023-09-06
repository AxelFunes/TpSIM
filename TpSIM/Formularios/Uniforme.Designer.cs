namespace TpSIM.Formularios
{
    partial class Uniforme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimiteA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtLimiteB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLimiteA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtLimiteB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(29, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 190);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese los límites";
            // 
            // txtLimiteA
            // 
            this.txtLimiteA.Location = new System.Drawing.Point(126, 69);
            this.txtLimiteA.Name = "txtLimiteA";
            this.txtLimiteA.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteA.TabIndex = 0;
            this.txtLimiteA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Límite inferior A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Límite superior B";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(126, 137);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtLimiteB
            // 
            this.txtLimiteB.Location = new System.Drawing.Point(126, 104);
            this.txtLimiteB.Name = "txtLimiteB";
            this.txtLimiteB.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteB.TabIndex = 1;
            this.txtLimiteB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(49, 358);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(220, 24);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.Location = new System.Drawing.Point(49, 286);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(220, 24);
            this.btnGrafico.TabIndex = 18;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // grilla
            // 
            this.grilla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.RND,
            this.Valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla.Location = new System.Drawing.Point(329, 49);
            this.grilla.Name = "grilla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.Size = new System.Drawing.Size(428, 332);
            this.grilla.TabIndex = 20;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
            // 
            // RND
            // 
            this.RND.HeaderText = "RND";
            this.RND.MinimumWidth = 6;
            this.RND.Name = "RND";
            this.RND.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 125;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(49, 256);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(220, 24);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Uniforme";
            this.Text = "Uniforme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLimiteA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtLimiteB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btnGenerar;
    }
}