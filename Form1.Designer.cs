namespace CalculadoraErika
{
    partial class Form1
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
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnLogX = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnPow3 = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.bntEquals = new System.Windows.Forms.Button();
            this.btnPorc = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnLnx = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnInvertSign = new System.Windows.Forms.Button();
            this.btnSquare2 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbInputBase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(4, 15);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(468, 96);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "";
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShift.Location = new System.Drawing.Point(292, 4);
            this.btnShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(93, 70);
            this.btnShift.TabIndex = 2;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnLogX
            // 
            this.btnLogX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogX.Location = new System.Drawing.Point(113, 82);
            this.btnLogX.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogX.Name = "btnLogX";
            this.btnLogX.Size = new System.Drawing.Size(80, 77);
            this.btnLogX.TabIndex = 3;
            this.btnLogX.Text = "log(x)";
            this.btnLogX.UseVisualStyleBackColor = false;
            this.btnLogX.Click += new System.EventHandler(this.btnLogX_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.32995F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.67005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.btnTan, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSin, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPow3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConvert, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.bntEquals, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPorc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEx, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnLnx, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnInvertSign, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShift, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.7707F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.2293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 482);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(4, 416);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(101, 62);
            this.btnTan.TabIndex = 31;
            this.btnTan.Text = "Tan(^-1)";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(4, 337);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(101, 71);
            this.btnCos.TabIndex = 30;
            this.btnCos.Text = "Cos(^-1)";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(4, 254);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(101, 75);
            this.btnSin.TabIndex = 29;
            this.btnSin.Text = "Sin(^-1)";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnPow3
            // 
            this.btnPow3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow3.Location = new System.Drawing.Point(4, 167);
            this.btnPow3.Margin = new System.Windows.Forms.Padding(4);
            this.btnPow3.Name = "btnPow3";
            this.btnPow3.Size = new System.Drawing.Size(101, 79);
            this.btnPow3.TabIndex = 28;
            this.btnPow3.Text = "x³";
            this.btnPow3.UseVisualStyleBackColor = false;
            this.btnPow3.Click += new System.EventHandler(this.btnPow3_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(4, 4);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(101, 70);
            this.btnConvert.TabIndex = 26;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(393, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 70);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(393, 82);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(79, 77);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(393, 167);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(79, 79);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(393, 254);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(79, 75);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(393, 337);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(79, 71);
            this.btnPlus.TabIndex = 21;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // bntEquals
            // 
            this.bntEquals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEquals.Location = new System.Drawing.Point(393, 416);
            this.bntEquals.Margin = new System.Windows.Forms.Padding(4);
            this.bntEquals.Name = "bntEquals";
            this.bntEquals.Size = new System.Drawing.Size(79, 62);
            this.bntEquals.TabIndex = 25;
            this.bntEquals.Text = "=";
            this.bntEquals.UseVisualStyleBackColor = false;
            this.bntEquals.Click += new System.EventHandler(this.bntEquals_Click);
            // 
            // btnPorc
            // 
            this.btnPorc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorc.Location = new System.Drawing.Point(292, 82);
            this.btnPorc.Margin = new System.Windows.Forms.Padding(4);
            this.btnPorc.Name = "btnPorc";
            this.btnPorc.Size = new System.Drawing.Size(93, 77);
            this.btnPorc.TabIndex = 8;
            this.btnPorc.Text = "%";
            this.btnPorc.UseVisualStyleBackColor = false;
            this.btnPorc.Click += new System.EventHandler(this.btnPorc_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(292, 167);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 79);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(292, 254);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 75);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(292, 337);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 71);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(292, 416);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(93, 62);
            this.btnDot.TabIndex = 24;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(201, 82);
            this.btnEx.Margin = new System.Windows.Forms.Padding(4);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(83, 77);
            this.btnEx.TabIndex = 7;
            this.btnEx.Text = "eˣ";
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(201, 167);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(83, 79);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(201, 254);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(83, 75);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(201, 337);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 71);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(201, 416);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(83, 62);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnLnx
            // 
            this.btnLnx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLnx.Location = new System.Drawing.Point(113, 4);
            this.btnLnx.Margin = new System.Windows.Forms.Padding(4);
            this.btnLnx.Name = "btnLnx";
            this.btnLnx.Size = new System.Drawing.Size(80, 70);
            this.btnLnx.TabIndex = 6;
            this.btnLnx.Text = "ln(x)";
            this.btnLnx.UseVisualStyleBackColor = false;
            this.btnLnx.Click += new System.EventHandler(this.btnLnx_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(113, 167);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 79);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(113, 254);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 75);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(113, 337);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 71);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnInvertSign
            // 
            this.btnInvertSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertSign.Location = new System.Drawing.Point(113, 416);
            this.btnInvertSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvertSign.Name = "btnInvertSign";
            this.btnInvertSign.Size = new System.Drawing.Size(80, 62);
            this.btnInvertSign.TabIndex = 22;
            this.btnInvertSign.Text = "+/-";
            this.btnInvertSign.UseVisualStyleBackColor = true;
            this.btnInvertSign.Click += new System.EventHandler(this.btnInvertSign_Click);
            // 
            // btnSquare2
            // 
            this.btnSquare2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSquare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare2.Location = new System.Drawing.Point(4, 82);
            this.btnSquare2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare2.Name = "btnSquare2";
            this.btnSquare2.Size = new System.Drawing.Size(101, 77);
            this.btnSquare2.TabIndex = 27;
            this.btnSquare2.Text = "∛x";
            this.btnSquare2.UseVisualStyleBackColor = false;
            this.btnSquare2.Click += new System.EventHandler(this.btnSquare2_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(201, 4);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(83, 70);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexadecimalToolStripMenuItem,
            this.binarioToolStripMenuItem,
            this.decimalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            // 
            // hexadecimalToolStripMenuItem
            // 
            this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.hexadecimalToolStripMenuItem.Text = "Hexadecimal";
            this.hexadecimalToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalToolStripMenuItem_Click);
            // 
            // binarioToolStripMenuItem
            // 
            this.binarioToolStripMenuItem.Name = "binarioToolStripMenuItem";
            this.binarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.binarioToolStripMenuItem.Text = "Binario";
            this.binarioToolStripMenuItem.Click += new System.EventHandler(this.binarioToolStripMenuItem_Click);
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.decimalToolStripMenuItem.Text = "Decimal";
            this.decimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToolStripMenuItem_Click);
            // 
            // cmbInputBase
            // 
            this.cmbInputBase.FormattingEnabled = true;
            this.cmbInputBase.Location = new System.Drawing.Point(161, 131);
            this.cmbInputBase.Name = "cmbInputBase";
            this.cmbInputBase.Size = new System.Drawing.Size(121, 24);
            this.cmbInputBase.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base de la entrada:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInputBase);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxResult;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnLogX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPorc;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnLnx;
        private System.Windows.Forms.Button bntEquals;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnInvertSign;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnPow3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSquare2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbInputBase;
        private System.Windows.Forms.Label label1;
    }
}

