namespace TextureSpriter
{
    partial class Cutter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Open = new System.Windows.Forms.Button();
            this.TextBox_Open = new System.Windows.Forms.TextBox();
            this.GroupBox_Direction = new System.Windows.Forms.GroupBox();
            this.RadioButton_Vertical = new System.Windows.Forms.RadioButton();
            this.RadioButton_Horizontal = new System.Windows.Forms.RadioButton();
            this.GroupBox_Size = new System.Windows.Forms.GroupBox();
            this.Label_Width = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_Save = new System.Windows.Forms.TextBox();
            this.Button_Extract = new System.Windows.Forms.Button();
            this.GroupBox_Direction.SuspendLayout();
            this.GroupBox_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(13, 14);
            this.Button_Open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(100, 38);
            this.Button_Open.TabIndex = 0;
            this.Button_Open.Text = "Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            // 
            // TextBox_Open
            // 
            this.TextBox_Open.Location = new System.Drawing.Point(120, 20);
            this.TextBox_Open.Name = "TextBox_Open";
            this.TextBox_Open.Size = new System.Drawing.Size(492, 27);
            this.TextBox_Open.TabIndex = 1;
            // 
            // GroupBox_Direction
            // 
            this.GroupBox_Direction.Controls.Add(this.RadioButton_Horizontal);
            this.GroupBox_Direction.Controls.Add(this.RadioButton_Vertical);
            this.GroupBox_Direction.Location = new System.Drawing.Point(12, 60);
            this.GroupBox_Direction.Name = "GroupBox_Direction";
            this.GroupBox_Direction.Size = new System.Drawing.Size(600, 103);
            this.GroupBox_Direction.TabIndex = 2;
            this.GroupBox_Direction.TabStop = false;
            this.GroupBox_Direction.Text = "Direction";
            // 
            // RadioButton_Vertical
            // 
            this.RadioButton_Vertical.AutoSize = true;
            this.RadioButton_Vertical.Checked = true;
            this.RadioButton_Vertical.Location = new System.Drawing.Point(6, 26);
            this.RadioButton_Vertical.Name = "RadioButton_Vertical";
            this.RadioButton_Vertical.Size = new System.Drawing.Size(74, 24);
            this.RadioButton_Vertical.TabIndex = 0;
            this.RadioButton_Vertical.TabStop = true;
            this.RadioButton_Vertical.Text = "Vertical";
            this.RadioButton_Vertical.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Horizontal
            // 
            this.RadioButton_Horizontal.AutoSize = true;
            this.RadioButton_Horizontal.Location = new System.Drawing.Point(6, 56);
            this.RadioButton_Horizontal.Name = "RadioButton_Horizontal";
            this.RadioButton_Horizontal.Size = new System.Drawing.Size(92, 24);
            this.RadioButton_Horizontal.TabIndex = 1;
            this.RadioButton_Horizontal.Text = "Horizontal";
            this.RadioButton_Horizontal.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Size
            // 
            this.GroupBox_Size.Controls.Add(this.numericUpDown2);
            this.GroupBox_Size.Controls.Add(this.numericUpDown1);
            this.GroupBox_Size.Controls.Add(this.Label_Height);
            this.GroupBox_Size.Controls.Add(this.Label_Width);
            this.GroupBox_Size.Location = new System.Drawing.Point(12, 169);
            this.GroupBox_Size.Name = "GroupBox_Size";
            this.GroupBox_Size.Size = new System.Drawing.Size(600, 98);
            this.GroupBox_Size.TabIndex = 3;
            this.GroupBox_Size.TabStop = false;
            this.GroupBox_Size.Text = "Size";
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(6, 23);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(83, 20);
            this.Label_Width.TabIndex = 0;
            this.Label_Width.Text = "Width (px):";
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(6, 56);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(88, 20);
            this.Label_Height.TabIndex = 1;
            this.Label_Height.Text = "Height (px):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(95, 54);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown2.TabIndex = 3;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(13, 275);
            this.Button_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(100, 38);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            // 
            // TextBox_Save
            // 
            this.TextBox_Save.Location = new System.Drawing.Point(120, 281);
            this.TextBox_Save.Name = "TextBox_Save";
            this.TextBox_Save.Size = new System.Drawing.Size(492, 27);
            this.TextBox_Save.TabIndex = 5;
            // 
            // Button_Extract
            // 
            this.Button_Extract.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_Extract.Location = new System.Drawing.Point(458, 370);
            this.Button_Extract.Name = "Button_Extract";
            this.Button_Extract.Size = new System.Drawing.Size(154, 59);
            this.Button_Extract.TabIndex = 6;
            this.Button_Extract.Text = "Extract";
            this.Button_Extract.UseVisualStyleBackColor = true;
            // 
            // Cutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Button_Extract);
            this.Controls.Add(this.TextBox_Save);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.GroupBox_Size);
            this.Controls.Add(this.GroupBox_Direction);
            this.Controls.Add(this.TextBox_Open);
            this.Controls.Add(this.Button_Open);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cutter";
            this.Text = "Texture Spriter - Cutter";
            this.GroupBox_Direction.ResumeLayout(false);
            this.GroupBox_Direction.PerformLayout();
            this.GroupBox_Size.ResumeLayout(false);
            this.GroupBox_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.TextBox TextBox_Open;
        private System.Windows.Forms.GroupBox GroupBox_Direction;
        private System.Windows.Forms.RadioButton RadioButton_Horizontal;
        private System.Windows.Forms.RadioButton RadioButton_Vertical;
        private System.Windows.Forms.GroupBox GroupBox_Size;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_Save;
        private System.Windows.Forms.Button Button_Extract;
    }
}

