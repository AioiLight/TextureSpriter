namespace TextureSpriter
{
    partial class Marger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marger));
            this.Button_Open = new System.Windows.Forms.Button();
            this.TextBox_Open = new System.Windows.Forms.TextBox();
            this.GroupBox_Direction = new System.Windows.Forms.GroupBox();
            this.RadioButton_Horizontal = new System.Windows.Forms.RadioButton();
            this.RadioButton_Vertical = new System.Windows.Forms.RadioButton();
            this.GroupBox_Size = new System.Windows.Forms.GroupBox();
            this.NumBox_Height = new System.Windows.Forms.NumericUpDown();
            this.NumBox_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.Label_Width = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_Save = new System.Windows.Forms.TextBox();
            this.Button_Extract = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.GroupBox_Direction.SuspendLayout();
            this.GroupBox_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Open
            // 
            resources.ApplyResources(this.Button_Open, "Button_Open");
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // TextBox_Open
            // 
            resources.ApplyResources(this.TextBox_Open, "TextBox_Open");
            this.TextBox_Open.Name = "TextBox_Open";
            // 
            // GroupBox_Direction
            // 
            resources.ApplyResources(this.GroupBox_Direction, "GroupBox_Direction");
            this.GroupBox_Direction.Controls.Add(this.RadioButton_Horizontal);
            this.GroupBox_Direction.Controls.Add(this.RadioButton_Vertical);
            this.GroupBox_Direction.Name = "GroupBox_Direction";
            this.GroupBox_Direction.TabStop = false;
            // 
            // RadioButton_Horizontal
            // 
            resources.ApplyResources(this.RadioButton_Horizontal, "RadioButton_Horizontal");
            this.RadioButton_Horizontal.Name = "RadioButton_Horizontal";
            this.RadioButton_Horizontal.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Vertical
            // 
            resources.ApplyResources(this.RadioButton_Vertical, "RadioButton_Vertical");
            this.RadioButton_Vertical.Checked = true;
            this.RadioButton_Vertical.Name = "RadioButton_Vertical";
            this.RadioButton_Vertical.TabStop = true;
            this.RadioButton_Vertical.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Size
            // 
            resources.ApplyResources(this.GroupBox_Size, "GroupBox_Size");
            this.GroupBox_Size.Controls.Add(this.NumBox_Height);
            this.GroupBox_Size.Controls.Add(this.NumBox_Width);
            this.GroupBox_Size.Controls.Add(this.Label_Height);
            this.GroupBox_Size.Controls.Add(this.Label_Width);
            this.GroupBox_Size.Name = "GroupBox_Size";
            this.GroupBox_Size.TabStop = false;
            // 
            // NumBox_Height
            // 
            resources.ApplyResources(this.NumBox_Height, "NumBox_Height");
            this.NumBox_Height.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumBox_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBox_Height.Name = "NumBox_Height";
            this.NumBox_Height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumBox_Width
            // 
            resources.ApplyResources(this.NumBox_Width, "NumBox_Width");
            this.NumBox_Width.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumBox_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBox_Width.Name = "NumBox_Width";
            this.NumBox_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Height
            // 
            resources.ApplyResources(this.Label_Height, "Label_Height");
            this.Label_Height.Name = "Label_Height";
            // 
            // Label_Width
            // 
            resources.ApplyResources(this.Label_Width, "Label_Width");
            this.Label_Width.Name = "Label_Width";
            // 
            // Button_Save
            // 
            resources.ApplyResources(this.Button_Save, "Button_Save");
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TextBox_Save
            // 
            resources.ApplyResources(this.TextBox_Save, "TextBox_Save");
            this.TextBox_Save.Name = "TextBox_Save";
            // 
            // Button_Extract
            // 
            resources.ApplyResources(this.Button_Extract, "Button_Extract");
            this.Button_Extract.Name = "Button_Extract";
            this.Button_Extract.UseVisualStyleBackColor = true;
            this.Button_Extract.Click += new System.EventHandler(this.Button_Extract_Click);
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            // 
            // Marger
            // 
            this.AcceptButton = this.Button_Extract;
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Button_Extract);
            this.Controls.Add(this.TextBox_Save);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.GroupBox_Size);
            this.Controls.Add(this.GroupBox_Direction);
            this.Controls.Add(this.TextBox_Open);
            this.Controls.Add(this.Button_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Marger";
            this.ShowInTaskbar = false;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Marger_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Marger_DragEnter);
            this.GroupBox_Direction.ResumeLayout(false);
            this.GroupBox_Direction.PerformLayout();
            this.GroupBox_Size.ResumeLayout(false);
            this.GroupBox_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Width)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NumBox_Height;
        private System.Windows.Forms.NumericUpDown NumBox_Width;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_Save;
        private System.Windows.Forms.Button Button_Extract;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

