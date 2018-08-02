namespace NXPTestClient
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Cmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_Resulst = new System.Windows.Forms.RichTextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUT_IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(401, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUT_PORT:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_IP.Location = new System.Drawing.Point(129, 14);
            this.textBox_IP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(243, 33);
            this.textBox_IP.TabIndex = 2;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Port.Location = new System.Drawing.Point(534, 14);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(130, 33);
            this.textBox_Port.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "测试命令:";
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Location = new System.Drawing.Point(129, 102);
            this.textBox_Cmd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBox_Cmd.Multiline = true;
            this.textBox_Cmd.Name = "textBox_Cmd";
            this.textBox_Cmd.Size = new System.Drawing.Size(920, 78);
            this.textBox_Cmd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "命令响应:";
            // 
            // richTextBox_Resulst
            // 
            this.richTextBox_Resulst.Enabled = false;
            this.richTextBox_Resulst.Location = new System.Drawing.Point(129, 248);
            this.richTextBox_Resulst.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.richTextBox_Resulst.Name = "richTextBox_Resulst";
            this.richTextBox_Resulst.Size = new System.Drawing.Size(920, 183);
            this.richTextBox_Resulst.TabIndex = 7;
            this.richTextBox_Resulst.Text = "";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(504, 196);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(120, 33);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "发送命令";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(701, 14);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(120, 33);
            this.button_Connect.TabIndex = 9;
            this.button_Connect.Text = "连接";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 447);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.richTextBox_Resulst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "NXP测试客户端";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Cmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_Resulst;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Connect;
    }
}

