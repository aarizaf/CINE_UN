namespace Cine
{
    partial class crispetas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totaldulceria = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CrPequeña = new System.Windows.Forms.RadioButton();
            this.CrMediana = new System.Windows.Forms.RadioButton();
            this.CrGrande = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sumarcr = new System.Windows.Forms.Button();
            this.restarcr = new System.Windows.Forms.Button();
            this.cantidadcr = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalch = new System.Windows.Forms.TextBox();
            this.countch = new System.Windows.Forms.TextBox();
            this.restaCh = new System.Windows.Forms.Button();
            this.sumaCh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Limon = new System.Windows.Forms.RadioButton();
            this.Natural = new System.Windows.Forms.RadioButton();
            this.mayonesa = new System.Windows.Forms.RadioButton();
            this.Tomate = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.totalP = new System.Windows.Forms.TextBox();
            this.cantidadP = new System.Windows.Forms.TextBox();
            this.restaP = new System.Windows.Forms.Button();
            this.sumaP = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 688);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "COMIDA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.totaldulceria);
            this.panel3.Controls.Add(this.Calcular);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(971, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 682);
            this.panel3.TabIndex = 3;
            // 
            // totaldulceria
            // 
            this.totaldulceria.Location = new System.Drawing.Point(59, 89);
            this.totaldulceria.Name = "totaldulceria";
            this.totaldulceria.Size = new System.Drawing.Size(103, 20);
            this.totaldulceria.TabIndex = 110;
            this.totaldulceria.Text = "0";
            // 
            // Calcular
            // 
            this.Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calcular.Image = global::Cine.Properties.Resources.CARRITO__1___1_;
            this.Calcular.Location = new System.Drawing.Point(88, 115);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(74, 56);
            this.Calcular.TabIndex = 14;
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "TOTAL COMIDA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 49);
            this.panel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "CRISPETAS";
            // 
            // CrPequeña
            // 
            this.CrPequeña.AutoSize = true;
            this.CrPequeña.Location = new System.Drawing.Point(508, 114);
            this.CrPequeña.Name = "CrPequeña";
            this.CrPequeña.Size = new System.Drawing.Size(68, 17);
            this.CrPequeña.TabIndex = 19;
            this.CrPequeña.Text = "Pequeña";
            this.CrPequeña.UseVisualStyleBackColor = true;
            this.CrPequeña.CheckedChanged += new System.EventHandler(this.CrPequeña_CheckedChanged);
            // 
            // CrMediana
            // 
            this.CrMediana.AutoSize = true;
            this.CrMediana.Location = new System.Drawing.Point(508, 146);
            this.CrMediana.Name = "CrMediana";
            this.CrMediana.Size = new System.Drawing.Size(66, 17);
            this.CrMediana.TabIndex = 20;
            this.CrMediana.Text = "Mediana";
            this.CrMediana.UseVisualStyleBackColor = true;
            this.CrMediana.CheckedChanged += new System.EventHandler(this.CrPequeña_CheckedChanged);
            // 
            // CrGrande
            // 
            this.CrGrande.AutoSize = true;
            this.CrGrande.Location = new System.Drawing.Point(508, 177);
            this.CrGrande.Name = "CrGrande";
            this.CrGrande.Size = new System.Drawing.Size(60, 17);
            this.CrGrande.TabIndex = 21;
            this.CrGrande.Text = "Grande";
            this.CrGrande.UseVisualStyleBackColor = true;
            this.CrGrande.CheckedChanged += new System.EventHandler(this.CrPequeña_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "$ 10.000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "$ 15.000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(594, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "$ 20.000";
            // 
            // sumarcr
            // 
            this.sumarcr.Location = new System.Drawing.Point(733, 116);
            this.sumarcr.Name = "sumarcr";
            this.sumarcr.Size = new System.Drawing.Size(34, 23);
            this.sumarcr.TabIndex = 25;
            this.sumarcr.Text = "+";
            this.sumarcr.UseVisualStyleBackColor = true;
            this.sumarcr.Click += new System.EventHandler(this.sumarcr_Click);
            // 
            // restarcr
            // 
            this.restarcr.Location = new System.Drawing.Point(733, 177);
            this.restarcr.Name = "restarcr";
            this.restarcr.Size = new System.Drawing.Size(34, 23);
            this.restarcr.TabIndex = 26;
            this.restarcr.Text = "-";
            this.restarcr.UseVisualStyleBackColor = true;
            this.restarcr.Click += new System.EventHandler(this.restarcr_Click);
            // 
            // cantidadcr
            // 
            this.cantidadcr.Location = new System.Drawing.Point(733, 148);
            this.cantidadcr.Name = "cantidadcr";
            this.cantidadcr.Size = new System.Drawing.Size(34, 20);
            this.cantidadcr.TabIndex = 86;
            this.cantidadcr.Text = "0";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(703, 211);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(103, 20);
            this.total.TabIndex = 87;
            this.total.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "$ 2.000";
            // 
            // totalch
            // 
            this.totalch.Location = new System.Drawing.Point(521, 380);
            this.totalch.Name = "totalch";
            this.totalch.Size = new System.Drawing.Size(103, 20);
            this.totalch.TabIndex = 94;
            this.totalch.Text = "0";
            // 
            // countch
            // 
            this.countch.Location = new System.Drawing.Point(551, 317);
            this.countch.Name = "countch";
            this.countch.Size = new System.Drawing.Size(34, 20);
            this.countch.TabIndex = 93;
            this.countch.Text = "0";
            // 
            // restaCh
            // 
            this.restaCh.Location = new System.Drawing.Point(551, 346);
            this.restaCh.Name = "restaCh";
            this.restaCh.Size = new System.Drawing.Size(34, 23);
            this.restaCh.TabIndex = 92;
            this.restaCh.Text = "-";
            this.restaCh.UseVisualStyleBackColor = true;
            this.restaCh.Click += new System.EventHandler(this.restaCh_Click);
            // 
            // sumaCh
            // 
            this.sumaCh.Location = new System.Drawing.Point(551, 285);
            this.sumaCh.Name = "sumaCh";
            this.sumaCh.Size = new System.Drawing.Size(34, 23);
            this.sumaCh.TabIndex = 91;
            this.sumaCh.Text = "+";
            this.sumaCh.UseVisualStyleBackColor = true;
            this.sumaCh.Click += new System.EventHandler(this.sumaCh_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(324, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 25);
            this.label14.TabIndex = 95;
            this.label14.Text = "CHOCOLATINA";
            // 
            // Limon
            // 
            this.Limon.AutoSize = true;
            this.Limon.Location = new System.Drawing.Point(26, 107);
            this.Limon.Name = "Limon";
            this.Limon.Size = new System.Drawing.Size(53, 17);
            this.Limon.TabIndex = 99;
            this.Limon.Text = "Limon";
            this.Limon.UseVisualStyleBackColor = true;
            this.Limon.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Natural
            // 
            this.Natural.AutoSize = true;
            this.Natural.Location = new System.Drawing.Point(26, 72);
            this.Natural.Name = "Natural";
            this.Natural.Size = new System.Drawing.Size(59, 17);
            this.Natural.TabIndex = 98;
            this.Natural.Text = "Natural";
            this.Natural.UseVisualStyleBackColor = true;
            this.Natural.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // mayonesa
            // 
            this.mayonesa.AutoSize = true;
            this.mayonesa.Location = new System.Drawing.Point(26, 37);
            this.mayonesa.Name = "mayonesa";
            this.mayonesa.Size = new System.Drawing.Size(74, 17);
            this.mayonesa.TabIndex = 97;
            this.mayonesa.Text = "Mayonesa";
            this.mayonesa.UseVisualStyleBackColor = true;
            this.mayonesa.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Tomate
            // 
            this.Tomate.AutoSize = true;
            this.Tomate.Location = new System.Drawing.Point(26, 144);
            this.Tomate.Name = "Tomate";
            this.Tomate.Size = new System.Drawing.Size(61, 17);
            this.Tomate.TabIndex = 100;
            this.Tomate.Text = "Tomate";
            this.Tomate.UseVisualStyleBackColor = true;
            this.Tomate.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(114, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 101;
            this.label15.Text = "$ 5.000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(114, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "$ 5.000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(114, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 103;
            this.label18.Text = "$ 5.000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(114, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 104;
            this.label19.Text = "$ 5.000";
            // 
            // totalP
            // 
            this.totalP.Location = new System.Drawing.Point(703, 609);
            this.totalP.Name = "totalP";
            this.totalP.Size = new System.Drawing.Size(103, 20);
            this.totalP.TabIndex = 108;
            this.totalP.Text = "0";
            // 
            // cantidadP
            // 
            this.cantidadP.Location = new System.Drawing.Point(733, 546);
            this.cantidadP.Name = "cantidadP";
            this.cantidadP.Size = new System.Drawing.Size(34, 20);
            this.cantidadP.TabIndex = 107;
            this.cantidadP.Text = "0";
            // 
            // restaP
            // 
            this.restaP.Location = new System.Drawing.Point(733, 575);
            this.restaP.Name = "restaP";
            this.restaP.Size = new System.Drawing.Size(34, 23);
            this.restaP.TabIndex = 106;
            this.restaP.Text = "-";
            this.restaP.UseVisualStyleBackColor = true;
            this.restaP.Click += new System.EventHandler(this.restaP_Click);
            // 
            // sumaP
            // 
            this.sumaP.Location = new System.Drawing.Point(733, 514);
            this.sumaP.Name = "sumaP";
            this.sumaP.Size = new System.Drawing.Size(34, 23);
            this.sumaP.TabIndex = 105;
            this.sumaP.Text = "+";
            this.sumaP.UseVisualStyleBackColor = true;
            this.sumaP.Click += new System.EventHandler(this.sumaP_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(360, 455);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 25);
            this.label20.TabIndex = 109;
            this.label20.Text = "Papas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mayonesa);
            this.groupBox1.Controls.Add(this.Natural);
            this.groupBox1.Controls.Add(this.Limon);
            this.groupBox1.Controls.Add(this.Tomate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(485, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(515, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "DULCERIA";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Cine.Properties.Resources.natural;
            this.pictureBox5.Location = new System.Drawing.Point(315, 483);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 186);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 96;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::Cine.Properties.Resources.choco;
            this.pictureBox6.Location = new System.Drawing.Point(315, 285);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(161, 141);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 89;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Cine.Properties.Resources.Crispeta_Grande;
            this.pictureBox4.Location = new System.Drawing.Point(315, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 123);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cine.Properties.Resources.comida_cine;
            this.pictureBox1.Location = new System.Drawing.Point(20, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(4, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 32);
            this.label16.TabIndex = 117;
            this.label16.Text = "AÑADIR \r\nA CARRITO";
            // 
            // crispetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.totalP);
            this.Controls.Add(this.cantidadP);
            this.Controls.Add(this.restaP);
            this.Controls.Add(this.sumaP);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalch);
            this.Controls.Add(this.countch);
            this.Controls.Add(this.restaCh);
            this.Controls.Add(this.sumaCh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cantidadcr);
            this.Controls.Add(this.restarcr);
            this.Controls.Add(this.sumarcr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CrGrande);
            this.Controls.Add(this.CrMediana);
            this.Controls.Add(this.CrPequeña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "crispetas";
            this.Text = "crispetas";
            this.Load += new System.EventHandler(this.crispetas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton CrPequeña;
        private System.Windows.Forms.RadioButton CrMediana;
        private System.Windows.Forms.RadioButton CrGrande;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sumarcr;
        private System.Windows.Forms.Button restarcr;
        private System.Windows.Forms.TextBox cantidadcr;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalch;
        private System.Windows.Forms.TextBox countch;
        private System.Windows.Forms.Button restaCh;
        private System.Windows.Forms.Button sumaCh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton Limon;
        private System.Windows.Forms.RadioButton Natural;
        private System.Windows.Forms.RadioButton mayonesa;
        private System.Windows.Forms.RadioButton Tomate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox totalP;
        private System.Windows.Forms.TextBox cantidadP;
        private System.Windows.Forms.Button restaP;
        private System.Windows.Forms.Button sumaP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totaldulceria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
    }
}