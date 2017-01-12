namespace CSharpCalculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tlpNumpad = new System.Windows.Forms.TableLayoutPanel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.tlpOperations = new System.Windows.Forms.TableLayoutPanel();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulitply = new System.Windows.Forms.Button();
            this.tlpNumpad.SuspendLayout();
            this.tlpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoEllipsis = true;
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplay.Location = new System.Drawing.Point(14, 14);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.lblDisplay.MinimumSize = new System.Drawing.Size(226, 37);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.lblDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisplay.Size = new System.Drawing.Size(226, 37);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = Constants.ZERO;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tlpNumpad
            // 
            this.tlpNumpad.ColumnCount = 3;
            this.tlpNumpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNumpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpNumpad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpNumpad.Controls.Add(this.btn7, 0, 0);
            this.tlpNumpad.Controls.Add(this.btn8, 1, 0);
            this.tlpNumpad.Controls.Add(this.btn9, 2, 0);
            this.tlpNumpad.Controls.Add(this.btn4, 0, 1);
            this.tlpNumpad.Controls.Add(this.btn5, 1, 1);
            this.tlpNumpad.Controls.Add(this.btn6, 2, 1);
            this.tlpNumpad.Controls.Add(this.btn1, 0, 2);
            this.tlpNumpad.Controls.Add(this.btn2, 1, 2);
            this.tlpNumpad.Controls.Add(this.btn3, 2, 2);
            this.tlpNumpad.Controls.Add(this.btn0, 0, 3);
            this.tlpNumpad.Controls.Add(this.btnDecimal, 2, 3);
            this.tlpNumpad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpNumpad.Location = new System.Drawing.Point(14, 59);
            this.tlpNumpad.Name = "tlpNumpad";
            this.tlpNumpad.RowCount = 4;
            this.tlpNumpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumpad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNumpad.Size = new System.Drawing.Size(125, 161);
            this.tlpNumpad.TabIndex = 3;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 34);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(44, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 34);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(85, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 34);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(3, 43);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 34);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(44, 43);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 34);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(85, 43);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 34);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(3, 83);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 34);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(44, 83);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 34);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(85, 83);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 34);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlText;
            this.tlpNumpad.SetColumnSpan(this.btn0, 2);
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.ForeColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(3, 123);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 35);
            this.btn0.TabIndex = 9;
            this.btn0.Text = Constants.ZERO;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecimal.FlatAppearance.BorderSize = 2;
            this.btnDecimal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDecimal.Location = new System.Drawing.Point(85, 123);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(37, 35);
            this.btnDecimal.TabIndex = 10;
            this.btnDecimal.Text = Constants.DECIMAL_POINT.ToString();
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // tlpOperations
            // 
            this.tlpOperations.ColumnCount = 2;
            this.tlpOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlpOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpOperations.Controls.Add(this.btnCE, 0, 0);
            this.tlpOperations.Controls.Add(this.btnCL, 1, 0);
            this.tlpOperations.Controls.Add(this.btnMinus, 0, 2);
            this.tlpOperations.Controls.Add(this.btnDivide, 1, 2);
            this.tlpOperations.Controls.Add(this.btnModulo, 0, 3);
            this.tlpOperations.Controls.Add(this.btnPower, 1, 3);
            this.tlpOperations.Controls.Add(this.btnEquals, 0, 4);
            this.tlpOperations.Controls.Add(this.btnPlus, 0, 1);
            this.tlpOperations.Controls.Add(this.btnMulitply, 1, 1);
            this.tlpOperations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlpOperations.Location = new System.Drawing.Point(145, 59);
            this.tlpOperations.Name = "tlpOperations";
            this.tlpOperations.RowCount = 5;
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOperations.Size = new System.Drawing.Size(98, 161);
            this.tlpOperations.TabIndex = 4;
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCE.FlatAppearance.BorderSize = 2;
            this.btnCE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCE.Location = new System.Drawing.Point(3, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(42, 26);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = Constants.CLEAR_ENTRY;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCL
            // 
            this.btnCL.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCL.FlatAppearance.BorderSize = 2;
            this.btnCL.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCL.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCL.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCL.Location = new System.Drawing.Point(51, 3);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(44, 26);
            this.btnCL.TabIndex = 1;
            this.btnCL.Text = Constants.CLEAR;
            this.btnCL.UseVisualStyleBackColor = false;
            this.btnCL.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.FlatAppearance.BorderSize = 2;
            this.btnMinus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinus.Location = new System.Drawing.Point(3, 67);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(42, 26);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = Constants.SIGN_MINUS.ToString();
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnDivide.FlatAppearance.BorderSize = 2;
            this.btnDivide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDivide.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDivide.Location = new System.Drawing.Point(51, 67);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(44, 26);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = Constants.SIGN_DIVIDE.ToString();
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.button_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModulo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnModulo.FlatAppearance.BorderSize = 2;
            this.btnModulo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModulo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModulo.Location = new System.Drawing.Point(3, 99);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(42, 26);
            this.btnModulo.TabIndex = 6;
            this.btnModulo.Text = Constants.SIGN_MODULO.ToString();
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.button_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPower.FlatAppearance.BorderSize = 2;
            this.btnPower.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPower.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPower.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPower.Location = new System.Drawing.Point(51, 99);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(44, 26);
            this.btnPower.TabIndex = 7;
            this.btnPower.Text = Constants.SIGN_POWER.ToString();
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.button_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ControlText;
            this.tlpOperations.SetColumnSpan(this.btnEquals, 2);
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEquals.FlatAppearance.BorderSize = 2;
            this.btnEquals.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnEquals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEquals.Location = new System.Drawing.Point(3, 131);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(92, 27);
            this.btnEquals.TabIndex = 9;
            this.btnEquals.Text = Constants.SIGN_EQUALS.ToString();
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.button_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.FlatAppearance.BorderSize = 2;
            this.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlus.Location = new System.Drawing.Point(3, 35);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(42, 26);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = Constants.SIGN_PLUS.ToString();
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.button_Click);
            // 
            // btnMulitply
            // 
            this.btnMulitply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMulitply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMulitply.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnMulitply.FlatAppearance.BorderSize = 2;
            this.btnMulitply.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMulitply.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMulitply.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMulitply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulitply.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMulitply.Location = new System.Drawing.Point(51, 35);
            this.btnMulitply.Name = "btnMulitply";
            this.btnMulitply.Size = new System.Drawing.Size(44, 26);
            this.btnMulitply.TabIndex = 11;
            this.btnMulitply.Text = Constants.SIGN_MULTIPLY.ToString();
            this.btnMulitply.UseVisualStyleBackColor = false;
            this.btnMulitply.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(257, 232);
            this.Controls.Add(this.tlpOperations);
            this.Controls.Add(this.tlpNumpad);
            this.Controls.Add(this.lblDisplay);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(275, 277);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpNumpad.ResumeLayout(false);
            this.tlpOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TableLayoutPanel tlpNumpad;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TableLayoutPanel tlpOperations;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulitply;
    }
}

