namespace Recursividad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ActiveCaption;
            lbl1.Location = new Point(88, 58);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(127, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "INGRESA UN NÚMERO";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(68, 94);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(170, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Location = new Point(68, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(170, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Factorial";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.ActiveCaption;
            lblResultado.Location = new Point(68, 195);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
