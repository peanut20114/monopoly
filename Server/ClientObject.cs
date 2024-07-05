using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Server
{
    public class ClientObject
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient FBclient;
        private readonly TcpClient Client;
        private readonly ServerObject server;
        private string userName;
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            Client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }
        protected internal string Id { get; }
        protected internal NetworkStream Stream { get; private set; }
        public async void Process()
        {
            try
            {
                Stream = Client.GetStream();
                while (true)
                {
                    var message = GetMessage();
                    switch (message)
                    {
                        case "Both players has connected":
                            {
                                server.SendMessageToEveryone(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Someone has connected":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                if (Taken.Red) server.SendMessageToSender("Red pawn is already selected", Id);
                                if (Taken.Blue) server.SendMessageToSender("Blue pawn is already selected", Id);
                                break;
                            }
                        case "Red pawn is already selected":
                            {
                                server.SendMessageToOpponentClient(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Blue pawn is already selected":
                            {
                                server.SendMessageToOpponentClient(message, Id);
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                break;
                            }
                        case "Red has left" when userName is "Red":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                server.RemoveConnection(this.Id);
                                break;
                            }
                        case "Blue has left" when userName is "Blue":
                            {
                                Program.f.tbLog.Invoke((MethodInvoker)delegate
                                {
                                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                                });
                                server.RemoveConnection(this.Id);
                                break;
                            }
                    }
                    if (message.Contains("-Red"))
                    {
                        Taken.Red = true;
                        // Update user id Red Pawn
                        FBclient = new FireSharp.FirebaseClient(config);
                        FirebaseResponse res = await FBclient.GetAsync("SESSION/" + Program.sessionID);
                        Session data = res.ResultAs<Session>();
                        data.redPawn = message.Split('-')[0];
                        // Update the data in Firebase
                        SetResponse updateResponse = await FBclient.SetAsync("SESSION/" + Program.sessionID, data);
                        Session updatedData = updateResponse.ResultAs<Session>();
                        // End updated
                        userName = message.Split('-')[1];
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + userName + " has connected" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(userName + " has connected", Id);
                    }
                    else if (message.Contains("-Blue"))
                    {
                        Taken.Blue = true;
                        // Update user id Blue Pawn
                        FBclient = new FireSharp.FirebaseClient(config);
                        FirebaseResponse res = await FBclient.GetAsync("SESSION/" + Program.sessionID);
                        Session data = res.ResultAs<Session>();
                        data.bluePawn = message.Split('-')[0];
                        // Update the data in Firebase
                        SetResponse updateResponse = await FBclient.SetAsync("SESSION/" + Program.sessionID, data);
                        Session updatedData = updateResponse.ResultAs<Session>();
                        // End updated
                        userName = message.Split('-')[1];
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + userName + " has connected" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(userName + " has connected", Id);
                    }
                    if (message.Contains("Red player's turn results"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Red player has finished his turn" + Environment.NewLine;
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Blue player's turn" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                    if (message.Contains("Blue player's turn results"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Blue player has finished his turn" + Environment.NewLine;
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + "Red player's turn" + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                    if (message.Contains("Rent"))
                    {
                        Program.f.tbLog.Invoke((MethodInvoker)delegate
                        {
                            Program.f.tbLog.Text += "[" + DateTime.Now + "] " + message + Environment.NewLine;
                        });
                        server.SendMessageToOpponentClient(message, Id);
                    }
                }
            }
            catch (Exception e)
            {
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " + e.Message + Environment.NewLine;
                });
            }
        }
        private string GetMessage()
        {
            var data = new byte[256];
            var builder = new StringBuilder();
            do
            {
                builder.Append(Encoding.Unicode.GetString(data, 0,
                    Stream.Read(data, 0, data.Length)));
            } while (Stream.DataAvailable);
            return builder.ToString();
        }
        protected internal void Close()
        {
            Stream.Close();
            Client.Close();
        }
    }
}



