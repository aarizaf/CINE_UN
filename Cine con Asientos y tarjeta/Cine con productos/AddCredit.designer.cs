namespace Cine
{
    partial class AddCredit
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
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYY = new System.Windows.Forms.ComboBox();
            this.btnAddCredit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonBackFromAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Tarjeta";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(30, 55);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(181, 20);
            this.txtTarjeta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(33, 140);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(178, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVV";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(33, 226);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(100, 20);
            this.txtCVV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Expiración";
            // 
            // txtMM
            // 
            this.txtMM.FormattingEnabled = true;
            this.txtMM.Location = new System.Drawing.Point(231, 224);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(51, 21);
            this.txtMM.TabIndex = 7;
            this.txtMM.Text = "MM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            // 
            // txtYY
            // 
            this.txtYY.FormattingEnabled = true;
            this.txtYY.Location = new System.Drawing.Point(306, 225);
            this.txtYY.Name = "txtYY";
            this.txtYY.Size = new System.Drawing.Size(49, 21);
            this.txtYY.TabIndex = 9;
            this.txtYY.Text = "YY";
            // 
            // btnAddCredit
            // 
            this.btnAddCredit.Location = new System.Drawing.Point(55, 302);
            this.btnAddCredit.Name = "btnAddCredit";
            this.btnAddCredit.Size = new System.Drawing.Size(141, 61);
            this.btnAddCredit.TabIndex = 10;
            this.btnAddCredit.Text = "Añadir";
            this.btnAddCredit.UseVisualStyleBackColor = true;
            this.btnAddCredit.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonBackFromAdd
            // 
            this.buttonBackFromAdd.Location = new System.Drawing.Point(357, 13);
            this.buttonBackFromAdd.Name = "buttonBackFromAdd";
            this.buttonBackFromAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonBackFromAdd.TabIndex = 11;
            this.buttonBackFromAdd.Text = "Volver";
            this.buttonBackFromAdd.UseVisualStyleBackColor = true;
            this.buttonBackFromAdd.Click += new System.EventHandler(this.buttonBackFromAdd_Click);
            // 
            // AddCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.buttonBackFromAdd);
            this.Controls.Add(this.btnAddCredit);
            this.Controls.Add(this.txtYY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label1);
            this.Name = "AddCredit";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtYY;
        private System.Windows.Forms.Button btnAddCredit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonBackFromAdd;
    }
}