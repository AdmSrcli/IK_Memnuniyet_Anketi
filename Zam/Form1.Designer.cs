namespace Zam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btnevet = new Button();
            btnhayir = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            progressBar1 = new ProgressBar();
            lblmemnuniyet = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(354, 370);
            label1.Name = "label1";
            label1.Size = new Size(130, 39);
            label1.TabIndex = 0;
            label1.Text = "SORU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 370);
            label2.Name = "label2";
            label2.Size = new Size(124, 42);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // btnevet
            // 
            btnevet.BackColor = Color.White;
            btnevet.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnevet.Location = new Point(1049, 654);
            btnevet.Name = "btnevet";
            btnevet.Size = new Size(179, 68);
            btnevet.TabIndex = 2;
            btnevet.Text = "EVET";
            btnevet.UseVisualStyleBackColor = false;
            btnevet.Click += btnevet_Click;
            // 
            // btnhayir
            // 
            btnhayir.BackColor = Color.White;
            btnhayir.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            btnhayir.Location = new Point(443, 654);
            btnhayir.Name = "btnhayir";
            btnhayir.Size = new Size(179, 68);
            btnhayir.TabIndex = 3;
            btnhayir.Text = "HAYIR";
            btnhayir.UseVisualStyleBackColor = false;
            btnhayir.MouseMove += btnhayir_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(473, 292);
            label3.Name = "label3";
            label3.Size = new Size(755, 39);
            label3.TabIndex = 4;
            label3.Text = "İNSAN KAYNAKLARI MEMNUNİYET ANKETİ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1449, 736);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Blue;
            progressBar1.ForeColor = Color.Blue;
            progressBar1.Location = new Point(419, 174);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1359, 82);
            progressBar1.TabIndex = 7;
            progressBar1.Value = 6;
            // 
            // lblmemnuniyet
            // 
            lblmemnuniyet.AutoSize = true;
            lblmemnuniyet.BackColor = Color.Transparent;
            lblmemnuniyet.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold);
            lblmemnuniyet.ForeColor = Color.Yellow;
            lblmemnuniyet.Location = new Point(852, 78);
            lblmemnuniyet.Name = "lblmemnuniyet";
            lblmemnuniyet.Size = new Size(320, 39);
            lblmemnuniyet.TabIndex = 8;
            lblmemnuniyet.Text = "Memnuniyet Oranı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1842, 1055);
            Controls.Add(lblmemnuniyet);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(btnhayir);
            Controls.Add(btnevet);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "ZAM DEĞERLENDİRME FORMU";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnevet;
        private Button btnhayir;
        private Label label3;
        private PictureBox pictureBox2;
        private ProgressBar progressBar1;
        private Label lblmemnuniyet;
    }
}
