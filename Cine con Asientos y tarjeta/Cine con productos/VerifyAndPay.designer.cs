namespace Cine
{
    partial class VerifyAndPay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYY = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonBackFromPay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtYY
            // 
            this.txtYY.FormattingEnabled = true;
            this.txtYY.Location = new System.Drawing.Point(698, 248);
            this.txtYY.Name = "txtYY";
            this.txtYY.Size = new System.Drawing.Size(49, 21);
            this.txtYY.TabIndex = 19;
            this.txtYY.Text = "YY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "/";
            // 
            // txtMM
            // 
            this.txtMM.FormattingEnabled = true;
            this.txtMM.Location = new System.Drawing.Point(623, 247);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(51, 21);
            this.txtMM.TabIndex = 17;
            this.txtMM.Text = "MM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de Expiración";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(425, 249);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(100, 20);
            this.txtCVV.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CVV";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(425, 163);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(178, 20);
            this.txtTitular.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del Titular";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(422, 78);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(181, 20);
            this.txtTarjeta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero de Tarjeta";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(51, 317);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(169, 52);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonBackFromPay
            // 
            this.buttonBackFromPay.Location = new System.Drawing.Point(726, 12);
            this.buttonBackFromPay.Name = "buttonBackFromPay";
            this.buttonBackFromPay.Size = new System.Drawing.Size(75, 23);
            this.buttonBackFromPay.TabIndex = 21;
            this.buttonBackFromPay.Text = "Volver";
            this.buttonBackFromPay.UseVisualStyleBackColor = true;
            this.buttonBackFromPay.Click += new System.EventHandler(this.buttonBackfromPay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cantidad a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total en productos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cantidad de asientos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Precio total de boletas:";
            // 
            // VerifyAndPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 396);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonBackFromPay);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtYY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "VerifyAndPay";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtYY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtMM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonBackFromPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}