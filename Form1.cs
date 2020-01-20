using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;
namespace _888_tron
{
   
    public partial class Form1 : Form
    {

        string message_text = null;
        string key = "905583339:AAFuc56TteroTnrcH3I8qPTIPdwDwV9_mQk";
        public static TimeSpan Times;
        DateTime newDate;
        static DateTime date = new DateTime(2019, 10, 30, 15, 0, 0); // год - месяц - день - час - минута - секунда
       
        TimeSpan tron888;
        TimeSpan tron888_good; 
        BackgroundWorker bw;

        int Kryp_win_rus;
        int O_nas_rus;
        int News_rus;
        int Event_rus;
        int Social_rus;
        int Help_rus;


        int Kryp_win_eng;
        int O_nas_eng;
        int News_eng;
        int Event_eng;
        int Social_eng;
        int Help_eng;


        int message_id = 0;

        int id_xlm;
        string button11;
        string button2;
        string button3;
        string button4;
        string button5;
        string button6;
        string button7;
        string button8;

        string button1_eng;
        string button2_eng;
        string button3_eng;
        string button4_eng;
        string button5_eng;
        string button6_eng;
        string button7_eng;
        string button8_eng;
        List<string> button_text = new List<string>();

        class MyTable
        {
            public int id { get; set; } 
        }
        public Form1()
        {
            try
            {

                newDate = date;
                InitializeComponent();
                this.bw = new BackgroundWorker();
                this.bw.DoWork += bw_DoWork;
                timer1.Enabled = true;

                string s1;
                using (var f = new StreamReader("test.txt", Encoding.UTF8))
                {
                    while ((s1 = f.ReadLine()) != null)
                    {
                        button_text.Add(s1);

                    }
                }
                button11 = button_text[0];
                button2 = button_text[1];
                button3 = button_text[2];
                button4 = button_text[3];
                button5 = button_text[4];
                button6 = button_text[5];
                button7 = button_text[6];
                button8 = button_text[7];
                button1_eng = button_text[8];
                button2_eng = button_text[9];
                button3_eng = button_text[10];
                button4_eng = button_text[11];
                button5_eng = button_text[12];
                button6_eng = button_text[13];
                button7_eng = button_text[14];
                button8_eng = button_text[15];

                textBox1.Text = button11;
                textBox2.Text = button2;
                textBox3.Text = button3;
                textBox4.Text = button4;
                textBox5.Text = button5;
                textBox6.Text = button6;
                textBox7.Text = button7;
                textBox8.Text = button8;
                textBox11.Text = button1_eng;
                textBox12.Text = button2_eng;
                textBox13.Text = button3_eng;
                textBox14.Text = button4_eng;
                textBox15.Text = button5_eng;
                textBox16.Text = button6_eng;
                textBox17.Text = button7_eng;
                textBox18.Text = button8_eng;
            }
            catch
            {

            }
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {


            var worker = sender as BackgroundWorker; 
            try
            {


            int admin_id = Convert.ToInt32(admin_textbox.Text);
                var key_bot = "952377344:AAGav52g97Q7WtvXyXxbMkyexx3Aj7WuV7s";
                var Bot = new Telegram.Bot.TelegramBotClient(key_bot); // инициализируем API

                try
                {
                    await Bot.SetWebhookAsync(""); // !!!!!!!!!!!!!!!!!!!!!!ЦИКЛ ПЕРЕЗАПУСКА

                }
                catch
                {
                    await Bot.SetWebhookAsync("");
                }


                // Inlin'ы
                Bot.OnInlineQuery += async (object si, Telegram.Bot.Args.InlineQueryEventArgs ei) =>
                {

                    var query = ei.InlineQuery.Query;


                };



                Bot.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                {

                    var update = evu.Update;
                    var message = update.Message;
                    var id_mess = message.MessageId;
                    var id_chat = message.Chat.Id;
                    // 670031730


                 


                    if (message == null) return;
                    try
                    {




                        string connStr = "server=localhost;user=root;database=tron;password="+ textBox9.Text+ ";";
                        MySqlConnection connection = new MySqlConnection(connStr);
                        connection.Open();

                         
                        //// получение айди поста из базы Русския

                        string Kryp_win_sql = "SELECT `Post_number` FROM `tron`.`post` WHERE(`idPost` = 1)";
                        string O_nas_sql = "SELECT `Post_number` FROM `tron`.`post`  WHERE(`idPost` = 2)";
                        string News_sql = "SELECT `Post_number` FROM `tron`.`post`  WHERE(`idPost` = 3)";
                        string Event_sql = "SELECT `Post_number` FROM `tron`.`post`  WHERE(`idPost` = 4)";
                        string Social_sql = "SELECT `Post_number` FROM `tron`.`post`  WHERE(`idPost` = 5)";
                        string Help_sql = "SELECT `Post_number` FROM `tron`.`post` WHERE(`idPost` = 6)";

                        MySqlCommand Kryp_win_sql_ = new MySqlCommand(Kryp_win_sql, connection);
                        Kryp_win_sql_.ExecuteNonQuery();
                        Kryp_win_rus = Convert.ToInt32(Kryp_win_sql_.ExecuteScalar());

                        MySqlCommand O_nas_sql_ = new MySqlCommand(O_nas_sql, connection);
                        O_nas_sql_.ExecuteNonQuery();
                        O_nas_rus = Convert.ToInt32(O_nas_sql_.ExecuteScalar());

                        MySqlCommand News_sql_ = new MySqlCommand(News_sql, connection);
                        News_sql_.ExecuteNonQuery();
                        News_rus = Convert.ToInt32(News_sql_.ExecuteScalar());

                        MySqlCommand Event_sql_ = new MySqlCommand(Event_sql, connection);
                        Event_sql_.ExecuteNonQuery();
                        Event_rus = Convert.ToInt32(Event_sql_.ExecuteScalar());

                        MySqlCommand Social_sql_ = new MySqlCommand(Social_sql, connection);
                        Social_sql_.ExecuteNonQuery();
                        Social_rus = Convert.ToInt32(Social_sql_.ExecuteScalar());

                        MySqlCommand Help_sql_ = new MySqlCommand(Help_sql, connection);
                        Help_sql_.ExecuteNonQuery();
                        Help_rus = Convert.ToInt32(Help_sql_.ExecuteScalar());

                        /////
                        string Kryp_win_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng` WHERE(`idPost` = 1)";
                        string O_nas_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng`  WHERE(`idPost` = 2)";
                        string News_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng`  WHERE(`idPost` = 3)";
                        string Event_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng`  WHERE(`idPost` = 4)";
                        string Social_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng`  WHERE(`idPost` = 5)";
                        string Help_sql_eng = "SELECT `Post_number` FROM `tron`.`post_eng` WHERE(`idPost` = 6)";

                        MySqlCommand Kryp_win_sql__eng = new MySqlCommand(Kryp_win_sql_eng, connection);
                        Kryp_win_sql__eng.ExecuteNonQuery();
                        Kryp_win_eng = Convert.ToInt32(Kryp_win_sql__eng.ExecuteScalar());

                        MySqlCommand O_nas_sql__eng = new MySqlCommand(O_nas_sql_eng, connection);
                        O_nas_sql__eng.ExecuteNonQuery();
                        O_nas_eng = Convert.ToInt32(O_nas_sql__eng.ExecuteScalar());

                        MySqlCommand News_sql__eng = new MySqlCommand(News_sql_eng, connection);
                        News_sql__eng.ExecuteNonQuery();
                        News_eng = Convert.ToInt32(News_sql__eng.ExecuteScalar());

                        MySqlCommand Event_sql__eng = new MySqlCommand(Event_sql_eng, connection);
                        Event_sql__eng.ExecuteNonQuery();
                        Event_eng = Convert.ToInt32(Event_sql__eng.ExecuteScalar());

                        MySqlCommand Social_sql__eng = new MySqlCommand(Social_sql_eng, connection);
                        Social_sql__eng.ExecuteNonQuery();
                        Social_eng = Convert.ToInt32(Social_sql__eng.ExecuteScalar());

                        MySqlCommand Help_sql__eng = new MySqlCommand(Help_sql_eng, connection);
                        Help_sql__eng.ExecuteNonQuery();
                        Help_eng = Convert.ToInt32(Help_sql__eng.ExecuteScalar());

                        string name = message.Chat.FirstName;
                        // запрос на добавление в базу языка 
                        string language_sql_rus = @"UPDATE `tron`.`telegram`SET`Language` =""RUS"" WHERE (`Chat_id`)=" + message.Chat.Id;
                        string language_sql_eng = @"UPDATE `tron`.`telegram`SET`Language` =""ENG"" WHERE (`Chat_id`)=" + message.Chat.Id;
                        //sql Запрос на ввод данных Id
                        string id_sql = "INSERT INTO `tron`.`telegram`(`Chat_id`)VALUES(" + message.Chat.Id + ")";
                        //проверка наличия записи в бд
                        string id_proverka = "SELECT `Chat_id` FROM `tron`.`telegram` WHERE `Chat_id`=" + message.Chat.Id;
                        //запрос на язык
                        string Language = "SELECT `Language` FROM `tron`.`telegram` WHERE `Chat_id`=" + message.Chat.Id;

                        MySqlCommand Language_sql = new MySqlCommand(Language, connection);
                        Language_sql.ExecuteNonQuery();
                        string s = Convert.ToString(Language_sql.ExecuteScalar());
                        var main = new ReplyKeyboardMarkup();
                        var key_ru = new ReplyKeyboardMarkup();
                        var key_eng = new ReplyKeyboardMarkup();
                        var skip = new ReplyKeyboardMarkup();
                        var admin = new ReplyKeyboardMarkup();
                        var admin_eng = new ReplyKeyboardMarkup();
                        admin.Keyboard =
                               new KeyboardButton[][]
                               {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button11)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2),
            new KeyboardButton(button3),
            new KeyboardButton(button4)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button6),
            new KeyboardButton(button7)
        },

          new KeyboardButton[]
        {
            new KeyboardButton(@"Отправить оповещение")
        }

                               };
                        admin.ResizeKeyboard = true;
                        admin.OneTimeKeyboard = true;

 

                        admin_eng.Keyboard =
                               new KeyboardButton[][]
                               {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button1_eng)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2_eng),
            new KeyboardButton(button3_eng),
            new KeyboardButton(button4_eng)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button6_eng),
            new KeyboardButton(button7_eng)
        },

          new KeyboardButton[]
        {
            new KeyboardButton(@"Send message")
        }


                               };
                        admin_eng.ResizeKeyboard = true;
                        admin_eng.OneTimeKeyboard = true;



                        key_ru.Keyboard =
                                 new KeyboardButton[][]
                                 {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button11)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2),
            new KeyboardButton(button3),
            new KeyboardButton(button4)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button5),
            new KeyboardButton(button6),
            new KeyboardButton(button7)
        },
          new KeyboardButton[]
        {
            new KeyboardButton(button8)

        }
                                 };
                        key_ru.ResizeKeyboard = true;

                       

                            key_eng.Keyboard =
                                  new KeyboardButton[][]
                                  {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button1_eng)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2_eng),
            new KeyboardButton(button3_eng),
            new KeyboardButton(button4_eng)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button5_eng),
            new KeyboardButton(button6_eng),
            new KeyboardButton(button7_eng)
        },
          new KeyboardButton[]
        {
            new KeyboardButton(button8_eng)

        }
                                  };
                        key_eng.ResizeKeyboard = true;


                        if (message.Text == "/start")
                        {
                            //Sql запрос проверка есть ли пользователь в базе.    
                            MySqlCommand command1 = new MySqlCommand(id_proverka, connection);
                            command1.ExecuteNonQuery();
                            if (Convert.ToInt32(command1.ExecuteScalar()) == 0)
                            {
                                MySqlCommand command = new MySqlCommand(id_sql, connection);
                                command.ExecuteNonQuery();
                            }
                            //конец проверки                        
                            var language = new ReplyKeyboardMarkup();
                            language.Keyboard =
                             new KeyboardButton[][]
                             {
        new KeyboardButton[]
        {
            new KeyboardButton("🇷🇺 Russian"),
            new KeyboardButton("🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿 English")
        }
                             };
                            language.ResizeKeyboard = true;
                            language.OneTimeKeyboard = true;
                            await Bot.SendTextMessageAsync(message.Chat.Id, "Hello!", ParseMode.Html, false, true, 0, language);

                        }


                        if (message.From.Id == admin_id)
                            {
                          

                               
                                /*
                                if (message.Text == "/admin")
                                {


                                    ///админка 
                                    //

                                }
                                */
                                var mes = message.From.Id;

                          
                            



                                if (message.Text == "/eng")
                                {

                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Admin", ParseMode.Html, false, true, 0, admin_eng);

                                }
                                if (message.Text == "/rus")
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Админ", ParseMode.Html, false, true, 0, admin);

                                }
                                if (message.Text == button11)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '1')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();

                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);


                                }

                                if (message.Text == button2)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '2')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();

                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);

                                }
                                if (message.Text == button3)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '3')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);

                                }
                                if (message.Text == button4)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '4')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);

                                }
                                if (message.Text == button6)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '5')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);

                                }
                                if (message.Text == button7)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post` SET `Post_number` = '" + da + "' WHERE(`idPost` = '6')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Готово!", ParseMode.Html, false, true, 0, admin);

                                }



                                if (message.Text == button1_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '1')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();

                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);


                                }

                                if (message.Text == button2_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '2')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();

                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);

                                }
                                if (message.Text == button3_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '3')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);

                                }
                                if (message.Text == button4_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '4')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);

                                }
                                if (message.Text == button6_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '5')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);

                                }
                                if (message.Text == button7_eng)
                                {
                                    int da = message_id;
                                    string post = @"UPDATE `tron`.`post_eng` SET `Post_number` = '" + da + "' WHERE(`idPost` = '6')";
                                    MySqlCommand command1 = new MySqlCommand(post, connection);
                                    command1.ExecuteNonQuery();
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Succes!", ParseMode.Html, false, true, 0, admin_eng);

                                }




                                if (message.Text == @"Send message")
                                {
                                    MySqlCommand command = new MySqlCommand("SELECT `Chat_id` FROM `tron`.`telegram`  WHERE(`Language` = 'ENG')", connection);
                                    List<string> id = new List<string>();
                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            id.Add(reader[0].ToString());
                                        }
                                    }
                                    for (int i = 0; id.Count >= 0; i++)
                                    {
                                        await Bot.SendTextMessageAsync(Convert.ToString(id[i]), message_text, ParseMode.Html, false, true, 0, key_eng);
                                    }


                                }
                                if (message.Text == @"Отправить оповещение")
                                {
                                    MySqlCommand command = new MySqlCommand("SELECT `Chat_id` FROM `tron`.`telegram` WHERE(`Language` = 'RUS')", connection);
                                    List<string> id = new List<string>();
                                    using (MySqlDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            id.Add(reader[0].ToString());
                                        }
                                    }
                                    for (int i = 0; id.Count >= 0; i++)
                                    {
                                        await Bot.SendTextMessageAsync(Convert.ToString(id[i]), message_text, ParseMode.Html, false, true, 0, key_ru);
                                    }


                                }
                            message_text = message.Text;
                            if (message.From.IsBot == true || message.IsForwarded == true || message.ForwardFrom.IsBot == true)
                            {
                                message_id = message.MessageId;

                            }

                          

                          

                        }
                        
                            if (message.Text == "🇷🇺 Russian")
                            {
                            skip.Keyboard =
                  new KeyboardButton[][]
                  {
        new KeyboardButton[]
        {
            new KeyboardButton("Пропустить")
        }
                  };
                            skip.ResizeKeyboard = true;
                            skip.OneTimeKeyboard = true;
                            await Bot.SendTextMessageAsync(message.Chat.Id, "Привет, чтобы продолжить тебе нужно ввести свой TRON (TRX) кошелек.", ParseMode.Html, false, true, 0, skip);
                                MySqlCommand command = new MySqlCommand(language_sql_rus, connection);
                                command.ExecuteNonQuery();
                            }
                            if (message.Text == "🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿 English")
                            {
                            skip.Keyboard =
                   new KeyboardButton[][]
                   {
        new KeyboardButton[]
        {
            new KeyboardButton("Skip")
        }
                   }; skip.ResizeKeyboard = true;
                            skip.OneTimeKeyboard = true;
                            await Bot.SendTextMessageAsync(message.Chat.Id, "Hello, send me your TRON (TRX) wallet.", ParseMode.Html, false, true, 0, skip);
                                MySqlCommand command = new MySqlCommand(language_sql_eng, connection);
                                command.ExecuteNonQuery();
                            }
                       



                        if (s == "RUS")
                            {
                                 

                                main.Keyboard =
                                 new KeyboardButton[][]
                                 {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button11)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2),
            new KeyboardButton(button3),
            new KeyboardButton(button4)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button5),
            new KeyboardButton(button6),
            new KeyboardButton(button7)
        },
          new KeyboardButton[]
        {
            new KeyboardButton(button8)

        }
                                 };
                                main.ResizeKeyboard = true;
                            }
                            else
                            {
                                skip.Keyboard =
                         new KeyboardButton[][]
                         {
        new KeyboardButton[]
        {
            new KeyboardButton("Skip")
        }
                         };

                                main.Keyboard =
                                  new KeyboardButton[][]
                                  {
                                   new KeyboardButton[]
        {
            new KeyboardButton(button1_eng)

        },
        new KeyboardButton[]
        {
            new KeyboardButton(button2_eng),
            new KeyboardButton(button3_eng),
            new KeyboardButton(button4_eng)

        },
          new KeyboardButton[]
        {
            new KeyboardButton(button5_eng),
            new KeyboardButton(button6_eng),
            new KeyboardButton(button7_eng)
        },
          new KeyboardButton[]
        {
            new KeyboardButton(button8_eng)

        }
                                  };
                                main.ResizeKeyboard = true;

                            }
                            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text & message.From.Id!= admin_id)
                            {
                                string patertn = @"T+\w{33}";


                                foreach (Match match in Regex.Matches(message.Text, patertn))
                                {
                                    //запрос языка

                                    if (s == "RUS")
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Адресс добавлен в БД", ParseMode.Html, false, true, 0, main);
                                    }
                                    else
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Success", ParseMode.Html, false, true, 0, main);
                                    }



                                    string da = message.Text;

                                    //Добавление trx кошелька
                                    string Wallet = @"UPDATE `tron`.`telegram` SET `Wallet` = '" + da + "' WHERE(`Chat_id` = '" + message.Chat.Id + "')";

                                    MySqlCommand command = new MySqlCommand(Wallet, connection);
                                    command.ExecuteNonQuery();
                                }

                                if (message.Text == @"Пропустить")
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать в бота 888TRON!", ParseMode.Html, false, true, 0, main);
                                }
                                if (message.Text == @"Skip")
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Welcome to the 888TRON bot!", ParseMode.Html, false, true, 0, main);
                                }

                               



                            //// eng
                            ///
                            if (message.Text == button1_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Kryp_win_eng);
                            }
                            if (message.Text == button2_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, O_nas_eng);
                            }

                            if (message.Text == button3_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, News_eng);
                            }
                            if (message.Text == button4_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Event_eng);
                            }

                            if (message.Text == button6_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Social_eng);

                            }
                            if (message.Text == button7_eng)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Help_eng);
                            }

                           

                            if (message.Text == button11)
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Kryp_win_rus);
                            }
                            if (message.Text == button2 )
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, O_nas_rus);
                            }

                            if (message.Text == button3 )
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, News_rus);
                            }
                            if (message.Text == button4 )
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Event_rus);
                            }

                            if (message.Text == button6 )
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Social_rus);

                            }
                            if (message.Text == button7 )
                            {

                                await Bot.ForwardMessageAsync(message.Chat.Id, admin_id, Help_rus);
                            }

                            if (message.Text == button8)
                                {
                                string lastPrice;
                                string  _24change;
                                string high;
                                string full;
                                string low;
                                string volume;

                                string json = @"{""operationName"":null,""variables"":{},""query"":""{\n exchange(id: 12) {\n stats {\n lastPrice\n h24_change\n high\n low\n volume\n    }\n  }\n}\n""}";

                                var httpRequest = (HttpWebRequest)WebRequest.Create("https://trontrade.io/graphql");
                                httpRequest.Method = "POST";
                                httpRequest.ContentType = "application/json; charset=utf-8";
                                using (var requestStream = httpRequest.GetRequestStream())
                                using (var writer = new StreamWriter(requestStream))
                                {
                                    writer.Write(json);
                                }
                                using (var httpResponse = httpRequest.GetResponse())
                                using (var responseStream = httpResponse.GetResponseStream())
                                using (var reader = new StreamReader(responseStream))
                                {
                                    
                                    string response = reader.ReadToEnd();
                                    full = response;
                                }
                                MatchCollection matchList = Regex.Matches(full, @"([0-9])+?(.[0-9]+)");
                                var list = matchList.Cast<Match>().Select(match => match.Value).ToList();
                                

                              
                                lastPrice =Convert.ToString( Convert.ToDouble(list[0]) / 1000000); 
                                _24change = Convert.ToString(list[1]); 
                                high =  Convert.ToString(Convert.ToDouble(list[2]) / 1000000); 
                                low = Convert.ToString(Convert.ToDouble(list[3]) / 1000000); 
                                volume = Convert.ToString(Convert.ToDouble(list[4]) / 1000000);

                                volume = volume.Substring(0, volume.Length - 4);
                                volume = Convert.ToString(volume);

                                WebRequest send = WebRequest.Create("https://888tron.com/api1/getDividends");
                                    send.Method = "POST";

                                    string divedent_bad;
                                    using (WebResponse result = send.GetResponse())
                                    {
                                        StreamReader reader = new StreamReader(result.GetResponseStream());
                                        divedent_bad = reader.ReadToEnd();
                                    }
                                    string divedent = System.Text.RegularExpressions.Regex.Match(divedent_bad, @"(-)?[0-9]+").Groups[0].Value;

                                    divedent = divedent.Substring(0, divedent.Length - 6 );
                                    double divedent_good = Convert.ToDouble(divedent);
                                    divedent = divedent_good.ToString("#,#", CultureInfo.InvariantCulture);

                                    // tron888 =date - DateTime.Now;
                                    //string time = Convert.ToString(date.Hour + ":" + tron888.Minutes + ":" + tron888.Seconds);
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Доступные Дивиденды: " + divedent + " TRX" + "\nВыплата через: "+Times.Days+":" + Times.Hours + ":" + Times.Minutes + ":" + Times.Seconds+ "\nPrice: "+lastPrice+ " TRX ("+ _24change + "%)" + "\n24H High: "+high+ " TRX" + "\n24H Low: "+low+ " TRX" + "\n24H Volume: " + volume+ " 888", ParseMode.Html, false, true, 0, main);
                                }

                                if (message.Text == button8_eng)
                                {
                                string lastPrice;
                                string _24change;
                                string high;
                                string full;
                                string low;
                                string volume;

                                string json = @"{""operationName"":null,""variables"":{},""query"":""{\n exchange(id: 12) {\n stats {\n lastPrice\n h24_change\n high\n low\n volume\n    }\n  }\n}\n""}";

                                var httpRequest = (HttpWebRequest)WebRequest.Create("https://trontrade.io/graphql");
                                httpRequest.Method = "POST";
                                httpRequest.ContentType = "application/json; charset=utf-8";
                                using (var requestStream = httpRequest.GetRequestStream())
                                using (var writer = new StreamWriter(requestStream))
                                {
                                    writer.Write(json);
                                }
                                using (var httpResponse = httpRequest.GetResponse())
                                using (var responseStream = httpResponse.GetResponseStream())
                                using (var reader = new StreamReader(responseStream))
                                {

                                    string response = reader.ReadToEnd();
                                    full = response;
                                }
                                MatchCollection matchList = Regex.Matches(full, @"([0-9])+?(.[0-9]+)");
                                var list = matchList.Cast<Match>().Select(match => match.Value).ToList();
                                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");


                                lastPrice = (Convert.ToDouble(list[0]) / 1000000).ToString(); 
                                _24change = list[1];
                                high = ((Convert.ToDouble(list[2]) / 1000000)).ToString();
                                low = ((Convert.ToDouble(list[3]) / 1000000)).ToString();
                                volume = ((Convert.ToDouble(list[4]) / 1000000)).ToString();

                                volume = volume.Substring(0, volume.Length - 4);

                                WebRequest send = WebRequest.Create("https://888tron.com/api1/getDividends");
                                    send.Method = "POST";

                                    string divedent_bad;
                                    using (WebResponse result = send.GetResponse())
                                    {
                                        StreamReader reader = new StreamReader(result.GetResponseStream());
                                        divedent_bad = reader.ReadToEnd();
                                    }
                                    string divedent = System.Text.RegularExpressions.Regex.Match(divedent_bad, @"(-)?[0-9]+").Groups[0].Value;

                                    divedent = divedent.Substring(0, divedent.Length - 6);
                                    double divedent_good = Convert.ToDouble(divedent);
                                string divedent222 = divedent_good.ToString("#,#", CultureInfo.InvariantCulture);

                                
                                    // tron888 =date - DateTime.Now;
                                    //string time = Convert.ToString(date.Hour + ":" + tron888.Minutes + ":" + tron888.Seconds);
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Available Dividends: " + divedent222 + " TRX" + "\nDividends Countdown: " + Times.Days + ":" + Times.Hours + ":" + Times.Minutes + ":" + Times.Seconds +"\nPrice: " + lastPrice + " TRX (" + _24change + "%)" + "\n24H High: " + high + " TRX" + "\n24H Low: " + low + " TRX" + "\n24H Volume: " + volume + " 888", ParseMode.Html, false, true, 0, main);
                                }

                            if (message.Text == button5_eng)
                            {
                                var button = new InlineKeyboardButton { Url = "https://t.me/tron888 ", Text = "🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿 English chat" };
                                var markup = new InlineKeyboardMarkup(button);
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Press the button 👇", replyMarkup: markup);
                            }
                            if (message.Text == button5)
                            {
                                var button = new InlineKeyboardButton { Url = "https://t.me/Tron888rus", Text = "🇷🇺 Русский чат" };
                                var markup = new InlineKeyboardMarkup(button);
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Нажмите на кнопку 👇", replyMarkup: markup);
                            }




                        }
                          


                        


                        

                    }
                    catch
                    {

                    }
                 

                    };

                Bot.StartReceiving();

                // запускаем прием обновлений

            }

            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }

        }
         
      
        private void BtnRun_Click(object sender, EventArgs e)
        {
            var text = @txtKey.Text; // получаем содержимое текстового поля txtKey в переменную text
            if (text != "" && this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(key); // передаем эту переменную в виде аргумента методу bw_DoWork
                BtnRun.Text = "Бот запущен...";
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1 = TimeSpan.FromHours(48);
            Times = newDate - DateTime.Now; 
            if (Convert.ToInt64(Times.TotalSeconds)< 1)
            {
              newDate = newDate.AddHours(48);


            }


      
        }

        public   void button1_Click(object sender, EventArgs e)
        {
            
                using (StreamWriter w = new StreamWriter("test.txt",false, Encoding.UTF8))
                {
                    w.WriteLine(textBox1.Text);
                    w.WriteLine(textBox2.Text);
                    w.WriteLine(textBox3.Text);
                    w.WriteLine(textBox4.Text);
                    w.WriteLine(textBox5.Text);
                    w.WriteLine(textBox6.Text);
                    w.WriteLine(textBox7.Text);
                    w.WriteLine(textBox8.Text);
                    w.WriteLine(textBox11.Text);
                    w.WriteLine(textBox12.Text);
                    w.WriteLine(textBox13.Text);
                    w.WriteLine(textBox14.Text);
                    w.WriteLine(textBox15.Text);
                    w.WriteLine(textBox16.Text);
                    w.WriteLine(textBox17.Text);
                    w.WriteLine(textBox18.Text);
                }
                 


        }

        private void button9_Click(object sender, EventArgs e)
        {
         

            button11 = button_text[0];
            button2 = button_text[1];
            button3 = button_text[2];
            button4 = button_text[3];
            button5 = button_text[4];
            button6 = button_text[5];
            button7 = button_text[6];
            button8 = button_text[7];
            button1_eng = button_text[8];
            button2_eng = button_text[9];
            button3_eng = button_text[10];
            button4_eng = button_text[11];
            button5_eng = button_text[12];
            button6_eng = button_text[13];
            button7_eng = button_text[14];
            button8_eng = button_text[15];

            textBox1.Text = button11;
            textBox2.Text = button2;
            textBox3.Text = button3;
            textBox4.Text = button4;
            textBox5.Text = button5;
            textBox6.Text = button6;
            textBox7.Text = button7;
            textBox8.Text = button8;
            textBox11.Text = button1_eng;
            textBox12.Text = button2_eng;
            textBox13.Text = button3_eng;
            textBox14.Text = button4_eng;
            textBox15.Text = button5_eng;
            textBox16.Text = button6_eng;
            textBox17.Text = button7_eng;
            textBox18.Text = button8_eng;
        }
    }
}

