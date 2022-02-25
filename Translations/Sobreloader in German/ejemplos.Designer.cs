namespace Sobreloader
{
    partial class ejemplos
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelw = new System.Windows.Forms.Label();
            this.labelWW = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einige Namen zum Ausführen von Programmen:\r\n(Klicken Sie auf ein Element, um weit" +
                "ere Informationen anzuzeigen)";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "mspaint",
            "notepad",
            "wordpad",
            "iexplore",
            "explorer",
            "charmap",
            "taskmgr",
            "control"});
            this.listBox1.Location = new System.Drawing.Point(15, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 116);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.White;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(8, 14);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(90, 25);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Namen";
            // 
            // labelDesc
            // 
            this.labelDesc.BackColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(255, 38);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(281, 87);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Kopieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelWW);
            this.panel1.Controls.Add(this.labelw);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Location = new System.Drawing.Point(245, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 199);
            this.panel1.TabIndex = 5;
            // 
            // labelw
            // 
            this.labelw.AutoSize = true;
            this.labelw.Location = new System.Drawing.Point(13, 170);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(69, 13);
            this.labelw.TabIndex = 3;
            this.labelw.Text = "Arbeiten Sie an:";
            // 
            // labelWW
            // 
            this.labelWW.AutoSize = true;
            this.labelWW.Location = new System.Drawing.Point(79, 170);
            this.labelWW.Name = "labelWW";
            this.labelWW.Size = new System.Drawing.Size(78, 13);
            this.labelWW.TabIndex = 4;
            this.labelWW.Text = "Mehreren Systemen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Testen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ejemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ejemplos";
            this.ShowInTaskbar = false;
            this.Text = "Beispiel";
            this.Load += new System.EventHandler(this.ejemplos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWW;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Button button2;
    }
}
