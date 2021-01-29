

در این برنامه چهار دکمه ایجاد می کنیم
بعدش هر چهارتا رو باهم انتخاب می کنیم
اون رو به یک رویداد متصل می کنیم
بعد در اون نام دکمه ای که اون رو اجرا کرده قرار میدیم
با زدن هر کدوم میخوایم نام دکمه رو هم اعلام بکنه
بخاطر همین اون رو از طریق Sender بهش پاس میدیم


این تمرین بسیار عالیه برای کار کردن با 
this
sender
و اینکه چه کارهایی با هر کدام از 
control
ها میشه انجام داد

نمونه این کد اینه


private void HelloFunction(object sender, EventArgs e)
        {
            string ObjectName;

            //foreach (Control c in this.Controls)
            //{
            //    if (c.Name == ((Control)sender).Name)
            //    {
            //        c.ForeColor = Color.Red;
            //    }
            //    else
            //    {
            //        c.ForeColor = Color.Black;
            //    }
            //}

            foreach (Control c in this.Controls)
            {
                if (c.Equals(sender))
                {
                    c.ForeColor = Color.Red;
                }
                else
                {
                    c.ForeColor = Color.Black;
                }
            }

            ((Control)sender).ForeColor = Color.Red;

            ObjectName = ((Control)sender).Text;
            MessageBox.Show("Hello " + ObjectName);
        }




این تیکه کد خیلی خوب بود

حتی اینجا مطرح می کنیم که چطور یک رویداد جدید با زدن یک دکمه برای دکمه دیگه ای اضافه بشه
فرضا یک سری دکمه ها کارشون اینه که وقتی میزنیم رنگشون قرمز میشه
میخوایم با زدن یک کلید برای یک دکمه خاص بهش رویداد دیگه ای هم اضافه بشه
که توی اون رویداد فرضا یک پیغام هم بدهد


اینم کد این کار هست

private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            labelControl.Click += new EventHandler(MsgEvent);
        }

        private void MsgEvent (object sender, EventArgs e)
        {
            string ObjectName;

            ObjectName = ((Control)sender).Text;
            MessageBox.Show("Hello " + ObjectName);
        }




با تیکه کد پایین میشه با زدن یک دکمه میشه 4 تا دکمه و یک فیلد متنی ایجاد کرد
بهترین گزینه برای ساخت فرمساز هست

private void MsgEvent(object sender, EventArgs e)
        {
            string ObjectName;

            ObjectName = ((Control)sender).Text;
            MessageBox.Show("Hello " + ObjectName);
        }

        private void buttonRunTimeEvent_Click(object sender, EventArgs e)
        {
            int Top, Left, Height;

            Top = this.Height / 10;
            Left = this.Width - 100;
            Height = this.Height / 10;

            TextBox textBox = new TextBox();
            textBox.Top = Top;
            textBox.Left = Left;
            textBox.Height = Height;
            textBox.Name = "NewTextBox";

            this.Controls.Add(textBox);

            for (int i = 1; i <= 4; ++i)
            {
                Button button = new Button();
                button.Left = Left;
                button.Top = (i + 1) * Top;
                button.Height = Height;
                button.Name = "button" + i.ToString();
                button.Text = "button" + i.ToString();

                this.Controls.Add(button);

                button.Click += new EventHandler(MsgEvent);
            }
        }