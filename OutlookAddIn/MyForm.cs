using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookAddIn
{
    public partial class MyForm : Form
    {
        protected Outlook.Application App;

        public MyForm(Outlook.Application _app)
        {
            App = _app;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lineInfo = new List<string>();
            string[] words = messageTextBox.Text.Split(new char[0]);
            int j = 1;

            StringBuilder line = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (j++ % 8 == 0)
                {
                    lineInfo.Add(line.ToString());
                    line = new StringBuilder(words[i] + " ");
                }
                else
                {
                    line.Append(words[i] + " ");
                }
            }

            if (!string.IsNullOrWhiteSpace(line.ToString()))
                lineInfo.Add(line.ToString());

            SendMessage(App, lineInfo, messageTextBox.Text, mailTextBox.Text, subjectTextBox.Text, nameTextBox.Text);
        }

        private void SendMessage(Outlook.Application oApp, List<string> bodyMessage, string stringBodyMessage, string receiver, string subject, string to)
        {
            try
            {
                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                oMsg.HTMLBody = stringBodyMessage;
                String sDisplayName = "MyAttachment";
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;

                if ((int)oMsg.Body.Length > 0 && !string.IsNullOrEmpty(to))
                {
                    PrepareMessage(bodyMessage, to);
                }

                ClearFieldsAndClose();

                string thePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture.png");
                Outlook.Attachment oAttach = oMsg.Attachments.Add(thePath, iAttachType, iPosition, sDisplayName);

                oMsg.Subject = subject;
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(receiver);
                oRecip.Resolve();
                oMsg.Send();
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;

            }//end of try block
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }//end of catch
        }

        private void ClearFieldsAndClose()
        {
            messageTextBox.Text = string.Empty;
            mailTextBox.Text = string.Empty;
            subjectTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            this.Close();
            //sleep to make sure the e-mail is sent after the picture has been saved
            Thread.Sleep(3000);
        }

        //This is the step that will get the image, and write the content of the message within it
        private void PrepareMessage(List<string> body, string to)
        {
            PointF location = new PointF(30f, 30f);

            string imageFilePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture.png");
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Comic Sans", 30))
                {
                    if (!string.IsNullOrWhiteSpace(to))
                    {
                        graphics.DrawString(to + ",", arialFont, Brushes.CornflowerBlue, location);
                        location.Y += 30;
                    }

                    foreach (string line in body)
                    {
                        graphics.DrawString(line, arialFont, Brushes.CornflowerBlue, location);
                        location.Y += 30;
                    }
                }
            }

            imageFilePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "picture.png");
            bitmap.Save(imageFilePath);//save the image file
        }
    }
}
