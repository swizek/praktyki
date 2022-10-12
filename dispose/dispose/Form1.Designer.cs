
namespace dispose
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
            this.clone1 = new System.Windows.Forms.Button();
            this.clone2 = new System.Windows.Forms.Button();
            this.gc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clone1
            // 
            this.clone1.Location = new System.Drawing.Point(144, 12);
            this.clone1.Name = "clone1";
            this.clone1.Size = new System.Drawing.Size(75, 23);
            this.clone1.TabIndex = 0;
            this.clone1.Text = "Klon1.";
            this.clone1.UseVisualStyleBackColor = true;
            this.clone1.Click += new System.EventHandler(this.clone1_Click);
            // 
            // clone2
            // 
            this.clone2.Location = new System.Drawing.Point(144, 36);
            this.clone2.Name = "clone2";
            this.clone2.Size = new System.Drawing.Size(75, 23);
            this.clone2.TabIndex = 1;
            this.clone2.Text = "Klon2.";
            this.clone2.UseVisualStyleBackColor = true;
            this.clone2.Click += new System.EventHandler(this.clone2_Click);
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(144, 65);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(75, 23);
            this.gc.TabIndex = 2;
            this.gc.Text = "GC";
            this.gc.UseVisualStyleBackColor = true;
            this.gc.Click += new System.EventHandler(this.gc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.clone2);
            this.Controls.Add(this.clone1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clone1;
        private System.Windows.Forms.Button clone2;
        private System.Windows.Forms.Button gc;
    }
}

