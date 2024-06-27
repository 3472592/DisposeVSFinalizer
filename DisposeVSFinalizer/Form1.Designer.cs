namespace DisposeVSFinalizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clone1 = new System.Windows.Forms.Button();
            this.Clone2 = new System.Windows.Forms.Button();
            this.GarbageCollector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clone1
            // 
            this.Clone1.Location = new System.Drawing.Point(12, 12);
            this.Clone1.Name = "Clone1";
            this.Clone1.Size = new System.Drawing.Size(75, 23);
            this.Clone1.TabIndex = 0;
            this.Clone1.Text = "Clone 1";
            this.Clone1.UseVisualStyleBackColor = true;
            this.Clone1.Click += new System.EventHandler(this.Clone1_Click);
            // 
            // Clone2
            // 
            this.Clone2.Location = new System.Drawing.Point(93, 12);
            this.Clone2.Name = "Clone2";
            this.Clone2.Size = new System.Drawing.Size(75, 23);
            this.Clone2.TabIndex = 1;
            this.Clone2.Text = "Clone 2";
            this.Clone2.UseVisualStyleBackColor = true;
            this.Clone2.Click += new System.EventHandler(this.Clone2_Click);
            // 
            // GC
            // 
            this.GarbageCollector.Location = new System.Drawing.Point(174, 12);
            this.GarbageCollector.Name = "GC";
            this.GarbageCollector.Size = new System.Drawing.Size(75, 23);
            this.GarbageCollector.TabIndex = 2;
            this.GarbageCollector.Text = "GarbageCollector";
            this.GarbageCollector.UseVisualStyleBackColor = true;
            this.GarbageCollector.Click += new System.EventHandler(this.GarbageCollector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 45);
            this.Controls.Add(this.GarbageCollector);
            this.Controls.Add(this.Clone2);
            this.Controls.Add(this.Clone1);
            this.Name = "Form1";
            this.Text = "Dispose VS Finalizer";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Clone1;
        private Button Clone2;
        private Button GarbageCollector;
    }
}