namespace MQTTClient
{
    partial class LogCenter
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_LOG = new System.Windows.Forms.TableLayoutPanel();
            this.lb_LOG = new System.Windows.Forms.ListBox();
            this.btn_LOGClear = new System.Windows.Forms.Button();
            this.btn_LOGExport = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tlp_LOG.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_LOG
            // 
            this.tlp_LOG.ColumnCount = 2;
            this.tlp_LOG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LOG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_LOG.Controls.Add(this.lb_LOG, 0, 0);
            this.tlp_LOG.Controls.Add(this.btn_LOGClear, 0, 1);
            this.tlp_LOG.Controls.Add(this.btn_LOGExport, 1, 1);
            this.tlp_LOG.Controls.Add(this.btn_Open, 0, 2);
            this.tlp_LOG.Controls.Add(this.btn_Close, 1, 2);
            this.tlp_LOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LOG.Location = new System.Drawing.Point(0, 0);
            this.tlp_LOG.Name = "tlp_LOG";
            this.tlp_LOG.RowCount = 3;
            this.tlp_LOG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_LOG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_LOG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_LOG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_LOG.Size = new System.Drawing.Size(584, 611);
            this.tlp_LOG.TabIndex = 3;
            // 
            // lb_LOG
            // 
            this.tlp_LOG.SetColumnSpan(this.lb_LOG, 2);
            this.lb_LOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LOG.FormattingEnabled = true;
            this.lb_LOG.ItemHeight = 12;
            this.lb_LOG.Location = new System.Drawing.Point(3, 3);
            this.lb_LOG.Name = "lb_LOG";
            this.lb_LOG.Size = new System.Drawing.Size(578, 505);
            this.lb_LOG.TabIndex = 0;
            // 
            // btn_LOGClear
            // 
            this.btn_LOGClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LOGClear.Location = new System.Drawing.Point(3, 514);
            this.btn_LOGClear.Name = "btn_LOGClear";
            this.btn_LOGClear.Size = new System.Drawing.Size(286, 44);
            this.btn_LOGClear.TabIndex = 1;
            this.btn_LOGClear.Text = "LOG Clear";
            this.btn_LOGClear.UseVisualStyleBackColor = true;
            this.btn_LOGClear.Click += new System.EventHandler(this.btn_LOGClear_Click);
            // 
            // btn_LOGExport
            // 
            this.btn_LOGExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_LOGExport.Location = new System.Drawing.Point(295, 514);
            this.btn_LOGExport.Name = "btn_LOGExport";
            this.btn_LOGExport.Size = new System.Drawing.Size(286, 44);
            this.btn_LOGExport.TabIndex = 2;
            this.btn_LOGExport.Text = "LOG Export";
            this.btn_LOGExport.UseVisualStyleBackColor = true;
            // 
            // btn_Open
            // 
            this.btn_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Open.Location = new System.Drawing.Point(3, 564);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(286, 44);
            this.btn_Open.TabIndex = 3;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Location = new System.Drawing.Point(295, 564);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(286, 44);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // LogCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.tlp_LOG);
            this.Name = "LogCenter";
            this.Text = "LOG Center - Client";
            this.tlp_LOG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_LOG;
        private System.Windows.Forms.ListBox lb_LOG;
        private System.Windows.Forms.Button btn_LOGClear;
        private System.Windows.Forms.Button btn_LOGExport;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Close;
    }
}

