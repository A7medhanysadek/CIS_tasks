using System.Collections.Specialized;

namespace CRUD_application
{
    public partial class Form1 : Form
    {
        List<string> l;
        string list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new List<string>();
        }
        //åßÊÈ ÈÇáÚÑÈí ÈÓ áÇä áæ ßÊÈÊ ãÚÇå ÈÇáÇäÌáíÒí ÇáßáÇã åíÏÎá Ýí ÈÚÖå
        //ÇáÝäßÔä Çááí ÊÍÊ Ïí æÙíÝÊåÇ ÊÎÝí ÇáÇÒÑÇÑ ÇáÇÓÇÓíå (ÇáßÑæÏ) æÈÊÙåÑ ÒÑÇÑ ãåã áÇä ãä ÎáÇáå äÞÏÑ äÑÌÚ ááÇÒÑÇÑ ÇáÇÓÇÓíÉ Çááí åí ÇáßÑæÏ
        private void hide_the_headline()
        {
            create.Visible = false;
            read.Visible = false;
            update.Visible = false;
            delete.Visible = false;
            back.Visible = true;
        }
        //åäÇ ßá ÇáÇÒÑÇÑ ÇáÑÆíÓíå Çááí ÇáÕÝÍå ãÚÊãÏå Ýí ÇáÊäÞá Èíä ÇáÚäÇÕÑ Úáíåã Çááí åã ÇáßÑæÏ æßá ãÇ ÇÖÛØ Úáì æÇÍÏ ãäåã åíÙåÑáí ÇáÚäÇÕÑ ÇáÎÇÕå Èßá æÇÍÏ ãäåã ÚÔÇä ÇÞÏÑ ÇÚãá ÚáãáíÇÊ Úáì ÇááíÓÊ
        private void create_Click(object sender, EventArgs e)
        {
            create_btn.Visible = true;
            create_lbl.Visible = true;
            create_txtbox.Visible = true;
            hide_the_headline();
        }
        private void read_Click(object sender, EventArgs e)
        {
            read_indx.Visible = true;
            read_list.Visible = true;
            hide_the_headline();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_origin_lbl.Visible = true;
            update_new_lbl.Visible = true;
            update_btn.Visible = true;
            update_txtBox_origin_value.Visible = true;
            update_txtBox_new_value.Visible = true;
            hide_the_headline();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_btn.Visible = true;
            delete_value_lbl.Visible = true;
            delete_txtBox.Visible = true;
            hide_the_headline();
        }
        //ÇáÒÑÇÑ Ïå ãä Öãä ÇáÚãáíÇÊ ÇáÎÇÕå ÈßÑííÊ æÙíÝÊå Çäå ÈíÊÇßÏ ÇáÇæá ãä Çä ÇáãÓÊÎÏã ÏÎá Þíãå æÈíÇÎÏ ÇáÞíãå Ïí æÈíÖíÝåÇ Ýí ÇááíÓÊ 
        private void create_btn_Click(object sender, EventArgs e)
        {
            if (create_txtbox.Text != string.Empty)
            {
                l.Add(create_txtbox.Text);
                MessageBox.Show("the dataset has been created");
                create_txtbox.Text = string.Empty;
            }
            else
                MessageBox.Show("please enter a dataset to create", "", MessageBoxButtons.YesNo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Ïå ÇáÒÑÇÑ ÇáÎÇÕ ÈÚãíÉ ÇáÞÑÇÁÉ åæ æÇááí ÊÍÊå ææÙíÝÊåã Çäåã ÈíÙåÑæ ÒÑÇÑíä ÊÇäííä æÇÍÏ ÈíÓÊÎÏã ÚÔÇä íØáÚ ßá ÚäÇÕÑ ÇááíÓÊ æÇáÊÇäí ÈíÓÊÎÏã ÚÔÇä íØáÚ ÚäÕÑ Ýí ÇäÏßÓ ãÚíä 
        private void read_indx_Click(object sender, EventArgs e)
        {
            read_indx.Visible = false;
            read_list.Visible = false;
            read_lbl.Visible = true;
            read_txtbox.Visible = true;
            read_indx_btn.Visible = true;
        }

        private void read_list_Click(object sender, EventArgs e)
        {
            read_indx.Visible = false;
            read_list.Visible = false;
            read_richTextBox.Visible = true;
            read_list_btn.Visible = true;
        }
        //Ïå ÇáÒÑÇÑ ÇáÎÇÕ ÈÇäå íÞÑÃ ÚäÕÑ ÚäÏ ÇäÏßÓ ãÚíä ÈíÊÇßÏ ÇáÇæá Çä ÇáãÓÊÎÏã ãÏÎáÔ Þíãå ÛáØ ááÇäÏßÓ ÚÔÇä ãíÍÕáÔ ÇßÓÈÔä æÈÚÏ ãÇ íÊÃßÏ ÈíÞÑÃ ÇáÚäÕÑ 
        private void read_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(read_txtbox.Text, out int ignore))
                MessageBox.Show("invalid index");
            else
            {
                if (int.Parse(read_txtbox.Text) >= l.Count() || int.Parse(read_txtbox.Text) < 0)
                    MessageBox.Show("invalid index");
                else
                {
                    MessageBox.Show("the element you looking for is: " + l.ElementAt(int.Parse(read_txtbox.Text)));
                }
            }
        }

