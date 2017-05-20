using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikator
{
    public partial class Form1 : Form
    {
        private MessageRS message_coder = new MessageRS();
        private MessageRS message_receiver = new MessageRS(); //odbiornik
        private Cenzor cenzura = new Cenzor();

        string send_buffer; //bufor przesylu miedzy nadajnikiem i odbiornikiem

        int aktualny_znak = 0; //licznik znaku przy przesylaniu pojedynczym

        public Form1()
        {
            InitializeComponent();
            send_buffer = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //koduj
            string po_cenzurze = cenzura.SprawdzTekst(textBox_message.Text);
            message_coder.SetMessage(po_cenzurze);
            message_coder.EncodeMessage();  //wiadomosc z pola tekstowego jest kodowana i wyswietlana w richtextbox 
            richTextBox_coded.Clear();
            richTextBox_coded.Text = message_coder.GetEncodedMessage();

            richTextBox_messages.AppendText("<"+DateTime.Now+"> "+ po_cenzurze + "\n");
            button_send_all.Enabled = true;
            button_send_one.Enabled = true;
            aktualny_znak = 0;
        }

        private void button_send_all_Click(object sender, EventArgs e) //przesylanie wszystkich znaków
        {
            send_buffer = message_coder.GetEncodedMessage();
            message_receiver.ReceiveMessage(send_buffer); //odbieramy z bufora
            richTextBox_receivebuffer.Text = message_receiver.GetEncodedMessage();
            message_receiver.DecodeMessage(); //dekodujemy
            richTextBox_receivemessage.Text = message_receiver.GetMessage();


        }

        private void button_clear_Click(object sender, EventArgs e) //czyscimy
        {
            message_receiver.SetMessage("");
            message_receiver.EncodeMessage(); 
            richTextBox_receivebuffer.Clear();
            richTextBox_receivemessage.Clear();
            send_buffer = "";
        }

        private void button_send_one_Click(object sender, EventArgs e)
        {
            if (aktualny_znak < message_coder.CountEncodedChars())
            {
                send_buffer = message_coder.GetEncodedChar(aktualny_znak);
                message_receiver.ReceiveMessage(send_buffer); //odbieramy z bufora
                richTextBox_receivebuffer.Text = message_receiver.GetEncodedMessage();
                message_receiver.DecodeMessage(); //dekodujemy
                richTextBox_receivemessage.Text = message_receiver.GetMessage();
                aktualny_znak++;
            }
        }

        private void textBox_message_TextChanged(object sender, EventArgs e)
        {
            if(textBox_message.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
