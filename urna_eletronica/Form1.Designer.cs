namespace urna_eletronica
{
    partial class frmUrna
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrna));
            this.pnlCandidato = new System.Windows.Forms.Panel();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPresidente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pctCandidato = new System.Windows.Forms.PictureBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.pnlUrna = new System.Windows.Forms.Panel();
            this.lblVotoNulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.computarVotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCandidato)).BeginInit();
            this.pnlUrna.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCandidato
            // 
            this.pnlCandidato.BackColor = System.Drawing.Color.White;
            this.pnlCandidato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCandidato.BackgroundImage")));
            this.pnlCandidato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCandidato.Controls.Add(this.btnBranco);
            this.pnlCandidato.Controls.Add(this.btnCorrige);
            this.pnlCandidato.Controls.Add(this.btnConfirma);
            this.pnlCandidato.Controls.Add(this.button10);
            this.pnlCandidato.Controls.Add(this.button9);
            this.pnlCandidato.Controls.Add(this.button8);
            this.pnlCandidato.Controls.Add(this.button7);
            this.pnlCandidato.Controls.Add(this.button6);
            this.pnlCandidato.Controls.Add(this.button5);
            this.pnlCandidato.Controls.Add(this.button4);
            this.pnlCandidato.Controls.Add(this.button3);
            this.pnlCandidato.Controls.Add(this.button2);
            this.pnlCandidato.Controls.Add(this.button1);
            this.pnlCandidato.Location = new System.Drawing.Point(9, 27);
            this.pnlCandidato.Name = "pnlCandidato";
            this.pnlCandidato.Size = new System.Drawing.Size(285, 370);
            this.pnlCandidato.TabIndex = 0;
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.White;
            this.btnBranco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.ForeColor = System.Drawing.Color.Black;
            this.btnBranco.Location = new System.Drawing.Point(3, 302);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(80, 50);
            this.btnBranco.TabIndex = 14;
            this.btnBranco.Text = "BRANCO";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Red;
            this.btnCorrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCorrige.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrige.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrige.ForeColor = System.Drawing.Color.Black;
            this.btnCorrige.Location = new System.Drawing.Point(95, 302);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(80, 50);
            this.btnCorrige.TabIndex = 13;
            this.btnCorrige.Text = "CORRIGE";
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Green;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.Black;
            this.btnConfirma.Location = new System.Drawing.Point(188, 277);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(90, 75);
            this.btnConfirma.TabIndex = 10;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SeaShell;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(105, 214);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 60);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SeaShell;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(181, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 60);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SeaShell;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(105, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SeaShell;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(30, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SeaShell;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(180, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SeaShell;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(105, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(30, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(180, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(105, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // lblPresidente
            // 
            this.lblPresidente.AutoSize = true;
            this.lblPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresidente.Location = new System.Drawing.Point(61, 34);
            this.lblPresidente.Name = "lblPresidente";
            this.lblPresidente.Size = new System.Drawing.Size(129, 24);
            this.lblPresidente.TabIndex = 4;
            this.lblPresidente.Text = "CANDIDATO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Partido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-5, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "_________________________________________________________________________";
            // 
            // pctCandidato
            // 
            this.pctCandidato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctCandidato.Image = ((System.Drawing.Image)(resources.GetObject("pctCandidato.Image")));
            this.pctCandidato.Location = new System.Drawing.Point(245, 16);
            this.pctCandidato.Name = "pctCandidato";
            this.pctCandidato.Size = new System.Drawing.Size(173, 169);
            this.pctCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCandidato.TabIndex = 11;
            this.pctCandidato.TabStop = false;
            // 
            // lblNum1
            // 
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(76, 85);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Padding = new System.Windows.Forms.Padding(5);
            this.lblNum1.Size = new System.Drawing.Size(44, 56);
            this.lblNum1.TabIndex = 13;
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(61, 207);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(27, 20);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "---";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Location = new System.Drawing.Point(72, 236);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(27, 20);
            this.lblPartido.TabIndex = 15;
            this.lblPartido.Text = "---";
            // 
            // lblNum2
            // 
            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(128, 85);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Padding = new System.Windows.Forms.Padding(5);
            this.lblNum2.Size = new System.Drawing.Size(44, 56);
            this.lblNum2.TabIndex = 16;
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUrna
            // 
            this.pnlUrna.BackColor = System.Drawing.Color.Transparent;
            this.pnlUrna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlUrna.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUrna.Controls.Add(this.lblVotoNulo);
            this.pnlUrna.Controls.Add(this.lblNum2);
            this.pnlUrna.Controls.Add(this.pctCandidato);
            this.pnlUrna.Controls.Add(this.lblNum1);
            this.pnlUrna.Controls.Add(this.lblNome);
            this.pnlUrna.Controls.Add(this.lblPartido);
            this.pnlUrna.Controls.Add(this.lblPresidente);
            this.pnlUrna.Controls.Add(this.label5);
            this.pnlUrna.Controls.Add(this.label4);
            this.pnlUrna.Controls.Add(this.label3);
            this.pnlUrna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.pnlUrna.Location = new System.Drawing.Point(300, 128);
            this.pnlUrna.Name = "pnlUrna";
            this.pnlUrna.Size = new System.Drawing.Size(458, 269);
            this.pnlUrna.TabIndex = 17;
            // 
            // lblVotoNulo
            // 
            this.lblVotoNulo.AutoSize = true;
            this.lblVotoNulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblVotoNulo.Location = new System.Drawing.Point(47, 101);
            this.lblVotoNulo.Name = "lblVotoNulo";
            this.lblVotoNulo.Size = new System.Drawing.Size(0, 26);
            this.lblVotoNulo.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computarVotosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(766, 26);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // computarVotosToolStripMenuItem
            // 
            this.computarVotosToolStripMenuItem.Checked = true;
            this.computarVotosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.computarVotosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.computarVotosToolStripMenuItem.Name = "computarVotosToolStripMenuItem";
            this.computarVotosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.computarVotosToolStripMenuItem.Text = "Finalizar Votação";
            this.computarVotosToolStripMenuItem.Click += new System.EventHandler(this.computarVotosToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(766, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlUrna);
            this.Controls.Add(this.pnlCandidato);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletrônica";
            this.Load += new System.EventHandler(this.frmUrna_Load);
            this.pnlCandidato.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCandidato)).EndInit();
            this.pnlUrna.ResumeLayout(false);
            this.pnlUrna.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCandidato;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPresidente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pctCandidato;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Panel pnlUrna;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem computarVotosToolStripMenuItem;
        private System.Windows.Forms.Label lblVotoNulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

