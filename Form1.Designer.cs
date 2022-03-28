
namespace PhoneCheck
{
    partial class Form1
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
            this.txtDepkeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbPhone = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomkeyword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDepkeyword
            // 
            this.txtDepkeyword.Location = new System.Drawing.Point(97, 12);
            this.txtDepkeyword.Name = "txtDepkeyword";
            this.txtDepkeyword.Size = new System.Drawing.Size(119, 22);
            this.txtDepkeyword.TabIndex = 0;
            this.txtDepkeyword.TextChanged += new System.EventHandler(this.txtDepkeyword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "部門關鍵字：";
            // 
            // lsbPhone
            // 
            this.lsbPhone.FormattingEnabled = true;
            this.lsbPhone.ItemHeight = 12;
            this.lsbPhone.Location = new System.Drawing.Point(18, 94);
            this.lsbPhone.Name = "lsbPhone";
            this.lsbPhone.ScrollAlwaysVisible = true;
            this.lsbPhone.Size = new System.Drawing.Size(330, 316);
            this.lsbPhone.Sorted = true;
            this.lsbPhone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "查詢清單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "處室關鍵字：";
            // 
            // txtRoomkeyword
            // 
            this.txtRoomkeyword.Location = new System.Drawing.Point(97, 37);
            this.txtRoomkeyword.Name = "txtRoomkeyword";
            this.txtRoomkeyword.Size = new System.Drawing.Size(119, 22);
            this.txtRoomkeyword.TabIndex = 4;
            this.txtRoomkeyword.TextChanged += new System.EventHandler(this.txtRoomkeyword_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomkeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepkeyword);
            this.Name = "Form1";
            this.Text = "電話查詢表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepkeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomkeyword;
    }
}

