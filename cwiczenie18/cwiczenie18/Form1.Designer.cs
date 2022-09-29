
namespace cwiczenie18
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.breakfastLine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię drwala";
            // 
            // breakfastLine
            // 
            this.breakfastLine.Location = new System.Drawing.Point(224, 22);
            this.breakfastLine.Name = "breakfastLine";
            this.breakfastLine.Size = new System.Drawing.Size(149, 20);
            this.breakfastLine.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj drwala";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolejka do śniadania";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Items.AddRange(new object[] {
            "1. Edek",
            "2. Zyga",
            "3. Bolek",
            "4. Ferdek",
            "5. Stachu"});
            this.line.Location = new System.Drawing.Point(37, 120);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(118, 329);
            this.line.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nakarm drwala";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(214, 131);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(214, 157);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(79, 17);
            this.crispy.TabIndex = 11;
            this.crispy.TabStop = true;
            this.crispy.Text = "Chrupkiego";
            this.crispy.UseVisualStyleBackColor = true;
            this.crispy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(214, 184);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(79, 17);
            this.soggy.TabIndex = 12;
            this.soggy.TabStop = true;
            this.soggy.Text = "Wilgotnego";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(214, 207);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(79, 17);
            this.browned.TabIndex = 13;
            this.browned.TabStop = true;
            this.browned.Text = "Rumianego";
            this.browned.UseVisualStyleBackColor = true;
            this.browned.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(214, 230);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bananowego";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Dodaj naleśniki";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 67);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Edek ma 8 naleśników";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Następny drwal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.browned);
            this.Controls.Add(this.soggy);
            this.Controls.Add(this.crispy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.breakfastLine);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox breakfastLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

