namespace TextureSpriter
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.Label_Name = new System.Windows.Forms.Label();
            this.Button_Cutter = new System.Windows.Forms.Button();
            this.Button_Marger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Name.Location = new System.Drawing.Point(16, 15);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(189, 36);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Texture Spriter";
            // 
            // Button_Cutter
            // 
            this.Button_Cutter.Location = new System.Drawing.Point(13, 56);
            this.Button_Cutter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Cutter.Name = "Button_Cutter";
            this.Button_Cutter.Size = new System.Drawing.Size(100, 38);
            this.Button_Cutter.TabIndex = 1;
            this.Button_Cutter.Text = "Cutter";
            this.Button_Cutter.UseVisualStyleBackColor = true;
            this.Button_Cutter.Click += new System.EventHandler(this.Button_Cutter_Click);
            // 
            // Button_Marger
            // 
            this.Button_Marger.Location = new System.Drawing.Point(151, 56);
            this.Button_Marger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Marger.Name = "Button_Marger";
            this.Button_Marger.Size = new System.Drawing.Size(100, 38);
            this.Button_Marger.TabIndex = 2;
            this.Button_Marger.Text = "Marger";
            this.Button_Marger.UseVisualStyleBackColor = true;
            this.Button_Marger.Click += new System.EventHandler(this.Button_Marger_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 141);
            this.Controls.Add(this.Button_Marger);
            this.Controls.Add(this.Button_Cutter);
            this.Controls.Add(this.Label_Name);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texture Spriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Button Button_Cutter;
        private System.Windows.Forms.Button Button_Marger;
    }
}