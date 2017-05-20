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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_coded = new System.Windows.Forms.RichTextBox();
            this.richTextBox_receivebuffer = new System.Windows.Forms.RichTextBox();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_receivemessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_send_all = new System.Windows.Forms.Button();
            this.button_send_one = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nadajnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(442, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odbiornik";
            // 
            // richTextBox_coded
            // 
            this.richTextBox_coded.Location = new System.Drawing.Point(15, 291);
            this.richTextBox_coded.Name = "richTextBox_coded";
            this.richTextBox_coded.ReadOnly = true;
            this.richTextBox_coded.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_coded.Size = new System.Drawing.Size(372, 148);
            this.richTextBox_coded.TabIndex = 15;
            this.richTextBox_coded.Text = "";
            this.richTextBox_coded.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox_receivebuffer
            // 
            this.richTextBox_receivebuffer.Location = new System.Drawing.Point(449, 46);
            this.richTextBox_receivebuffer.Name = "richTextBox_receivebuffer";
            this.richTextBox_receivebuffer.ReadOnly = true;
            this.richTextBox_receivebuffer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_receivebuffer.Size = new System.Drawing.Size(372, 200);
            this.richTextBox_receivebuffer.TabIndex = 17;
            this.richTextBox_receivebuffer.Text = "";
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.Location = new System.Drawing.Point(12, 31);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.ReadOnly = true;
            this.richTextBox_messages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_messages.Size = new System.Drawing.Size(372, 215);
            this.richTextBox_messages.TabIndex = 11;
            this.richTextBox_messages.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(12, 252);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(291, 20);
            this.textBox_message.TabIndex = 13;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(309, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Koduj ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zakodowana wiadomość:";
            // 
            // richTextBox_receivemessage
            // 
            this.richTextBox_receivemessage.Location = new System.Drawing.Point(449, 268);
            this.richTextBox_receivemessage.Name = "richTextBox_receivemessage";
            this.richTextBox_receivemessage.ReadOnly = true;
            this.richTextBox_receivemessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_receivemessage.Size = new System.Drawing.Size(372, 172);
            this.richTextBox_receivemessage.TabIndex = 18;
            this.richTextBox_receivemessage.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bufor odczytu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Odczytana wiadomość";
            // 
            // button_send_all
            // 
            this.button_send_all.Enabled = false;
            this.button_send_all.Location = new System.Drawing.Point(274, 445);
            this.button_send_all.Name = "button_send_all";
            this.button_send_all.Size = new System.Drawing.Size(110, 30);
            this.button_send_all.TabIndex = 21;
            this.button_send_all.Text = "Wyślij całość";
            this.button_send_all.UseVisualStyleBackColor = true;
            this.button_send_all.Click += new System.EventHandler(this.button_send_all_Click);
            // 
            // button_send_one
            // 
            this.button_send_one.Enabled = false;
            this.button_send_one.Location = new System.Drawing.Point(158, 445);
            this.button_send_one.Name = "button_send_one";
            this.button_send_one.Size = new System.Drawing.Size(110, 30);
            this.button_send_one.TabIndex = 22;
            this.button_send_one.Text = "Wyślij jeden znak";
            this.button_send_one.UseVisualStyleBackColor = true;
            this.button_send_one.Click += new System.EventHandler(this.button_send_one_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(744, 446);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(77, 29);
            this.button_clear.TabIndex = 23;
            this.button_clear.Text = "Czyść";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_send_one);
            this.Controls.Add(this.button_send_all);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_receivemessage);
            this.Controls.Add(this.richTextBox_receivebuffer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_coded);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.richTextBox_messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Komunikator RS232";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_coded;
        private System.Windows.Forms.RichTextBox richTextBox_receivebuffer;
        private System.Windows.Forms.RichTextBox richTextBox_messages;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_receivemessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_send_all;
        private System.Windows.Forms.Button button_send_one;
        private System.Windows.Forms.Button button_clear;
    }
}

