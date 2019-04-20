using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace PassPrintDesktop
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.Select();
        }

        private void btnAddCred_Click(object sender, EventArgs e)
        {
            new FormAddCred().Show();
        }

        private void btnEditDelCred_Click(object sender, EventArgs e)
        {
            using (Place_Finger form = new Place_Finger())
            {
                Place_Finger.fingerOK = false;
                form.ShowDialog();
            }
            if (Place_Finger.fingerOK)
            { new FormEditDelCred().Show(); }
        }

        private void btnConnectBT_Click(object sender, EventArgs e)
        { // Click this button to connect to Bluetooth
            Variables.serialBluetooth.Open();
            lblConnectSuccess.Text = "✓";
            //btnConnectBT
        }

        private void btnAddFP_Click(object sender, EventArgs e)
        {
            using (Place_Finger form = new Place_Finger())
            {
                Place_Finger.fingerOK = false;
                form.ShowDialog();
            }
            if (Place_Finger.fingerOK) { new AddFP().Show(); }
        }

        private void Btn_Authenticate_Click(object sender, EventArgs e)
        {
            new Place_Finger().Show();
        }

        private void btnRemoveFP_Click(object sender, EventArgs e)
        {
            using (Place_Finger form = new Place_Finger())
            {
                Place_Finger.fingerOK = false;
                form.ShowDialog();
            }
        }
        
        HttpListener listener = null;
        private int runServer() // Code that runs server
        {
            try
            {
                listener = new HttpListener();
                listener.Prefixes.Add("http://localhost:4000/");
                listener.Start();
                while (true)
                {
                    Console.WriteLine("Waiting for connection...");
                    HttpListenerContext context = listener.GetContext();
                    //string siteName = context.ToString();
                    //Console.WriteLine(siteName);
                    string body = new StreamReader(context.Request.InputStream).ReadToEnd();
                    dynamic request = JsonConvert.DeserializeObject(body);
                    string website = request.website;
                    Console.WriteLine("BODY: " + website);

                    // Send website name to Arduino and get correct creds back
                    Variables.serialBluetooth.Write("Get One Credential%");
                    Variables.serialBluetooth.Write(website + ":");
                    // Read response from Arduino with creds
                    String siteName = Variables.serialBluetooth.ReadLine();
                    String userName = Variables.serialBluetooth.ReadLine();
                    String pwd = Variables.serialBluetooth.ReadLine();

                    Console.Write("Username: " + userName);
                    Console.Write("Password: " + pwd);

                    // Generate response to client
                    //string msg = "Hello from C# Server! Hi browser";
                    string[] creds = new string[2] { userName, pwd };
                    string msg = JsonConvert.SerializeObject(creds);
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
                    HttpListenerResponse response = context.Response;
                    response.ContentLength64 = buffer.Length;
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Headers.Add("Access-Control-Allow-Origin", "*");
                    response.Headers.Add("Access-Control-Allow-Methods", "POST, GET");
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    Console.WriteLine("Done with code block");
                }
            }
            catch (Exception) { return 0; }
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            // Run server asynchronously
            Task<int> task = new Task<int>(runServer);
            task.Start();
            await task;

        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            listener.Close();
        }
    }
}
