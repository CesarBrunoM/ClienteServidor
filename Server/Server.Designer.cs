﻿
namespace Server
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor: ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(240, 446);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(147, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(81, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(459, 23);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(81, 61);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(459, 339);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(81, 417);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(459, 23);
            this.txtMessage.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagem: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(393, 446);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 15;
            this.lstClientIP.Location = new System.Drawing.Point(558, 61);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(253, 424);
            this.lstClientIP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cliente IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Label label3;
    }
}

