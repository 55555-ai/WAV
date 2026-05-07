namespace WAV
{
    partial class frmWAVPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Controls.Add(this.btnBrowse);
            this.grpPath.Location = new System.Drawing.Point(106, 92);
            this.grpPath.Name = "grpPath";
            this.grpPath.Size = new System.Drawing.Size(701, 194);
            this.grpPath.TabIndex = 0;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "音效位置";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(49, 69);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(458, 36);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(585, 90);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 104);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnEnd);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Location = new System.Drawing.Point(106, 388);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(701, 200);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "播放按鈕";
            this.grpButton.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(519, 53);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 80);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "結束程式";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(351, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 80);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止播放";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(192, 53);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 80);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "重複播放";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(49, 53);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 80);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "播放一次";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "wav";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmWAVPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 728);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPath);
            this.Name = "frmWAVPlayer";
            this.Text = "WAV音效播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

