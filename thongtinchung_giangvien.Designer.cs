namespace UINHOM2
{
    partial class thongtinchung_giangvien
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(441, 116);
            label1.TabIndex = 0;
            label1.Text = "Hiển thị các thông tin cá nhân của giảng viên như: Tên, ngày tháng sinh, địa chỉ nhà,...";
            label1.Click += label1_Click;
            // 
            // thongtinchung_giangvien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "thongtinchung_giangvien";
            Text = "thongtinchung_giangvien";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}