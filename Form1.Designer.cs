namespace CSharp_List
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
            btnNhap = new Button();
            label1 = new Label();
            txtNhap = new TextBox();
            label2 = new Label();
            txtSoLe = new TextBox();
            label3 = new Label();
            txtSNT = new TextBox();
            btnTimLe = new Button();
            btnTim2 = new Button();
            SuspendLayout();
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(505, 76);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 76);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhap n";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(226, 73);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(240, 23);
            txtNhap.TabIndex = 2;
            txtNhap.TextChanged += txtNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 122);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "So le trong mang";
            // 
            // txtSoLe
            // 
            txtSoLe.Location = new Point(226, 122);
            txtSoLe.Name = "txtSoLe";
            txtSoLe.Size = new Size(240, 23);
            txtSoLe.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 178);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 1;
            label3.Text = "SNT trong mang";
            // 
            // txtSNT
            // 
            txtSNT.Location = new Point(226, 178);
            txtSNT.Name = "txtSNT";
            txtSNT.Size = new Size(240, 23);
            txtSNT.TabIndex = 2;
            // 
            // btnTimLe
            // 
            btnTimLe.Location = new Point(505, 122);
            btnTimLe.Name = "btnTimLe";
            btnTimLe.Size = new Size(75, 23);
            btnTimLe.TabIndex = 3;
            btnTimLe.Text = "Tim";
            btnTimLe.UseVisualStyleBackColor = true;
            btnTimLe.Click += btnTimLe_Click;
            // 
            // btnTim2
            // 
            btnTim2.Location = new Point(505, 177);
            btnTim2.Name = "btnTim2";
            btnTim2.Size = new Size(75, 23);
            btnTim2.TabIndex = 3;
            btnTim2.Text = "Tim";
            btnTim2.UseVisualStyleBackColor = true;
            btnTim2.Click += btnTimLe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTim2);
            Controls.Add(btnTimLe);
            Controls.Add(txtSNT);
            Controls.Add(label3);
            Controls.Add(txtSoLe);
            Controls.Add(label2);
            Controls.Add(txtNhap);
            Controls.Add(label1);
            Controls.Add(btnNhap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNhap;
        private Label label1;
        private TextBox txtNhap;
        private Label label2;
        private TextBox txtSoLe;
        private Label label3;
        private TextBox txtSNT;
        private Button btnTimLe;
        private Button btnTim2;
    }
}
