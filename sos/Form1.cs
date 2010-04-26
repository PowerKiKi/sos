using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace SOS
{
   public partial class Form1 : Form
   {
      SOS.Properties.Settings settings = new SOS.Properties.Settings();
      Orange orange = new Orange();
      AddressBook addressBook;
      public Form1()
      {
         this.addressBook = new AddressBook(this.settings.addressBook);
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this.txtMessage_TextChanged(null, null);
         this.txtMessage.MaxLength = Orange.userMessageMaxLength;

         foreach (Person p in this.addressBook.List)
            this.txtNumbers.AutoCompleteCustomSource.Add(p.Number);

         this.txtMessage.Focus();
      }

      private void button1_Click(object sender, EventArgs e)
      {

         this.button1.Enabled = false;
         //this.button1.Text = "login...";
         this.toolStripStatusLabel1.Text = "login...";
         this.button1.Refresh();
         this.statusStrip1.Refresh();
         this.orange.login(this.settings.login, this.settings.password);
         //this.button1.Text = "sending...";
         this.toolStripStatusLabel1.Text = "sending...";
         this.button1.Refresh();
         this.statusStrip1.Refresh();
         this.orange.send(this.txtNumbers.Text, this.txtMessage.Text, "");
         this.button1.Enabled = true;
         this.button1.Text = "Send";


         string page = this.orange.LastResult;
         string message;
         Regex regSuccess = new Regex("<span.*successOutput.*>(.*)<", RegexOptions.IgnoreCase);
         Regex regError = new Regex("<span.*errorOutput.*>(.*)<", RegexOptions.IgnoreCase);
         Match m;
         if (regSuccess.IsMatch(page))
            message = "sent succesfully"; //m = regSuccess.Match(page);
         else
            message = "FAILED !"; // m = regError.Match(page);
         //string t = m.Groups[1].Value.Trim();
         this.toolStripStatusLabel1.Text = message;
         this.txtMessage.Focus();

         System.IO.StreamWriter writer = new System.IO.StreamWriter(Program.dumpFile);
         writer.WriteLine(page);
         writer.Close();
      }

      private void txtMessage_TextChanged(object sender, EventArgs e)
      {
         this.toolStripStatusLabel1.Text = (this.txtMessage.MaxLength - this.txtMessage.Text.Length) + " chars left";
      }
   }
}