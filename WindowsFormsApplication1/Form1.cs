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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            
        }
        
        private void input_TextChanged(object sender, EventArgs e)
        {
            output.Text = "";
            Encryption.Text = "";
            
        }

        private void key_TextChanged(object sender, EventArgs e)
        {
           
          if (key.Text.Length >= 21)
            {
               
                MessageBox.Show("Key Upto Only 21 Characters","Error");
                key.Text = key.Text.Substring(0, key.Text.Length - 1);
                
            }
            
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(input.Text.ToString());
            int num=0;
            output.Text = "";
            if (key.Text == "")
            {
                MessageBox.Show("key Field Empty", "Error");
                key.Text = "0";
            }
            
            foreach (byte b in asciiBytes)
            {
                
                num++;
              if (b >= 65 && b <= 90 || b >= 97 && b <= 122 || b >= 48 && b <= 57)
                {
                   encryptalgo(b,num);
                }
               else
                {
                    if (((char)b).ToString() == " ")
                    {
                        output.Text += ((char)b).ToString();
                        num--;
                    }
                    else if (b == 13 || b == 10)
                    {
                        output.Text += ((char)b).ToString();
                        num = 0;
                    }
                    else
                    {
                        MessageBox.Show("Symbol: " + ((char)b).ToString() + " Will Not Get Encrypted", "Error");
                        output.Text += ((char)b).ToString();
                    }
                }
                
            }
            
            
        }



      public  void encryptalgo(byte x,int num)
        {
        int counter = keygen(num);
        while (counter!=0)
                {
                    x += 1;
                    counter = counter-1;
                    if (x>90 && x<97)
                    {
                        x = byte.Parse("97");
                        
                    }
                   else if (x > 57 && x < 65)
                    {
                        x = byte.Parse("65");

                    }
                   
                    else if (x>122)
                    {
                        x = byte.Parse("48");
                    }
                    }
             output.Text += ((char) x).ToString();
             
            Encryption.Text = "Encrypted";
        }

      public void decryptalgo(byte x,int num)
      {
          int counter = keygen(num) ;
          while (counter!=0)
              {
                  x -= 1;
                  counter = counter - 1;
                  if (x < 97 && x>90)
                  {
                      x = byte.Parse("90");
                  }
                  else if (x > 57 && x < 65)
                  {
                      x = byte.Parse("57");

                  }
                  
                  else if (x < 48)
                  {

                      x = byte.Parse("122");
                  }

              }
           output.Text += ((char)x).ToString();
           Encryption.Text = "Decrypted";
      }

      private void decrypt_Click(object sender, EventArgs e)
      {
          byte[] asciiBytes = Encoding.ASCII.GetBytes(input.Text.ToString());
          int num = 0;
          output.Text = "";
          if (key.Text == "")
          {
              MessageBox.Show("Key Field Empty", "Error");
              key.Text = "0";
          }
          
          foreach (byte b in asciiBytes)
          {
              num++;
              if (b >= 65 && b <= 90 || b >= 97 && b <= 122 || b >= 48 && b <= 57)
              {
                  decryptalgo(b,num);
              }
             else
              {
                  if (((char)b).ToString() == " ")
                  {

                      output.Text += ((char)b).ToString();
                      num--;
                  }
                  else if (b == 13 || b == 10)
                  {
                      output.Text += ((char)b).ToString();
                      num = 0;
                  }
                  else
                  {
                      MessageBox.Show("Symbol: " + ((char)b).ToString() + " Will Not Get Encrypted", "Error");
                      output.Text += ((char)b).ToString();
                  }
              }
          }
          

      }

      private void copy_Click(object sender, EventArgs e)
      {
          if (output.Text != "")
          {
              Clipboard.SetText(output.Text.ToString());
          }
      }

      private void clear_Click(object sender, EventArgs e)
      {
          input.Text = "";
          output.Text = "";
          key.Text = "";

      }

      private void about_Click(object sender, EventArgs e)
      {
          MessageBox.Show("ZEncryptor is a Text Encryptor Application\nWhich Encrypts Confidential Text With A Encryption Key, The Encrypted Text Can be Stored In Any Storage Medium Without Fearing of Theft.\nNote: Donot Reveal or Forget Your Key.\nApplication Developed By: Zoeb Chhatriwala", "About");
      }
      private int keygen(int num)
      {
          string keyValue = key.Text.ToString();
          if (num > keyValue.Length)
          {
              num = num % keyValue.Length;
              if (num == 0)
              {
                  num = keyValue.Length;
              }
          }
          int  keyone=check(keyValue[num-1]);
          int keytwo = keyone % keyValue.Length;
          if (keytwo==0)
          {
              keytwo = keyValue.Length;
          }
          keytwo = check(keyValue[keytwo-1]);
          if (keyone <=9 && keytwo <=9)
          {
              keyone = keyone * 10;
              keyone = keyone + keytwo;
          }
          else
          {
              keyone = keyone + keytwo;
          }
          return (keyone);
      }
      private int check(int ch)
      {
          if (ch >= 48 && ch <= 57)
          {
              ch = ch % 48;
              return ch;
          }
          else
          {
              return ch;
          }
      }

    }
}
