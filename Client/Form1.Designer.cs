namespace Client
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbua = new System.Windows.Forms.Button();
            this.btnbao = new System.Windows.Forms.Button();
            this.btnkeo = new System.Windows.Forms.Button();
            this.textBoxyourselec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kết quả :";
            // 
            // btnbua
            // 
            this.btnbua.Location = new System.Drawing.Point(378, 94);
            this.btnbua.Margin = new System.Windows.Forms.Padding(4);
            this.btnbua.Name = "btnbua";
            this.btnbua.Size = new System.Drawing.Size(120, 77);
            this.btnbua.TabIndex = 11;
            this.btnbua.Text = "Búa";
            this.btnbua.UseVisualStyleBackColor = true;
            this.btnbua.Click += new System.EventHandler(this.btnbua_Click);
            // 
            // btnbao
            // 
            this.btnbao.Location = new System.Drawing.Point(201, 94);
            this.btnbao.Margin = new System.Windows.Forms.Padding(4);
            this.btnbao.Name = "btnbao";
            this.btnbao.Size = new System.Drawing.Size(120, 77);
            this.btnbao.TabIndex = 10;
            this.btnbao.Text = "Bao";
            this.btnbao.UseVisualStyleBackColor = true;
            this.btnbao.Click += new System.EventHandler(this.btnbao_Click);
            // 
            // btnkeo
            // 
            this.btnkeo.Location = new System.Drawing.Point(25, 94);
            this.btnkeo.Margin = new System.Windows.Forms.Padding(4);
            this.btnkeo.Name = "btnkeo";
            this.btnkeo.Size = new System.Drawing.Size(120, 77);
            this.btnkeo.TabIndex = 9;
            this.btnkeo.Text = "Kéo";
            this.btnkeo.UseVisualStyleBackColor = true;
            this.btnkeo.Click += new System.EventHandler(this.btnkeo_Click);
            // 
            // textBoxyourselec
            // 
            this.textBoxyourselec.Location = new System.Drawing.Point(145, 33);
            this.textBoxyourselec.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxyourselec.Name = "textBoxyourselec";
            this.textBoxyourselec.Size = new System.Drawing.Size(347, 22);
            this.textBoxyourselec.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bạn Chọn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbua);
            this.Controls.Add(this.btnbao);
            this.Controls.Add(this.btnkeo);
            this.Controls.Add(this.textBoxyourselec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trò chơi kéo búa bao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbua;
        private System.Windows.Forms.Button btnbao;
        private System.Windows.Forms.Button btnkeo;
        private System.Windows.Forms.TextBox textBoxyourselec;
        private System.Windows.Forms.Label label1;
    }
}

