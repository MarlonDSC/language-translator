namespace MeedCompy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Colorearletras = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.richRepetir = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.erroresSemanticos = new System.Windows.Forms.RichTextBox();
            this.CCCode = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.analisisSin = new System.Windows.Forms.RichTextBox();
            this.Ccode = new System.Windows.Forms.RichTextBox();
            this.richcadenas = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.richsemantica = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.richErroresSintac = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RIchTxLexico = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.varcadasig = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.varnumasig = new System.Windows.Forms.RichTextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.richenteras = new System.Windows.Forms.RichTextBox();
            this.CodigoMeedCompyTxt = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richSi = new System.Windows.Forms.RichTextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontSelectDialog = new System.Windows.Forms.FontDialog();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Colorearletras
            // 
            this.Colorearletras.Interval = 2000;
            this.Colorearletras.Tick += new System.EventHandler(this.ActualizarAnalisis_Tick);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(1187, 1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 20);
            this.minimize.TabIndex = 40;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.richRepetir);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.pictureBox13);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.erroresSemanticos);
            this.panel4.Controls.Add(this.CCCode);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.analisisSin);
            this.panel4.Controls.Add(this.Ccode);
            this.panel4.Controls.Add(this.richcadenas);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Controls.Add(this.richsemantica);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.richErroresSintac);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.RIchTxLexico);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.varcadasig);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.varnumasig);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.richenteras);
            this.panel4.Controls.Add(this.CodigoMeedCompyTxt);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.richSi);
            this.panel4.Location = new System.Drawing.Point(-3, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1249, 674);
            this.panel4.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1143, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Analisis Léxico";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::MeedCompy.Properties.Resources.sintactico1;
            this.pictureBox5.Location = new System.Drawing.Point(458, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 60;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // richRepetir
            // 
            this.richRepetir.Location = new System.Drawing.Point(651, 59);
            this.richRepetir.Name = "richRepetir";
            this.richRepetir.Size = new System.Drawing.Size(89, 61);
            this.richRepetir.TabIndex = 57;
            this.richRepetir.Text = "";
            this.richRepetir.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(273, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Variables @ y respectivas cadenas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(273, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Variables @";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Variables # y respectivos valores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(18, 558);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Variables #";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::MeedCompy.Properties.Resources.errores;
            this.pictureBox13.Location = new System.Drawing.Point(644, 311);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(26, 13);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 51;
            this.pictureBox13.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(552, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Errores Semánticos";
            // 
            // erroresSemanticos
            // 
            this.erroresSemanticos.BackColor = System.Drawing.Color.Black;
            this.erroresSemanticos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.erroresSemanticos.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.erroresSemanticos.ForeColor = System.Drawing.SystemColors.Info;
            this.erroresSemanticos.Location = new System.Drawing.Point(551, 326);
            this.erroresSemanticos.Name = "erroresSemanticos";
            this.erroresSemanticos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.erroresSemanticos.Size = new System.Drawing.Size(189, 158);
            this.erroresSemanticos.TabIndex = 49;
            this.erroresSemanticos.Text = "";
            // 
            // CCCode
            // 
            this.CCCode.BackColor = System.Drawing.Color.Black;
            this.CCCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CCCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCode.ForeColor = System.Drawing.SystemColors.Info;
            this.CCCode.Location = new System.Drawing.Point(792, 161);
            this.CCCode.Name = "CCCode";
            this.CCCode.Size = new System.Drawing.Size(422, 381);
            this.CCCode.TabIndex = 43;
            this.CCCode.Text = "";
            this.CCCode.TextChanged += new System.EventHandler(this.CCCode_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(18, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 10);
            this.panel3.TabIndex = 34;
            // 
            // analisisSin
            // 
            this.analisisSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.analisisSin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analisisSin.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.analisisSin.ForeColor = System.Drawing.SystemColors.Info;
            this.analisisSin.Location = new System.Drawing.Point(551, 503);
            this.analisisSin.Name = "analisisSin";
            this.analisisSin.Size = new System.Drawing.Size(189, 150);
            this.analisisSin.TabIndex = 3;
            this.analisisSin.Text = "";
            // 
            // Ccode
            // 
            this.Ccode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ccode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ccode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.Ccode.Location = new System.Drawing.Point(749, 136);
            this.Ccode.Name = "Ccode";
            this.Ccode.ReadOnly = true;
            this.Ccode.Size = new System.Drawing.Size(473, 420);
            this.Ccode.TabIndex = 39;
            this.Ccode.Text = "";
            // 
            // richcadenas
            // 
            this.richcadenas.AutoWordSelection = true;
            this.richcadenas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.richcadenas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richcadenas.EnableAutoDragDrop = true;
            this.richcadenas.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.richcadenas.ForeColor = System.Drawing.SystemColors.Info;
            this.richcadenas.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richcadenas.Location = new System.Drawing.Point(273, 574);
            this.richcadenas.Name = "richcadenas";
            this.richcadenas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richcadenas.ShortcutsEnabled = false;
            this.richcadenas.Size = new System.Drawing.Size(271, 32);
            this.richcadenas.TabIndex = 31;
            this.richcadenas.TabStop = false;
            this.richcadenas.Text = "";
            this.richcadenas.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(746, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Traducción de MeedCompy a C++";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(867, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Analisis Semántico";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::MeedCompy.Properties.Resources.sintactico1;
            this.pictureBox12.Location = new System.Drawing.Point(370, 87);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 33);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 48;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.PictureBox12_Click);
            // 
            // richsemantica
            // 
            this.richsemantica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.richsemantica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsemantica.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.richsemantica.ForeColor = System.Drawing.SystemColors.Info;
            this.richsemantica.Location = new System.Drawing.Point(748, 574);
            this.richsemantica.Name = "richsemantica";
            this.richsemantica.Size = new System.Drawing.Size(233, 79);
            this.richsemantica.TabIndex = 23;
            this.richsemantica.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MeedCompy.Properties.Resources.txt2;
            this.pictureBox4.Location = new System.Drawing.Point(329, 87);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // richErroresSintac
            // 
            this.richErroresSintac.BackColor = System.Drawing.Color.Black;
            this.richErroresSintac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richErroresSintac.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richErroresSintac.ForeColor = System.Drawing.SystemColors.Info;
            this.richErroresSintac.Location = new System.Drawing.Point(551, 155);
            this.richErroresSintac.Name = "richErroresSintac";
            this.richErroresSintac.Size = new System.Drawing.Size(189, 154);
            this.richErroresSintac.TabIndex = 20;
            this.richErroresSintac.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(549, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Errores Sintácticos";
            // 
            // RIchTxLexico
            // 
            this.RIchTxLexico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.RIchTxLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RIchTxLexico.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.RIchTxLexico.ForeColor = System.Drawing.SystemColors.Info;
            this.RIchTxLexico.Location = new System.Drawing.Point(987, 574);
            this.RIchTxLexico.Name = "RIchTxLexico";
            this.RIchTxLexico.Size = new System.Drawing.Size(235, 79);
            this.RIchTxLexico.TabIndex = 18;
            this.RIchTxLexico.Text = "";
            this.RIchTxLexico.TextChanged += new System.EventHandler(this.RIchTxLexico_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(552, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Analisis Sintáctico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(849, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Analisis Léxico";
            // 
            // varcadasig
            // 
            this.varcadasig.AutoWordSelection = true;
            this.varcadasig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.varcadasig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varcadasig.EnableAutoDragDrop = true;
            this.varcadasig.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.varcadasig.ForeColor = System.Drawing.SystemColors.Info;
            this.varcadasig.ImeMode = System.Windows.Forms.ImeMode.On;
            this.varcadasig.Location = new System.Drawing.Point(274, 621);
            this.varcadasig.Name = "varcadasig";
            this.varcadasig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.varcadasig.ShortcutsEnabled = false;
            this.varcadasig.Size = new System.Drawing.Size(271, 32);
            this.varcadasig.TabIndex = 36;
            this.varcadasig.TabStop = false;
            this.varcadasig.Text = "";
            this.varcadasig.WordWrap = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MeedCompy.Properties.Resources.errores;
            this.pictureBox3.Location = new System.Drawing.Point(650, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 13);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // varnumasig
            // 
            this.varnumasig.AutoWordSelection = true;
            this.varnumasig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(64)))));
            this.varnumasig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varnumasig.EnableAutoDragDrop = true;
            this.varnumasig.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.varnumasig.ForeColor = System.Drawing.SystemColors.Info;
            this.varnumasig.ImeMode = System.Windows.Forms.ImeMode.On;
            this.varnumasig.Location = new System.Drawing.Point(18, 621);
            this.varnumasig.Name = "varnumasig";
            this.varnumasig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.varnumasig.ShortcutsEnabled = false;
            this.varnumasig.Size = new System.Drawing.Size(262, 32);
            this.varnumasig.TabIndex = 35;
            this.varnumasig.TabStop = false;
            this.varnumasig.Text = "";
            this.varnumasig.WordWrap = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::MeedCompy.Properties.Resources.txt1;
            this.pictureBox11.Location = new System.Drawing.Point(288, 87);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 33);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 46;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.PictureBox11_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MeedCompy.Properties.Resources.compilar;
            this.pictureBox2.Location = new System.Drawing.Point(499, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::MeedCompy.Properties.Resources.C__logo;
            this.pictureBox8.Location = new System.Drawing.Point(903, 76);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(59, 54);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 42;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.PictureBox8_Click);
            // 
            // richenteras
            // 
            this.richenteras.AutoWordSelection = true;
            this.richenteras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(64)))));
            this.richenteras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richenteras.EnableAutoDragDrop = true;
            this.richenteras.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.richenteras.ForeColor = System.Drawing.SystemColors.Info;
            this.richenteras.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richenteras.Location = new System.Drawing.Point(18, 574);
            this.richenteras.Name = "richenteras";
            this.richenteras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richenteras.ShortcutsEnabled = false;
            this.richenteras.Size = new System.Drawing.Size(262, 32);
            this.richenteras.TabIndex = 30;
            this.richenteras.TabStop = false;
            this.richenteras.Text = "";
            this.richenteras.WordWrap = false;
            // 
            // CodigoMeedCompyTxt
            // 
            this.CodigoMeedCompyTxt.AutoWordSelection = true;
            this.CodigoMeedCompyTxt.BackColor = System.Drawing.Color.Black;
            this.CodigoMeedCompyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodigoMeedCompyTxt.EnableAutoDragDrop = true;
            this.CodigoMeedCompyTxt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoMeedCompyTxt.ForeColor = System.Drawing.SystemColors.Info;
            this.CodigoMeedCompyTxt.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CodigoMeedCompyTxt.Location = new System.Drawing.Point(78, 154);
            this.CodigoMeedCompyTxt.Name = "CodigoMeedCompyTxt";
            this.CodigoMeedCompyTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodigoMeedCompyTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CodigoMeedCompyTxt.ShowSelectionMargin = true;
            this.CodigoMeedCompyTxt.Size = new System.Drawing.Size(435, 403);
            this.CodigoMeedCompyTxt.TabIndex = 1;
            this.CodigoMeedCompyTxt.TabStop = false;
            this.CodigoMeedCompyTxt.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 420);
            this.panel2.TabIndex = 33;
            // 
            // richSi
            // 
            this.richSi.Location = new System.Drawing.Point(550, 59);
            this.richSi.Name = "richSi";
            this.richSi.Size = new System.Drawing.Size(94, 61);
            this.richSi.TabIndex = 56;
            this.richSi.Text = "";
            this.richSi.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::MeedCompy.Properties.Resources.AbrirFiltFeel;
            this.pictureBox10.Location = new System.Drawing.Point(40, -1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(22, 27);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 45;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.PictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::MeedCompy.Properties.Resources.guardarIcon;
            this.pictureBox9.Location = new System.Drawing.Point(6, 1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.PictureBox9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MeedCompy.Properties.Resources.errores;
            this.pictureBox1.Location = new System.Drawing.Point(1210, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1242, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimize);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox CodigoMeedCompyTxt;
        private System.Windows.Forms.RichTextBox RIchTxLexico;
        private System.Windows.Forms.RichTextBox analisisSin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Colorearletras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richErroresSintac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richsemantica;
        private System.Windows.Forms.RichTextBox richenteras;
        private System.Windows.Forms.RichTextBox richcadenas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox varnumasig;
        private System.Windows.Forms.RichTextBox varcadasig;
        private System.Windows.Forms.RichTextBox Ccode;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.RichTextBox CCCode;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox erroresSemanticos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richRepetir;
        private System.Windows.Forms.RichTextBox richSi;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FontDialog fontSelectDialog;
        private System.Windows.Forms.Label label12;
    }
 

}

