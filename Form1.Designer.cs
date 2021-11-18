
namespace TableCopyFontChangeTest
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
            this.btRunTest = new System.Windows.Forms.Button();
            this.btLoadText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunTest
            // 
            this.btRunTest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunTest.Location = new System.Drawing.Point(32, 23);
            this.btRunTest.Name = "btRunTest";
            this.btRunTest.Size = new System.Drawing.Size(287, 37);
            this.btRunTest.TabIndex = 0;
            this.btRunTest.Text = "Table Copy Test";
            this.btRunTest.UseVisualStyleBackColor = true;
            this.btRunTest.Click += new System.EventHandler(this.btRunTest_Click);
            // 
            // btLoadText
            // 
            this.btLoadText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadText.Location = new System.Drawing.Point(32, 66);
            this.btLoadText.Name = "btLoadText";
            this.btLoadText.Size = new System.Drawing.Size(287, 37);
            this.btLoadText.TabIndex = 1;
            this.btLoadText.Text = "LoadText Test";
            this.btLoadText.UseVisualStyleBackColor = true;
            this.btLoadText.Click += new System.EventHandler(this.btLoadText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 117);
            this.Controls.Add(this.btLoadText);
            this.Controls.Add(this.btRunTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunTest;
        private System.Windows.Forms.Button btLoadText;
    }
}

