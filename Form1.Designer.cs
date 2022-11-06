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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.richRepetir = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.erroresSemanticos = new System.Windows.Forms.RichTextBox();
            this.CCCode = new System.Windows.Forms.RichTextBox();
            this.analisisSin = new System.Windows.Forms.RichTextBox();
            this.Ccode = new System.Windows.Forms.RichTextBox();
            this.richcadenas = new System.Windows.Forms.RichTextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.richsemantica = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.richErroresSintac = new System.Windows.Forms.RichTextBox();
            this.RIchTxLexico = new System.Windows.Forms.RichTextBox();
            this.varcadasig = new System.Windows.Forms.RichTextBox();
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
            this.fontSelectDialog = new System.Windows.Forms.FontDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LexycalAnalyzer = new System.Windows.Forms.TabPage();
            this.SemanticAnalyzer = new System.Windows.Forms.TabPage();
            this.SintaxAnalyzer = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.LexycalAnalyzer.SuspendLayout();
            this.SemanticAnalyzer.SuspendLayout();
            this.SintaxAnalyzer.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colorearletras
            // 
            this.Colorearletras.Interval = 2000;
            this.Colorearletras.Tick += new System.EventHandler(this.ActualizarAnalisis_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.richRepetir);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.richcadenas);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.varcadasig);
            this.panel4.Controls.Add(this.varnumasig);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox8);
            this.panel4.Controls.Add(this.richenteras);
            this.panel4.Controls.Add(this.richSi);
            this.panel4.Location = new System.Drawing.Point(-4, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1303, 702);
            this.panel4.TabIndex = 49;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::MeedCompy.Properties.Resources.sintactico1;
            this.pictureBox5.Location = new System.Drawing.Point(485, -1);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 60;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // richRepetir
            // 
            this.richRepetir.Location = new System.Drawing.Point(904, -1);
            this.richRepetir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richRepetir.Name = "richRepetir";
            this.richRepetir.Size = new System.Drawing.Size(319, 30);
            this.richRepetir.TabIndex = 57;
            this.richRepetir.Text = "";
            this.richRepetir.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(993, 641);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Variables @ y respectivas cadenas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(274, 639);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Variables @";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(637, 641);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Variables # y respectivos valores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(4, 638);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Variables #";
            // 
            // erroresSemanticos
            // 
            this.erroresSemanticos.BackColor = System.Drawing.Color.Black;
            this.erroresSemanticos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.erroresSemanticos.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.erroresSemanticos.ForeColor = System.Drawing.SystemColors.Info;
            this.erroresSemanticos.Location = new System.Drawing.Point(0, 264);
            this.erroresSemanticos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.erroresSemanticos.Name = "erroresSemanticos";
            this.erroresSemanticos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.erroresSemanticos.Size = new System.Drawing.Size(655, 253);
            this.erroresSemanticos.TabIndex = 49;
            this.erroresSemanticos.Text = "";
            // 
            // CCCode
            // 
            this.CCCode.BackColor = System.Drawing.Color.Black;
            this.CCCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CCCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCode.ForeColor = System.Drawing.SystemColors.Info;
            this.CCCode.Location = new System.Drawing.Point(4, -1);
            this.CCCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CCCode.Name = "CCCode";
            this.CCCode.Size = new System.Drawing.Size(620, 544);
            this.CCCode.TabIndex = 43;
            this.CCCode.Text = "";
            this.CCCode.TextChanged += new System.EventHandler(this.CCCode_TextChanged);
            // 
            // analisisSin
            // 
            this.analisisSin.BackColor = System.Drawing.Color.Black;
            this.analisisSin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analisisSin.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.analisisSin.ForeColor = System.Drawing.SystemColors.Info;
            this.analisisSin.Location = new System.Drawing.Point(0, 0);
            this.analisisSin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analisisSin.Name = "analisisSin";
            this.analisisSin.Size = new System.Drawing.Size(655, 245);
            this.analisisSin.TabIndex = 3;
            this.analisisSin.Text = "";
            // 
            // Ccode
            // 
            this.Ccode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ccode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ccode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.Ccode.Location = new System.Drawing.Point(1, 0);
            this.Ccode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ccode.Name = "Ccode";
            this.Ccode.ReadOnly = true;
            this.Ccode.Size = new System.Drawing.Size(623, 549);
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
            this.richcadenas.Location = new System.Drawing.Point(274, 657);
            this.richcadenas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richcadenas.Name = "richcadenas";
            this.richcadenas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richcadenas.ShortcutsEnabled = false;
            this.richcadenas.Size = new System.Drawing.Size(361, 39);
            this.richcadenas.TabIndex = 31;
            this.richcadenas.TabStop = false;
            this.richcadenas.Text = "";
            this.richcadenas.WordWrap = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Image = global::MeedCompy.Properties.Resources.sintactico1;
            this.pictureBox12.Location = new System.Drawing.Point(430, -1);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(47, 41);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 48;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.PictureBox12_Click);
            // 
            // richsemantica
            // 
            this.richsemantica.BackColor = System.Drawing.Color.Black;
            this.richsemantica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsemantica.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.richsemantica.ForeColor = System.Drawing.SystemColors.Info;
            this.richsemantica.Location = new System.Drawing.Point(0, 0);
            this.richsemantica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richsemantica.Name = "richsemantica";
            this.richsemantica.Size = new System.Drawing.Size(659, 256);
            this.richsemantica.TabIndex = 23;
            this.richsemantica.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MeedCompy.Properties.Resources.txt2;
            this.pictureBox4.Location = new System.Drawing.Point(375, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 41);
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
            this.richErroresSintac.Location = new System.Drawing.Point(0, 253);
            this.richErroresSintac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richErroresSintac.Name = "richErroresSintac";
            this.richErroresSintac.Size = new System.Drawing.Size(655, 264);
            this.richErroresSintac.TabIndex = 20;
            this.richErroresSintac.Text = "";
            // 
            // RIchTxLexico
            // 
            this.RIchTxLexico.BackColor = System.Drawing.Color.Black;
            this.RIchTxLexico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RIchTxLexico.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.RIchTxLexico.ForeColor = System.Drawing.SystemColors.Info;
            this.RIchTxLexico.Location = new System.Drawing.Point(4, -4);
            this.RIchTxLexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RIchTxLexico.Name = "RIchTxLexico";
            this.RIchTxLexico.Size = new System.Drawing.Size(658, 521);
            this.RIchTxLexico.TabIndex = 18;
            this.RIchTxLexico.Text = "";
            this.RIchTxLexico.TextChanged += new System.EventHandler(this.RIchTxLexico_TextChanged);
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
            this.varcadasig.Location = new System.Drawing.Point(996, 657);
            this.varcadasig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varcadasig.Name = "varcadasig";
            this.varcadasig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.varcadasig.ShortcutsEnabled = false;
            this.varcadasig.Size = new System.Drawing.Size(306, 39);
            this.varcadasig.TabIndex = 36;
            this.varcadasig.TabStop = false;
            this.varcadasig.Text = "";
            this.varcadasig.WordWrap = false;
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
            this.varnumasig.Location = new System.Drawing.Point(637, 657);
            this.varnumasig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varnumasig.Name = "varnumasig";
            this.varnumasig.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.varnumasig.ShortcutsEnabled = false;
            this.varnumasig.Size = new System.Drawing.Size(357, 39);
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
            this.pictureBox11.Location = new System.Drawing.Point(320, -1);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(47, 41);
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
            this.pictureBox2.Location = new System.Drawing.Point(540, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 41);
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
            this.pictureBox8.Location = new System.Drawing.Point(1223, -1);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(79, 66);
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
            this.richenteras.Location = new System.Drawing.Point(4, 657);
            this.richenteras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richenteras.Name = "richenteras";
            this.richenteras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richenteras.ShortcutsEnabled = false;
            this.richenteras.Size = new System.Drawing.Size(268, 39);
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
            this.CodigoMeedCompyTxt.Location = new System.Drawing.Point(-1, 0);
            this.CodigoMeedCompyTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CodigoMeedCompyTxt.Name = "CodigoMeedCompyTxt";
            this.CodigoMeedCompyTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodigoMeedCompyTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CodigoMeedCompyTxt.ShowSelectionMargin = true;
            this.CodigoMeedCompyTxt.Size = new System.Drawing.Size(628, 549);
            this.CodigoMeedCompyTxt.TabIndex = 1;
            this.CodigoMeedCompyTxt.TabStop = false;
            this.CodigoMeedCompyTxt.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.CCCode);
            this.panel2.Controls.Add(this.Ccode);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 516);
            this.panel2.TabIndex = 33;
            // 
            // richSi
            // 
            this.richSi.Location = new System.Drawing.Point(595, -1);
            this.richSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richSi.Name = "richSi";
            this.richSi.Size = new System.Drawing.Size(301, 30);
            this.richSi.TabIndex = 56;
            this.richSi.Text = "";
            this.richSi.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::MeedCompy.Properties.Resources.AbrirFiltFeel;
            this.pictureBox10.Location = new System.Drawing.Point(53, -1);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(29, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 45;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.PictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::MeedCompy.Properties.Resources.guardarIcon;
            this.pictureBox9.Location = new System.Drawing.Point(8, 1);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(29, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.PictureBox9_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 541);
            this.tabControl1.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CodigoMeedCompyTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LexycalAnalyzer
            // 
            this.LexycalAnalyzer.Controls.Add(this.RIchTxLexico);
            this.LexycalAnalyzer.Location = new System.Drawing.Point(4, 25);
            this.LexycalAnalyzer.Name = "LexycalAnalyzer";
            this.LexycalAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.LexycalAnalyzer.Size = new System.Drawing.Size(655, 545);
            this.LexycalAnalyzer.TabIndex = 2;
            this.LexycalAnalyzer.Text = "Lexical Analyzer";
            this.LexycalAnalyzer.UseVisualStyleBackColor = true;
            // 
            // SemanticAnalyzer
            // 
            this.SemanticAnalyzer.Controls.Add(this.richsemantica);
            this.SemanticAnalyzer.Controls.Add(this.erroresSemanticos);
            this.SemanticAnalyzer.Location = new System.Drawing.Point(4, 25);
            this.SemanticAnalyzer.Name = "SemanticAnalyzer";
            this.SemanticAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.SemanticAnalyzer.Size = new System.Drawing.Size(655, 513);
            this.SemanticAnalyzer.TabIndex = 1;
            this.SemanticAnalyzer.Text = "Semantic Analyzer";
            this.SemanticAnalyzer.UseVisualStyleBackColor = true;
            // 
            // SintaxAnalyzer
            // 
            this.SintaxAnalyzer.Controls.Add(this.analisisSin);
            this.SintaxAnalyzer.Controls.Add(this.richErroresSintac);
            this.SintaxAnalyzer.Location = new System.Drawing.Point(4, 25);
            this.SintaxAnalyzer.Name = "SintaxAnalyzer";
            this.SintaxAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.SintaxAnalyzer.Size = new System.Drawing.Size(655, 545);
            this.SintaxAnalyzer.TabIndex = 0;
            this.SintaxAnalyzer.Text = "Sintax Analyzer";
            this.SintaxAnalyzer.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.LexycalAnalyzer);
            this.tabControl2.Controls.Add(this.SintaxAnalyzer);
            this.tabControl2.Controls.Add(this.SemanticAnalyzer);
            this.tabControl2.Location = new System.Drawing.Point(637, 81);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(663, 542);
            this.tabControl2.TabIndex = 63;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1300, 732);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.LexycalAnalyzer.ResumeLayout(false);
            this.SemanticAnalyzer.ResumeLayout(false);
            this.SintaxAnalyzer.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox CodigoMeedCompyTxt;
        private System.Windows.Forms.RichTextBox RIchTxLexico;
        private System.Windows.Forms.RichTextBox analisisSin;
        private System.Windows.Forms.Timer Colorearletras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richErroresSintac;
        private System.Windows.Forms.RichTextBox richsemantica;
        private System.Windows.Forms.RichTextBox richenteras;
        private System.Windows.Forms.RichTextBox richcadenas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox varnumasig;
        private System.Windows.Forms.RichTextBox varcadasig;
        private System.Windows.Forms.RichTextBox Ccode;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.RichTextBox CCCode;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox erroresSemanticos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richRepetir;
        private System.Windows.Forms.RichTextBox richSi;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FontDialog fontSelectDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage SintaxAnalyzer;
        private System.Windows.Forms.TabPage SemanticAnalyzer;
        private System.Windows.Forms.TabPage LexycalAnalyzer;
    }
 

}

