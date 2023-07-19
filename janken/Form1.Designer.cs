namespace janken
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "はい";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(32, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "グー";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(222, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "チョキ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(405, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "パー";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(109, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "じゃんけんをしましょう！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(109, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "最初はグー、じゃんけん...";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label3.Location = new System.Drawing.Point(234, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "グー！";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label4.Location = new System.Drawing.Point(216, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "チョキ！";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label5.Location = new System.Drawing.Point(216, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "パー！";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label6.Location = new System.Drawing.Point(138, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "あなたの勝ちです！";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label7.Location = new System.Drawing.Point(168, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "私の勝ちです！";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label8.Location = new System.Drawing.Point(138, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 34);
            this.label8.TabIndex = 12;
            this.label8.Text = "もう一度やりますか？";
            this.label8.Visible = false;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(222, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 36);
            this.button6.TabIndex = 13;
            this.button6.Text = "次へ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label9.Location = new System.Drawing.Point(184, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 34);
            this.label9.TabIndex = 14;
            this.label9.Text = "あいこです！";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label10.Location = new System.Drawing.Point(57, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "4";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label11.Location = new System.Drawing.Point(93, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "pt";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label12.Location = new System.Drawing.Point(3, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "player";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label13.Location = new System.Drawing.Point(441, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "CPU";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label14.Location = new System.Drawing.Point(520, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "pt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label15.Location = new System.Drawing.Point(484, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 27);
            this.label15.TabIndex = 18;
            this.label15.Text = "4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label16.Location = new System.Drawing.Point(137, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(278, 34);
            this.label16.TabIndex = 21;
            this.label16.Text = "あなたの勝ちです！";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label17.Location = new System.Drawing.Point(168, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 34);
            this.label17.TabIndex = 22;
            this.label17.Text = "私の勝ちです！";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label18.Location = new System.Drawing.Point(168, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 34);
            this.label18.TabIndex = 23;
            this.label18.Text = "引き分けです！";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label19.Location = new System.Drawing.Point(217, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 27);
            this.label19.TabIndex = 24;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label20.Location = new System.Drawing.Point(249, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 27);
            this.label20.TabIndex = 25;
            this.label20.Text = "/";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label21.Location = new System.Drawing.Point(266, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 27);
            this.label21.TabIndex = 26;
            this.label21.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "じゃんけん";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}

