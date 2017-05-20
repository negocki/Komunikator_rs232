namespace Komunikator
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
            this.components = new System.ComponentModel.Container();
            this.textBox_ipsend = new System.Windows.Forms.TextBox();
            this.textBox_iprec = new System.Windows.Forms.TextBox();
            this.textBox_portsend = new System.Windows.Forms.TextBox();
            this.textBox_portrec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_constatus = new System.Windows.Forms.Label();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.button_discon = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_coded = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // textBox_ipsend
            // 
            this.textBox_ipsend.Location = new System.Drawing.Point(109, 12);
            this.textBox_ipsend.Name = "textBox_ipsend";
            this.textBox_ipsend.Size = new System.Drawing.Size(100, 20);
            this.textBox_ipsend.TabIndex = 0;
            this.textBox_ipsend.Text = "127.0.0.1";
            this.textBox_ipsend.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_iprec
            // 
            this.textBox_iprec.Location = new System.Drawing.Point(109, 38);
            this.textBox_iprec.Name = "textBox_iprec";
            this.textBox_iprec.Size = new System.Drawing.Size(100, 20);
            this.textBox_iprec.TabIndex = 1;
            this.textBox_iprec.Text = "127.0.0.1";
            // 
            // textBox_portsend
            // 
            this.textBox_portsend.Location = new System.Drawing.Point(231, 12);
            this.textBox_portsend.Name = "textBox_portsend";
            this.textBox_portsend.Size = new System.Drawing.Size(40, 20);
            this.textBox_portsend.TabIndex = 2;
            this.textBox_portsend.Text = "15555";
            // 
            // textBox_portrec
            // 
            this.textBox_portrec.Location = new System.Drawing.Point(231, 38);
            this.textBox_portrec.Name = "textBox_portrec";
            this.textBox_portrec.Size = new System.Drawing.Size(40, 20);
            this.textBox_portrec.TabIndex = 3;
            this.textBox_portrec.Text = "15556";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP wysyłanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP odbieranie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(292, 12);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 20);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Połącz";
            this.button_connect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // label_constatus
            // 
            this.label_constatus.AutoSize = true;
            this.label_constatus.Location = new System.Drawing.Point(58, 71);
            this.label_constatus.Name = "label_constatus";
            this.label_constatus.Size = new System.Drawing.Size(65, 13);
            this.label_constatus.TabIndex = 10;
            this.label_constatus.Text = "Rozłączono";
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.Location = new System.Drawing.Point(12, 87);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.ReadOnly = true;
            this.richTextBox_messages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_messages.Size = new System.Drawing.Size(372, 215);
            this.richTextBox_messages.TabIndex = 11;
            this.richTextBox_messages.Text = "";
            // 
            // button_discon
            // 
            this.button_discon.Enabled = false;
            this.button_discon.Location = new System.Drawing.Point(292, 38);
            this.button_discon.Name = "button_discon";
            this.button_discon.Size = new System.Drawing.Size(75, 20);
            this.button_discon.TabIndex = 12;
            this.button_discon.Text = "Rozłącz";
            this.button_discon.UseVisualStyleBackColor = true;
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 308);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(291, 20);
            this.textBox_message.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Wyślij";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_coded
            // 
            this.richTextBox_coded.Location = new System.Drawing.Point(15, 347);
            this.richTextBox_coded.Name = "richTextBox_coded";
            this.richTextBox_coded.ReadOnly = true;
            this.richTextBox_coded.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_coded.Size = new System.Drawing.Size(372, 148);
            this.richTextBox_coded.TabIndex = 15;
            this.richTextBox_coded.Text = "";
            this.richTextBox_coded.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zakodowana wiadomość:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_coded);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button_discon);
            this.Controls.Add(this.richTextBox_messages);
            this.Controls.Add(this.label_constatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_portrec);
            this.Controls.Add(this.textBox_portsend);
            this.Controls.Add(this.textBox_iprec);
            this.Controls.Add(this.textBox_ipsend);
            this.Name = "Form1";
            this.Text = "Komunikator RS232";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ipsend;
        private System.Windows.Forms.TextBox textBox_iprec;
        private System.Windows.Forms.TextBox textBox_portsend;
        private System.Windows.Forms.TextBox textBox_portrec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_constatus;
        private System.Windows.Forms.RichTextBox richTextBox_messages;
        private System.Windows.Forms.Button button_discon;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_coded;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

