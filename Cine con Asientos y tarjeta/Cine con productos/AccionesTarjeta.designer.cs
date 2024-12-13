namespace Cine
{
    partial class AccionesTarjeta
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBackFromCreditActions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Tarjeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Verificar y Pagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBackFromCreditActions
            // 
            this.buttonBackFromCreditActions.Location = new System.Drawing.Point(344, 12);
            this.buttonBackFromCreditActions.Name = "buttonBackFromCreditActions";
            this.buttonBackFromCreditActions.Size = new System.Drawing.Size(75, 23);
            this.buttonBackFromCreditActions.TabIndex = 2;
            this.buttonBackFromCreditActions.Text = "Volver";
            this.buttonBackFromCreditActions.UseVisualStyleBackColor = true;
            this.buttonBackFromCreditActions.Click += new System.EventHandler(this.buttonBackFromCreditActions_Click);
            // 
            // AccionesTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 342);
            this.Controls.Add(this.buttonBackFromCreditActions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AccionesTarjeta";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBackFromCreditActions;
    }
}