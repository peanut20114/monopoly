using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Server
{
    public class ServerObject
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient FBclient;
        private static TcpListener tcpListener;
        private readonly List<ClientObject> clients = new List<ClientObject>();
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(string id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null) clients.Remove(client);
        }
        public static string GenerateRandomNumber()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                stringBuilder.Append(random.Next(1, 10));
            }

            return stringBuilder.ToString();
        }
        protected internal async void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] "
                                            + "Waiting for players..."
                                            + Environment.NewLine;
                });

                //Create SESSION
                FBclient = new FireSharp.FirebaseClient(config);
                var data = new Session
                {
                    winner = -1,
                    redPawn = "",
                    bluePawn = "",
                    start_at = DateTime.Now,
                    end_at = DateTime.Now
                };
                string ID = GenerateRandomNumber();
                Program.sessionID = ID;
                SetResponse res = await FBclient.SetAsync("SESSION/" + ID, data);
                Session result = res.ResultAs<Session>();
                SendMessageToEveryone(ID, "");
                //End created

                while (true)
                {
                    var tcpClient = tcpListener.AcceptTcpClient();
                    var clientObject = new ClientObject(tcpClient, this);
                    var clientThread = new Thread(clientObject.Process);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Program.f.tbLog.Invoke((MethodInvoker)delegate
                {
                    Program.f.tbLog.Text += "[" + DateTime.Now + "] " +
                                            ex.Message +
                                            Environment.NewLine;
                });
                CloseAndExit();
            }
        }
        protected internal void SendMessageToOpponentClient(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id != id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0,
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void SendMessageToSender(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id == id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0,
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void SendMessageToEveryone(string message, string id)
        {
            foreach (var t in clients.Where(t => t.Id != id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0,
                    Encoding.Unicode.GetBytes(message).Length);
            foreach (var t in clients.Where(t => t.Id == id))
                t.Stream.Write(Encoding.Unicode.GetBytes(message), 0,
                    Encoding.Unicode.GetBytes(message).Length);
        }
        protected internal void CloseAndExit()
        {
            tcpListener?.Stop();
            foreach (var t in clients) t.Close();
            Environment.Exit(0);
        }
    }
}