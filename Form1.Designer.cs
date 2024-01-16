
namespace TpCalculette
{
    partial class frmCalculette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculette));
            this.txtAffichage = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnsev = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btn_pourcentage = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_1surx = new System.Windows.Forms.Button();
            this.btn_x2 = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_supLast = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_vergule = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAffichage
            // 
            this.txtAffichage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAffichage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichage.ForeColor = System.Drawing.Color.Black;
            this.txtAffichage.Location = new System.Drawing.Point(12, 76);
            this.txtAffichage.Name = "txtAffichage";
            this.txtAffichage.ReadOnly = true;
            this.txtAffichage.Size = new System.Drawing.Size(440, 42);
            this.txtAffichage.TabIndex = 0;
            this.txtAffichage.Text = "0";
            this.txtAffichage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAffichage.TextChanged += new System.EventHandler(this.txtAffichage_TextChanged);
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculer.Location = new System.Drawing.Point(355, 487);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(109, 57);
            this.btnCalculer.TabIndex = 1;
            this.btnCalculer.Text = "=";
            this.btnCalculer.UseVisualStyleBackColor = false;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn8.Location = new System.Drawing.Point(122, 306);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(117, 58);
            this.btn8.TabIndex = 2;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn5.Location = new System.Drawing.Point(122, 367);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(117, 58);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlus.Location = new System.Drawing.Point(355, 426);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(109, 59);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "btnzero";
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn0.Location = new System.Drawing.Point(120, 487);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(121, 57);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "btnfoor";
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn4.Location = new System.Drawing.Point(4, 367);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 57);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btndiv
            // 
            this.btndiv.AccessibleName = "btnDiv";
            this.btndiv.BackColor = System.Drawing.Color.White;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndiv.Location = new System.Drawing.Point(355, 244);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(109, 60);
            this.btndiv.TabIndex = 18;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn9.Location = new System.Drawing.Point(242, 306);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(111, 58);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnsev
            // 
            this.btnsev.BackColor = System.Drawing.Color.White;
            this.btnsev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsev.Location = new System.Drawing.Point(4, 306);
            this.btnsev.Name = "btnsev";
            this.btnsev.Size = new System.Drawing.Size(115, 57);
            this.btnsev.TabIndex = 21;
            this.btnsev.TabStop = false;
            this.btnsev.Text = "7";
            this.btnsev.UseVisualStyleBackColor = false;
            this.btnsev.Click += new System.EventHandler(this.btnsev_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.White;
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSi.Location = new System.Drawing.Point(242, 367);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(111, 58);
            this.btnSi.TabIndex = 22;
            this.btnSi.Text = "6";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.Location = new System.Drawing.Point(242, 426);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(111, 59);
            this.btn3.TabIndex = 23;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.Location = new System.Drawing.Point(121, 426);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(118, 59);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.Location = new System.Drawing.Point(4, 426);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(114, 59);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.White;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMul.Location = new System.Drawing.Point(355, 306);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(109, 58);
            this.btnMul.TabIndex = 26;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.White;
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMoins.Location = new System.Drawing.Point(355, 367);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(109, 57);
            this.btnMoins.TabIndex = 27;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(242, 177);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(111, 66);
            this.btnC.TabIndex = 28;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 33);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(47, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "Standard";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(175, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "M+";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox3.Location = new System.Drawing.Point(255, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "M-";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(336, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "MS";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(424, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(28, 20);
            this.textBox5.TabIndex = 35;
            this.textBox5.Text = "M";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(22, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 36;
            this.textBox6.Text = "MC";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(102, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(49, 20);
            this.textBox8.TabIndex = 38;
            this.textBox8.Text = "MR";
            // 
            // btn_pourcentage
            // 
            this.btn_pourcentage.BackColor = System.Drawing.Color.White;
            this.btn_pourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_pourcentage.Location = new System.Drawing.Point(4, 177);
            this.btn_pourcentage.Name = "btn_pourcentage";
            this.btn_pourcentage.Size = new System.Drawing.Size(115, 64);
            this.btn_pourcentage.TabIndex = 39;
            this.btn_pourcentage.Text = "%";
            this.btn_pourcentage.UseVisualStyleBackColor = false;
            this.btn_pourcentage.Click += new System.EventHandler(this.btn_pourcentage_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.White;
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CE.Location = new System.Drawing.Point(122, 177);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(117, 64);
            this.btn_CE.TabIndex = 40;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_1surx
            // 
            this.btn_1surx.BackColor = System.Drawing.Color.White;
            this.btn_1surx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_1surx.Location = new System.Drawing.Point(4, 244);
            this.btn_1surx.Name = "btn_1surx";
            this.btn_1surx.Size = new System.Drawing.Size(115, 58);
            this.btn_1surx.TabIndex = 41;
            this.btn_1surx.Text = "1/x";
            this.btn_1surx.UseVisualStyleBackColor = false;
            this.btn_1surx.Click += new System.EventHandler(this.btn_1surx_Click);
            // 
            // btn_x2
            // 
            this.btn_x2.BackColor = System.Drawing.Color.White;
            this.btn_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_x2.Location = new System.Drawing.Point(122, 244);
            this.btn_x2.Name = "btn_x2";
            this.btn_x2.Size = new System.Drawing.Size(117, 60);
            this.btn_x2.TabIndex = 42;
            this.btn_x2.Text = "x^2";
            this.btn_x2.UseVisualStyleBackColor = false;
            this.btn_x2.Click += new System.EventHandler(this.btn_x2_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.BackColor = System.Drawing.Color.White;
            this.btn_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sqrt.Location = new System.Drawing.Point(242, 244);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(111, 60);
            this.btn_sqrt.TabIndex = 43;
            this.btn_sqrt.Text = "sqrt()";
            this.btn_sqrt.UseVisualStyleBackColor = false;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_supLast
            // 
            this.btn_supLast.BackColor = System.Drawing.Color.White;
            this.btn_supLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_supLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_supLast.Location = new System.Drawing.Point(355, 177);
            this.btn_supLast.Name = "btn_supLast";
            this.btn_supLast.Size = new System.Drawing.Size(109, 64);
            this.btn_supLast.TabIndex = 44;
            this.btn_supLast.Text = "XXX";
            this.btn_supLast.UseVisualStyleBackColor = false;
            this.btn_supLast.Click += new System.EventHandler(this.btn_supLast_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.White;
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_convert.Location = new System.Drawing.Point(4, 487);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(114, 56);
            this.btn_convert.TabIndex = 45;
            this.btn_convert.Text = "+/-";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_vergule
            // 
            this.btn_vergule.BackColor = System.Drawing.Color.White;
            this.btn_vergule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vergule.Location = new System.Drawing.Point(242, 489);
            this.btn_vergule.Name = "btn_vergule";
            this.btn_vergule.Size = new System.Drawing.Size(111, 55);
            this.btn_vergule.TabIndex = 46;
            this.btn_vergule.Text = ".";
            this.btn_vergule.UseVisualStyleBackColor = false;
            this.btn_vergule.Click += new System.EventHandler(this.btn_vergule_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(155, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // frmCalculette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(464, 544);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_vergule);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.btn_supLast);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_x2);
            this.Controls.Add(this.btn_1surx);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_pourcentage);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnsev);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtAffichage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculette";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAffichage;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnsev;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn_pourcentage;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_1surx;
        private System.Windows.Forms.Button btn_x2;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_supLast;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_vergule;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