        //åäÇ ÇáÒÑÇÑ ÇáÊÇäí ÇáÎÇÕ ÈÇäå ÈíÞÑÃ ÚäÇÕÑ ÇááíÓÊ ßáåÇ æåæ ÈíÞÑÃåã ÈíÎÒäåã Ýí ãÊÛíÑ ÚÔÇä ÈÚÏ ãÇ íÎáÕåã íÙåÑåã Ýí ÇáÊßÓÊ ÈæßÓ
        private void read_list_btn_Click(object sender, EventArgs e)
        {
            list = string.Empty;
            for (int i = 0; i < l.Count; i++)
            {
                list += l.ElementAt(i) + '\n';
            }
            read_richTextBox.Text = list;
        }
        //Ïå æÇÍÏ ãä Çåã ÇáÇÒÑÇÑ Ýí ÇáÈÑäÇãÌ æÙíÝÊå ÈÚÏ ãÇ ÇÚãá Úãáíå æÚÇæÒ ÇÑæÍ áÛíÑåÇ ÈíÎÝí Çí Úãáíå ßÇäÊ ÔÛÇáå æÈíÙåÑ ÇáÇÒÑÇÑ ÇáÇÓÇÓíÉ(ÇáßÑæÏ) Ýíí ÇáÕÝÍÉ
        private void back_Click(object sender, EventArgs e)
        {
            create.Visible = true;
            read.Visible = true;
            update.Visible = true;
            delete.Visible = true;
            create_btn.Visible = false;
            create_lbl.Visible = false;
            create_txtbox.Visible = false;
            read_indx.Visible = false;
            read_indx_btn.Visible = false;
            read_list.Visible = false;
            read_list_btn.Visible = false;
            read_richTextBox.Visible = false;
            read_lbl.Visible = false;
            read_txtbox.Visible = false;
            update_btn.Visible = false;
            update_new_lbl.Visible = false;
            update_origin_lbl.Visible = false;
            update_txtBox_origin_value.Visible = false;
            update_txtBox_new_value.Visible = false;
            delete_btn.Visible = false;
            delete_value_lbl.Visible = false;
            delete_txtBox.Visible = false;
        }
        //åäÇ æÙíÝÉ ÇáÒÑÇÑ Ïå Çäå íÊÃßÏ Çáä ÇáãÓÊÎÏã ÏÎá ÞíãÉ ÇáÚäÕÑ Çááí ÚÇæÒ íÚãáå ÇÈÏíÊ æÈíÈÏáå ÈÇáÚäÕÑ ÇáÌÏíÏ
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (l.Count == 0)
                MessageBox.Show("the list is empty ):");
            else
            {
                if (l.Contains(update_origin_lbl.Text))
                {
                    int index = l.IndexOf(update_txtBox_origin_value.Text);
                    l.Remove(update_txtBox_origin_value.Text);
                    l.Insert(index, update_txtBox_new_value.Text);
                    update_txtBox_new_value.Text = string.Empty;
                    update_txtBox_origin_value.Text = string.Empty;
                }
                else
                    MessageBox.Show("the element you have entered does not exist the list ):");
            }
        }
        //æÏå ÇáÒÑÇÑ ÇáãÓÄá Çäå íãÓÍ ÚäÕÑ ãÚíä ãä ÇááíÓÊ ÇáãÓÊÎÏã Çááí ÈíÏÎáå
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (l.Contains(delete_txtBox.Text))
            {
                l.Remove(delete_txtBox.Text);
                delete_txtBox.Text = string.Empty;
            }
            else
                MessageBox.Show("the element you have entered does not exist the list ):");
        }
    }
}