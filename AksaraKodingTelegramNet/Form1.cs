using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace AksaraKodingTelegramNet
{
    public partial class Form1 : Form
    {
        private static TelegramBotClient Bot;
        public Form1()
        {
            InitializeComponent();
            Bot = new TelegramBotClient(Configuration.BotToken);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainTelegram();
        }

        private async Task MainTelegram()
        {
           
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
           
        }

        private async Task addList(string sender, string date, string message)
        {
           
        }
    }
}
