namespace SampleThumbnailView
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.lbl_file = new System.Windows.Forms.Label();
            this.txb_file = new System.Windows.Forms.TextBox();
            this.btn_ref = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.pcb_preview = new System.Windows.Forms.PictureBox();
            this.lbl_preview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(19, 24);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(45, 12);
            this.lbl_file.TabIndex = 0;
            this.lbl_file.Text = "ファイル：";
            // 
            // txb_file
            // 
            this.txb_file.Location = new System.Drawing.Point(70, 21);
            this.txb_file.Name = "txb_file";
            this.txb_file.Size = new System.Drawing.Size(222, 19);
            this.txb_file.TabIndex = 1;
            // 
            // btn_ref
            // 
            this.btn_ref.Location = new System.Drawing.Point(298, 19);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(51, 23);
            this.btn_ref.TabIndex = 2;
            this.btn_ref.Text = "参照";
            this.btn_ref.UseVisualStyleBackColor = true;
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(355, 19);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 3;
            this.btn_read.Text = "表示";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // pcb_preview
            // 
            this.pcb_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_preview.Location = new System.Drawing.Point(70, 64);
            this.pcb_preview.Name = "pcb_preview";
            this.pcb_preview.Size = new System.Drawing.Size(360, 235);
            this.pcb_preview.TabIndex = 4;
            this.pcb_preview.TabStop = false;
            // 
            // lbl_preview
            // 
            this.lbl_preview.AutoSize = true;
            this.lbl_preview.Location = new System.Drawing.Point(9, 64);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(55, 12);
            this.lbl_preview.TabIndex = 5;
            this.lbl_preview.Text = "プレビュー：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.pcb_preview);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_ref);
            this.Controls.Add(this.txb_file);
            this.Controls.Add(this.lbl_file);
            this.Name = "Form1";
            this.Text = "プレビュー表示サンプル";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.TextBox txb_file;
        private System.Windows.Forms.Button btn_ref;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.PictureBox pcb_preview;
        private System.Windows.Forms.Label lbl_preview;
    }
}

