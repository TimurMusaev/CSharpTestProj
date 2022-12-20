using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProjectTMusaev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            counter = 0;
        }
        int counter;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //Add column header
            listView1.Columns.Add("Character", 150);
            listView1.Columns.Add("Value", 700);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            string letters = null;
            string lettersCheck = null;
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                counter++;
                letters+= comboBox1.SelectedItem;
                if (CHB1.Checked == false){ lettersCheck += "0"; } else{ lettersCheck += "1"; }
                if (CHB2.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB3.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB4.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB5.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB6.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB7.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB8.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB9.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB10.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB11.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB12.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB13.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB14.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB15.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB16.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB17.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB18.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB19.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB20.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB21.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB22.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB23.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB24.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB25.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB26.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB27.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB28.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB29.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB30.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB31.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB32.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB33.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB34.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB35.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB36.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB37.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB38.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB39.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB40.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB41.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }
                if (CHB42.Checked == false) { lettersCheck += "0"; } else { lettersCheck += "1"; }      
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing else
            }   
            string[] arr = new string[2];
            arr[0]= letters;
            arr[1] = lettersCheck;
            ListViewItem itm;
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CHB1.Checked = false; CHB2.Checked = false; CHB3.Checked = false; CHB4.Checked = false; CHB5.Checked = false; CHB6.Checked = false;
            CHB7.Checked = false; CHB8.Checked = false; CHB9.Checked = false; CHB10.Checked = false; CHB11.Checked = false; CHB12.Checked = false;
            CHB13.Checked = false; CHB14.Checked = false; CHB15.Checked = false; CHB16.Checked = false; CHB17.Checked = false; CHB18.Checked = false;
            CHB19.Checked = false; CHB20.Checked = false; CHB21.Checked = false; CHB22.Checked = false; CHB23.Checked = false; CHB24.Checked = false;
            CHB25.Checked = false; CHB26.Checked = false; CHB27.Checked = false; CHB28.Checked = false; CHB29.Checked = false; CHB30.Checked = false;
            CHB31.Checked = false; CHB32.Checked = false; CHB33.Checked = false; CHB34.Checked = false; CHB35.Checked = false; CHB36.Checked = false;
            CHB37.Checked = false; CHB38.Checked = false; CHB39.Checked = false; CHB40.Checked = false; CHB41.Checked = false; CHB42.Checked = false;
            comboBox1.ResetText();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string CurrentLetter = null;
            for (int k = 0; k < text1.Length; k++)
            {
                for (int i = 0; i < counter; i++)
                {
                    string str = listView1.Items[i].SubItems[0].Text.ToString();
                    if (text1[k] == str[0])
                        CurrentLetter += listView1.Items[i].SubItems[1].Text.ToString();
                }
            }
            if (text1.Length == 1)
            {
                if (CurrentLetter[0] == '0') { CH2B1.Checked = false; } else if (CurrentLetter[0] == '1') { CH2B1.Checked = true; }
                if (CurrentLetter[1] == '0') { CH2B2.Checked = false; } else if (CurrentLetter[1] == '1') { CH2B2.Checked = true; }
                if (CurrentLetter[2] == '0') { CH2B3.Checked = false; } else if (CurrentLetter[2] == '1') { CH2B3.Checked = true; }
                if (CurrentLetter[3] == '0') { CH2B4.Checked = false; } else if (CurrentLetter[3] == '1') { CH2B4.Checked = true; }
                if (CurrentLetter[4] == '0') { CH2B5.Checked = false; } else if (CurrentLetter[4] == '1') { CH2B5.Checked = true; }
                if (CurrentLetter[5] == '0') { CH2B6.Checked = false; } else if (CurrentLetter[5] == '1') { CH2B6.Checked = true; }
                if (CurrentLetter[6] == '0') { CH2B7.Checked = false; } else if (CurrentLetter[6] == '1') { CH2B7.Checked = true; }
                if (CurrentLetter[7] == '0') { CH2B8.Checked = false; } else if (CurrentLetter[7] == '1') { CH2B8.Checked = true; }
                if (CurrentLetter[8] == '0') { CH2B9.Checked = false; } else if (CurrentLetter[8] == '1') { CH2B9.Checked = true; }
                if (CurrentLetter[9] == '0') { CH2B10.Checked = false; } else if (CurrentLetter[9] == '1') { CH2B10.Checked = true; }
                if (CurrentLetter[10] == '0') { CH2B11.Checked = false; } else if (CurrentLetter[10] == '1') { CH2B11.Checked = true; }
                if (CurrentLetter[11] == '0') { CH2B12.Checked = false; } else if (CurrentLetter[11] == '1') { CH2B12.Checked = true; }
                if (CurrentLetter[12] == '0') { CH2B13.Checked = false; } else if (CurrentLetter[12] == '1') { CH2B13.Checked = true; }
                if (CurrentLetter[13] == '0') { CH2B14.Checked = false; } else if (CurrentLetter[13] == '1') { CH2B14.Checked = true; }
                if (CurrentLetter[14] == '0') { CH2B15.Checked = false; } else if (CurrentLetter[14] == '1') { CH2B15.Checked = true; }
                if (CurrentLetter[15] == '0') { CH2B16.Checked = false; } else if (CurrentLetter[15] == '1') { CH2B16.Checked = true; }
                if (CurrentLetter[16] == '0') { CH2B17.Checked = false; } else if (CurrentLetter[16] == '1') { CH2B17.Checked = true; }
                if (CurrentLetter[17] == '0') { CH2B18.Checked = false; } else if (CurrentLetter[17] == '1') { CH2B18.Checked = true; }
                if (CurrentLetter[18] == '0') { CH2B19.Checked = false; } else if (CurrentLetter[18] == '1') { CH2B19.Checked = true; }
                if (CurrentLetter[19] == '0') { CH2B20.Checked = false; } else if (CurrentLetter[19] == '1') { CH2B20.Checked = true; }
                if (CurrentLetter[20] == '0') { CH2B21.Checked = false; } else if (CurrentLetter[20] == '1') { CH2B21.Checked = true; }
                if (CurrentLetter[21] == '0') { CH2B22.Checked = false; } else if (CurrentLetter[21] == '1') { CH2B22.Checked = true; }
                if (CurrentLetter[22] == '0') { CH2B23.Checked = false; } else if (CurrentLetter[22] == '1') { CH2B23.Checked = true; }
                if (CurrentLetter[23] == '0') { CH2B24.Checked = false; } else if (CurrentLetter[23] == '1') { CH2B24.Checked = true; }
                if (CurrentLetter[24] == '0') { CH2B25.Checked = false; } else if (CurrentLetter[24] == '1') { CH2B25.Checked = true; }
                if (CurrentLetter[25] == '0') { CH2B26.Checked = false; } else if (CurrentLetter[25] == '1') { CH2B26.Checked = true; }
                if (CurrentLetter[26] == '0') { CH2B27.Checked = false; } else if (CurrentLetter[26] == '1') { CH2B27.Checked = true; }
                if (CurrentLetter[27] == '0') { CH2B28.Checked = false; } else if (CurrentLetter[27] == '1') { CH2B28.Checked = true; }
                if (CurrentLetter[28] == '0') { CH2B29.Checked = false; } else if (CurrentLetter[28] == '1') { CH2B29.Checked = true; }
                if (CurrentLetter[29] == '0') { CH2B30.Checked = false; } else if (CurrentLetter[29] == '1') { CH2B30.Checked = true; }
                if (CurrentLetter[30] == '0') { CH2B31.Checked = false; } else if (CurrentLetter[30] == '1') { CH2B31.Checked = true; }
                if (CurrentLetter[31] == '0') { CH2B32.Checked = false; } else if (CurrentLetter[31] == '1') { CH2B32.Checked = true; }
                if (CurrentLetter[32] == '0') { CH2B33.Checked = false; } else if (CurrentLetter[32] == '1') { CH2B33.Checked = true; }
                if (CurrentLetter[33] == '0') { CH2B34.Checked = false; } else if (CurrentLetter[33] == '1') { CH2B34.Checked = true; }
                if (CurrentLetter[34] == '0') { CH2B35.Checked = false; } else if (CurrentLetter[34] == '1') { CH2B35.Checked = true; }
                if (CurrentLetter[35] == '0') { CH2B36.Checked = false; } else if (CurrentLetter[35] == '1') { CH2B36.Checked = true; }
                if (CurrentLetter[36] == '0') { CH2B37.Checked = false; } else if (CurrentLetter[36] == '1') { CH2B37.Checked = true; }
                if (CurrentLetter[37] == '0') { CH2B38.Checked = false; } else if (CurrentLetter[37] == '1') { CH2B38.Checked = true; }
                if (CurrentLetter[38] == '0') { CH2B39.Checked = false; } else if (CurrentLetter[38] == '1') { CH2B39.Checked = true; }
                if (CurrentLetter[39] == '0') { CH2B40.Checked = false; } else if (CurrentLetter[39] == '1') { CH2B40.Checked = true; }
                if (CurrentLetter[40] == '0') { CH2B41.Checked = false; } else if (CurrentLetter[40] == '1') { CH2B41.Checked = true; }
                if (CurrentLetter[41] == '0') { CH2B42.Checked = false; } else if (CurrentLetter[41] == '1') { CH2B42.Checked = true; }
            }
            if (text1.Length == 2)
            {
                if (CurrentLetter[0] == '0') { CH2B1.Checked = false; } else if (CurrentLetter[0] == '1') { CH2B1.Checked = true; }
                if (CurrentLetter[1] == '0') { CH2B2.Checked = false; } else if (CurrentLetter[1] == '1') { CH2B2.Checked = true; }
                if (CurrentLetter[2] == '0') { CH2B3.Checked = false; } else if (CurrentLetter[2] == '1') { CH2B3.Checked = true; }
                if (CurrentLetter[3] == '0') { CH2B4.Checked = false; } else if (CurrentLetter[3] == '1') { CH2B4.Checked = true; }
                if (CurrentLetter[4] == '0') { CH2B5.Checked = false; } else if (CurrentLetter[4] == '1') { CH2B5.Checked = true; }
                if (CurrentLetter[5] == '0') { CH2B6.Checked = false; } else if (CurrentLetter[5] == '1') { CH2B6.Checked = true; }
                if (CurrentLetter[6] == '0') { CH2B7.Checked = false; } else if (CurrentLetter[6] == '1') { CH2B7.Checked = true; }
                if (CurrentLetter[7] == '0') { CH2B8.Checked = false; } else if (CurrentLetter[7] == '1') { CH2B8.Checked = true; }
                if (CurrentLetter[8] == '0') { CH2B9.Checked = false; } else if (CurrentLetter[8] == '1') { CH2B9.Checked = true; }
                if (CurrentLetter[9] == '0') { CH2B10.Checked = false; } else if (CurrentLetter[9] == '1') { CH2B10.Checked = true; }
                if (CurrentLetter[10] == '0') { CH2B11.Checked = false; } else if (CurrentLetter[10] == '1') { CH2B11.Checked = true; }
                if (CurrentLetter[11] == '0') { CH2B12.Checked = false; } else if (CurrentLetter[11] == '1') { CH2B12.Checked = true; }
                if (CurrentLetter[12] == '0') { CH2B13.Checked = false; } else if (CurrentLetter[12] == '1') { CH2B13.Checked = true; }
                if (CurrentLetter[13] == '0') { CH2B14.Checked = false; } else if (CurrentLetter[13] == '1') { CH2B14.Checked = true; }
                if (CurrentLetter[14] == '0') { CH2B15.Checked = false; } else if (CurrentLetter[14] == '1') { CH2B15.Checked = true; }
                if (CurrentLetter[15] == '0') { CH2B16.Checked = false; } else if (CurrentLetter[15] == '1') { CH2B16.Checked = true; }
                if (CurrentLetter[16] == '0') { CH2B17.Checked = false; } else if (CurrentLetter[16] == '1') { CH2B17.Checked = true; }
                if (CurrentLetter[17] == '0') { CH2B18.Checked = false; } else if (CurrentLetter[17] == '1') { CH2B18.Checked = true; }
                if (CurrentLetter[18] == '0') { CH2B19.Checked = false; } else if (CurrentLetter[18] == '1') { CH2B19.Checked = true; }
                if (CurrentLetter[19] == '0') { CH2B20.Checked = false; } else if (CurrentLetter[19] == '1') { CH2B20.Checked = true; }
                if (CurrentLetter[20] == '0') { CH2B21.Checked = false; } else if (CurrentLetter[20] == '1') { CH2B21.Checked = true; }
                if (CurrentLetter[21] == '0') { CH2B22.Checked = false; } else if (CurrentLetter[21] == '1') { CH2B22.Checked = true; }
                if (CurrentLetter[22] == '0') { CH2B23.Checked = false; } else if (CurrentLetter[22] == '1') { CH2B23.Checked = true; }
                if (CurrentLetter[23] == '0') { CH2B24.Checked = false; } else if (CurrentLetter[23] == '1') { CH2B24.Checked = true; }
                if (CurrentLetter[24] == '0') { CH2B25.Checked = false; } else if (CurrentLetter[24] == '1') { CH2B25.Checked = true; }
                if (CurrentLetter[25] == '0') { CH2B26.Checked = false; } else if (CurrentLetter[25] == '1') { CH2B26.Checked = true; }
                if (CurrentLetter[26] == '0') { CH2B27.Checked = false; } else if (CurrentLetter[26] == '1') { CH2B27.Checked = true; }
                if (CurrentLetter[27] == '0') { CH2B28.Checked = false; } else if (CurrentLetter[27] == '1') { CH2B28.Checked = true; }
                if (CurrentLetter[28] == '0') { CH2B29.Checked = false; } else if (CurrentLetter[28] == '1') { CH2B29.Checked = true; }
                if (CurrentLetter[29] == '0') { CH2B30.Checked = false; } else if (CurrentLetter[29] == '1') { CH2B30.Checked = true; }
                if (CurrentLetter[30] == '0') { CH2B31.Checked = false; } else if (CurrentLetter[30] == '1') { CH2B31.Checked = true; }
                if (CurrentLetter[31] == '0') { CH2B32.Checked = false; } else if (CurrentLetter[31] == '1') { CH2B32.Checked = true; }
                if (CurrentLetter[32] == '0') { CH2B33.Checked = false; } else if (CurrentLetter[32] == '1') { CH2B33.Checked = true; }
                if (CurrentLetter[33] == '0') { CH2B34.Checked = false; } else if (CurrentLetter[33] == '1') { CH2B34.Checked = true; }
                if (CurrentLetter[34] == '0') { CH2B35.Checked = false; } else if (CurrentLetter[34] == '1') { CH2B35.Checked = true; }
                if (CurrentLetter[35] == '0') { CH2B36.Checked = false; } else if (CurrentLetter[35] == '1') { CH2B36.Checked = true; }
                if (CurrentLetter[36] == '0') { CH2B37.Checked = false; } else if (CurrentLetter[36] == '1') { CH2B37.Checked = true; }
                if (CurrentLetter[37] == '0') { CH2B38.Checked = false; } else if (CurrentLetter[37] == '1') { CH2B38.Checked = true; }
                if (CurrentLetter[38] == '0') { CH2B39.Checked = false; } else if (CurrentLetter[38] == '1') { CH2B39.Checked = true; }
                if (CurrentLetter[39] == '0') { CH2B40.Checked = false; } else if (CurrentLetter[39] == '1') { CH2B40.Checked = true; }
                if (CurrentLetter[40] == '0') { CH2B41.Checked = false; } else if (CurrentLetter[40] == '1') { CH2B41.Checked = true; }
                if (CurrentLetter[41] == '0') { CH2B42.Checked = false; } else if (CurrentLetter[41] == '1') { CH2B42.Checked = true; }

                if (CurrentLetter[42] == '0') { CH3B1.Checked = false; } else if (CurrentLetter[42] == '1') { CH3B1.Checked = true; }
                if (CurrentLetter[43] == '0') { CH3B2.Checked = false; } else if (CurrentLetter[43] == '1') { CH3B2.Checked = true; }
                if (CurrentLetter[44] == '0') { CH3B3.Checked = false; } else if (CurrentLetter[44] == '1') { CH3B3.Checked = true; }
                if (CurrentLetter[45] == '0') { CH3B4.Checked = false; } else if (CurrentLetter[45] == '1') { CH3B4.Checked = true; }
                if (CurrentLetter[46] == '0') { CH3B5.Checked = false; } else if (CurrentLetter[46] == '1') { CH3B5.Checked = true; }
                if (CurrentLetter[47] == '0') { CH3B6.Checked = false; } else if (CurrentLetter[47] == '1') { CH3B6.Checked = true; }
                if (CurrentLetter[48] == '0') { CH3B7.Checked = false; } else if (CurrentLetter[48] == '1') { CH3B7.Checked = true; }
                if (CurrentLetter[49] == '0') { CH3B8.Checked = false; } else if (CurrentLetter[49] == '1') { CH3B8.Checked = true; }
                if (CurrentLetter[50] == '0') { CH3B9.Checked = false; } else if (CurrentLetter[50] == '1') { CH3B9.Checked = true; }
                if (CurrentLetter[51] == '0') { CH3B10.Checked = false; } else if (CurrentLetter[51] == '1') { CH3B10.Checked = true; }
                if (CurrentLetter[52] == '0') { CH3B11.Checked = false; } else if (CurrentLetter[52] == '1') { CH3B11.Checked = true; }
                if (CurrentLetter[53] == '0') { CH3B12.Checked = false; } else if (CurrentLetter[53] == '1') { CH3B12.Checked = true; }
                if (CurrentLetter[54] == '0') { CH3B13.Checked = false; } else if (CurrentLetter[54] == '1') { CH3B13.Checked = true; }
                if (CurrentLetter[55] == '0') { CH3B14.Checked = false; } else if (CurrentLetter[55] == '1') { CH3B14.Checked = true; }
                if (CurrentLetter[56] == '0') { CH3B15.Checked = false; } else if (CurrentLetter[56] == '1') { CH3B15.Checked = true; }
                if (CurrentLetter[57] == '0') { CH3B16.Checked = false; } else if (CurrentLetter[57] == '1') { CH3B16.Checked = true; }
                if (CurrentLetter[58] == '0') { CH3B17.Checked = false; } else if (CurrentLetter[58] == '1') { CH3B17.Checked = true; }
                if (CurrentLetter[59] == '0') { CH3B18.Checked = false; } else if (CurrentLetter[59] == '1') { CH3B18.Checked = true; }
                if (CurrentLetter[60] == '0') { CH3B19.Checked = false; } else if (CurrentLetter[60] == '1') { CH3B19.Checked = true; }
                if (CurrentLetter[61] == '0') { CH3B20.Checked = false; } else if (CurrentLetter[61] == '1') { CH3B20.Checked = true; }
                if (CurrentLetter[62] == '0') { CH3B21.Checked = false; } else if (CurrentLetter[62] == '1') { CH3B21.Checked = true; }
                if (CurrentLetter[63] == '0') { CH3B22.Checked = false; } else if (CurrentLetter[63] == '1') { CH3B22.Checked = true; }
                if (CurrentLetter[64] == '0') { CH3B23.Checked = false; } else if (CurrentLetter[64] == '1') { CH3B23.Checked = true; }
                if (CurrentLetter[65] == '0') { CH3B24.Checked = false; } else if (CurrentLetter[65] == '1') { CH3B24.Checked = true; }
                if (CurrentLetter[66] == '0') { CH3B25.Checked = false; } else if (CurrentLetter[66] == '1') { CH3B25.Checked = true; }
                if (CurrentLetter[67] == '0') { CH3B26.Checked = false; } else if (CurrentLetter[67] == '1') { CH3B26.Checked = true; }
                if (CurrentLetter[68] == '0') { CH3B27.Checked = false; } else if (CurrentLetter[68] == '1') { CH3B27.Checked = true; }
                if (CurrentLetter[69] == '0') { CH3B28.Checked = false; } else if (CurrentLetter[69] == '1') { CH3B28.Checked = true; }
                if (CurrentLetter[70] == '0') { CH3B29.Checked = false; } else if (CurrentLetter[70] == '1') { CH3B29.Checked = true; }
                if (CurrentLetter[71] == '0') { CH3B30.Checked = false; } else if (CurrentLetter[71] == '1') { CH3B30.Checked = true; }
                if (CurrentLetter[72] == '0') { CH3B31.Checked = false; } else if (CurrentLetter[72] == '1') { CH3B31.Checked = true; }
                if (CurrentLetter[73] == '0') { CH3B32.Checked = false; } else if (CurrentLetter[73] == '1') { CH3B32.Checked = true; }
                if (CurrentLetter[74] == '0') { CH3B33.Checked = false; } else if (CurrentLetter[74] == '1') { CH3B33.Checked = true; }
                if (CurrentLetter[75] == '0') { CH3B34.Checked = false; } else if (CurrentLetter[75] == '1') { CH3B34.Checked = true; }
                if (CurrentLetter[76] == '0') { CH3B35.Checked = false; } else if (CurrentLetter[76] == '1') { CH3B35.Checked = true; }
                if (CurrentLetter[77] == '0') { CH3B36.Checked = false; } else if (CurrentLetter[77] == '1') { CH3B36.Checked = true; }
                if (CurrentLetter[78] == '0') { CH3B37.Checked = false; } else if (CurrentLetter[78] == '1') { CH3B37.Checked = true; }
                if (CurrentLetter[79] == '0') { CH3B38.Checked = false; } else if (CurrentLetter[79] == '1') { CH3B38.Checked = true; }
                if (CurrentLetter[80] == '0') { CH3B39.Checked = false; } else if (CurrentLetter[80] == '1') { CH3B39.Checked = true; }
                if (CurrentLetter[81] == '0') { CH3B40.Checked = false; } else if (CurrentLetter[81] == '1') { CH3B40.Checked = true; }
                if (CurrentLetter[82] == '0') { CH3B41.Checked = false; } else if (CurrentLetter[82] == '1') { CH3B41.Checked = true; }
                if (CurrentLetter[83] == '0') { CH3B42.Checked = false; } else if (CurrentLetter[83] == '1') { CH3B42.Checked = true; }
            }
            if (text1.Length == 3)
            {
                if (CurrentLetter[0] == '0') { CH2B1.Checked = false; } else if (CurrentLetter[0] == '1') { CH2B1.Checked = true; }
                if (CurrentLetter[1] == '0') { CH2B2.Checked = false; } else if (CurrentLetter[1] == '1') { CH2B2.Checked = true; }
                if (CurrentLetter[2] == '0') { CH2B3.Checked = false; } else if (CurrentLetter[2] == '1') { CH2B3.Checked = true; }
                if (CurrentLetter[3] == '0') { CH2B4.Checked = false; } else if (CurrentLetter[3] == '1') { CH2B4.Checked = true; }
                if (CurrentLetter[4] == '0') { CH2B5.Checked = false; } else if (CurrentLetter[4] == '1') { CH2B5.Checked = true; }
                if (CurrentLetter[5] == '0') { CH2B6.Checked = false; } else if (CurrentLetter[5] == '1') { CH2B6.Checked = true; }
                if (CurrentLetter[6] == '0') { CH2B7.Checked = false; } else if (CurrentLetter[6] == '1') { CH2B7.Checked = true; }
                if (CurrentLetter[7] == '0') { CH2B8.Checked = false; } else if (CurrentLetter[7] == '1') { CH2B8.Checked = true; }
                if (CurrentLetter[8] == '0') { CH2B9.Checked = false; } else if (CurrentLetter[8] == '1') { CH2B9.Checked = true; }
                if (CurrentLetter[9] == '0') { CH2B10.Checked = false; } else if (CurrentLetter[9] == '1') { CH2B10.Checked = true; }
                if (CurrentLetter[10] == '0') { CH2B11.Checked = false; } else if (CurrentLetter[10] == '1') { CH2B11.Checked = true; }
                if (CurrentLetter[11] == '0') { CH2B12.Checked = false; } else if (CurrentLetter[11] == '1') { CH2B12.Checked = true; }
                if (CurrentLetter[12] == '0') { CH2B13.Checked = false; } else if (CurrentLetter[12] == '1') { CH2B13.Checked = true; }
                if (CurrentLetter[13] == '0') { CH2B14.Checked = false; } else if (CurrentLetter[13] == '1') { CH2B14.Checked = true; }
                if (CurrentLetter[14] == '0') { CH2B15.Checked = false; } else if (CurrentLetter[14] == '1') { CH2B15.Checked = true; }
                if (CurrentLetter[15] == '0') { CH2B16.Checked = false; } else if (CurrentLetter[15] == '1') { CH2B16.Checked = true; }
                if (CurrentLetter[16] == '0') { CH2B17.Checked = false; } else if (CurrentLetter[16] == '1') { CH2B17.Checked = true; }
                if (CurrentLetter[17] == '0') { CH2B18.Checked = false; } else if (CurrentLetter[17] == '1') { CH2B18.Checked = true; }
                if (CurrentLetter[18] == '0') { CH2B19.Checked = false; } else if (CurrentLetter[18] == '1') { CH2B19.Checked = true; }
                if (CurrentLetter[19] == '0') { CH2B20.Checked = false; } else if (CurrentLetter[19] == '1') { CH2B20.Checked = true; }
                if (CurrentLetter[20] == '0') { CH2B21.Checked = false; } else if (CurrentLetter[20] == '1') { CH2B21.Checked = true; }
                if (CurrentLetter[21] == '0') { CH2B22.Checked = false; } else if (CurrentLetter[21] == '1') { CH2B22.Checked = true; }
                if (CurrentLetter[22] == '0') { CH2B23.Checked = false; } else if (CurrentLetter[22] == '1') { CH2B23.Checked = true; }
                if (CurrentLetter[23] == '0') { CH2B24.Checked = false; } else if (CurrentLetter[23] == '1') { CH2B24.Checked = true; }
                if (CurrentLetter[24] == '0') { CH2B25.Checked = false; } else if (CurrentLetter[24] == '1') { CH2B25.Checked = true; }
                if (CurrentLetter[25] == '0') { CH2B26.Checked = false; } else if (CurrentLetter[25] == '1') { CH2B26.Checked = true; }
                if (CurrentLetter[26] == '0') { CH2B27.Checked = false; } else if (CurrentLetter[26] == '1') { CH2B27.Checked = true; }
                if (CurrentLetter[27] == '0') { CH2B28.Checked = false; } else if (CurrentLetter[27] == '1') { CH2B28.Checked = true; }
                if (CurrentLetter[28] == '0') { CH2B29.Checked = false; } else if (CurrentLetter[28] == '1') { CH2B29.Checked = true; }
                if (CurrentLetter[29] == '0') { CH2B30.Checked = false; } else if (CurrentLetter[29] == '1') { CH2B30.Checked = true; }
                if (CurrentLetter[30] == '0') { CH2B31.Checked = false; } else if (CurrentLetter[30] == '1') { CH2B31.Checked = true; }
                if (CurrentLetter[31] == '0') { CH2B32.Checked = false; } else if (CurrentLetter[31] == '1') { CH2B32.Checked = true; }
                if (CurrentLetter[32] == '0') { CH2B33.Checked = false; } else if (CurrentLetter[32] == '1') { CH2B33.Checked = true; }
                if (CurrentLetter[33] == '0') { CH2B34.Checked = false; } else if (CurrentLetter[33] == '1') { CH2B34.Checked = true; }
                if (CurrentLetter[34] == '0') { CH2B35.Checked = false; } else if (CurrentLetter[34] == '1') { CH2B35.Checked = true; }
                if (CurrentLetter[35] == '0') { CH2B36.Checked = false; } else if (CurrentLetter[35] == '1') { CH2B36.Checked = true; }
                if (CurrentLetter[36] == '0') { CH2B37.Checked = false; } else if (CurrentLetter[36] == '1') { CH2B37.Checked = true; }
                if (CurrentLetter[37] == '0') { CH2B38.Checked = false; } else if (CurrentLetter[37] == '1') { CH2B38.Checked = true; }
                if (CurrentLetter[38] == '0') { CH2B39.Checked = false; } else if (CurrentLetter[38] == '1') { CH2B39.Checked = true; }
                if (CurrentLetter[39] == '0') { CH2B40.Checked = false; } else if (CurrentLetter[39] == '1') { CH2B40.Checked = true; }
                if (CurrentLetter[40] == '0') { CH2B41.Checked = false; } else if (CurrentLetter[40] == '1') { CH2B41.Checked = true; }
                if (CurrentLetter[41] == '0') { CH2B42.Checked = false; } else if (CurrentLetter[41] == '1') { CH2B42.Checked = true; }

                if (CurrentLetter[42] == '0') { CH3B1.Checked = false; } else if (CurrentLetter[42] == '1') { CH3B1.Checked = true; }
                if (CurrentLetter[43] == '0') { CH3B2.Checked = false; } else if (CurrentLetter[43] == '1') { CH3B2.Checked = true; }
                if (CurrentLetter[44] == '0') { CH3B3.Checked = false; } else if (CurrentLetter[44] == '1') { CH3B3.Checked = true; }
                if (CurrentLetter[45] == '0') { CH3B4.Checked = false; } else if (CurrentLetter[45] == '1') { CH3B4.Checked = true; }
                if (CurrentLetter[46] == '0') { CH3B5.Checked = false; } else if (CurrentLetter[46] == '1') { CH3B5.Checked = true; }
                if (CurrentLetter[47] == '0') { CH3B6.Checked = false; } else if (CurrentLetter[47] == '1') { CH3B6.Checked = true; }
                if (CurrentLetter[48] == '0') { CH3B7.Checked = false; } else if (CurrentLetter[48] == '1') { CH3B7.Checked = true; }
                if (CurrentLetter[49] == '0') { CH3B8.Checked = false; } else if (CurrentLetter[49] == '1') { CH3B8.Checked = true; }
                if (CurrentLetter[50] == '0') { CH3B9.Checked = false; } else if (CurrentLetter[50] == '1') { CH3B9.Checked = true; }
                if (CurrentLetter[51] == '0') { CH3B10.Checked = false; } else if (CurrentLetter[51] == '1') { CH3B10.Checked = true; }
                if (CurrentLetter[52] == '0') { CH3B11.Checked = false; } else if (CurrentLetter[52] == '1') { CH3B11.Checked = true; }
                if (CurrentLetter[53] == '0') { CH3B12.Checked = false; } else if (CurrentLetter[53] == '1') { CH3B12.Checked = true; }
                if (CurrentLetter[54] == '0') { CH3B13.Checked = false; } else if (CurrentLetter[54] == '1') { CH3B13.Checked = true; }
                if (CurrentLetter[55] == '0') { CH3B14.Checked = false; } else if (CurrentLetter[55] == '1') { CH3B14.Checked = true; }
                if (CurrentLetter[56] == '0') { CH3B15.Checked = false; } else if (CurrentLetter[56] == '1') { CH3B15.Checked = true; }
                if (CurrentLetter[57] == '0') { CH3B16.Checked = false; } else if (CurrentLetter[57] == '1') { CH3B16.Checked = true; }
                if (CurrentLetter[58] == '0') { CH3B17.Checked = false; } else if (CurrentLetter[58] == '1') { CH3B17.Checked = true; }
                if (CurrentLetter[59] == '0') { CH3B18.Checked = false; } else if (CurrentLetter[59] == '1') { CH3B18.Checked = true; }
                if (CurrentLetter[60] == '0') { CH3B19.Checked = false; } else if (CurrentLetter[60] == '1') { CH3B19.Checked = true; }
                if (CurrentLetter[61] == '0') { CH3B20.Checked = false; } else if (CurrentLetter[61] == '1') { CH3B20.Checked = true; }
                if (CurrentLetter[62] == '0') { CH3B21.Checked = false; } else if (CurrentLetter[62] == '1') { CH3B21.Checked = true; }
                if (CurrentLetter[63] == '0') { CH3B22.Checked = false; } else if (CurrentLetter[63] == '1') { CH3B22.Checked = true; }
                if (CurrentLetter[64] == '0') { CH3B23.Checked = false; } else if (CurrentLetter[64] == '1') { CH3B23.Checked = true; }
                if (CurrentLetter[65] == '0') { CH3B24.Checked = false; } else if (CurrentLetter[65] == '1') { CH3B24.Checked = true; }
                if (CurrentLetter[66] == '0') { CH3B25.Checked = false; } else if (CurrentLetter[66] == '1') { CH3B25.Checked = true; }
                if (CurrentLetter[67] == '0') { CH3B26.Checked = false; } else if (CurrentLetter[67] == '1') { CH3B26.Checked = true; }
                if (CurrentLetter[68] == '0') { CH3B27.Checked = false; } else if (CurrentLetter[68] == '1') { CH3B27.Checked = true; }
                if (CurrentLetter[69] == '0') { CH3B28.Checked = false; } else if (CurrentLetter[69] == '1') { CH3B28.Checked = true; }
                if (CurrentLetter[70] == '0') { CH3B29.Checked = false; } else if (CurrentLetter[70] == '1') { CH3B29.Checked = true; }
                if (CurrentLetter[71] == '0') { CH3B30.Checked = false; } else if (CurrentLetter[71] == '1') { CH3B30.Checked = true; }
                if (CurrentLetter[72] == '0') { CH3B31.Checked = false; } else if (CurrentLetter[72] == '1') { CH3B31.Checked = true; }
                if (CurrentLetter[73] == '0') { CH3B32.Checked = false; } else if (CurrentLetter[73] == '1') { CH3B32.Checked = true; }
                if (CurrentLetter[74] == '0') { CH3B33.Checked = false; } else if (CurrentLetter[74] == '1') { CH3B33.Checked = true; }
                if (CurrentLetter[75] == '0') { CH3B34.Checked = false; } else if (CurrentLetter[75] == '1') { CH3B34.Checked = true; }
                if (CurrentLetter[76] == '0') { CH3B35.Checked = false; } else if (CurrentLetter[76] == '1') { CH3B35.Checked = true; }
                if (CurrentLetter[77] == '0') { CH3B36.Checked = false; } else if (CurrentLetter[77] == '1') { CH3B36.Checked = true; }
                if (CurrentLetter[78] == '0') { CH3B37.Checked = false; } else if (CurrentLetter[78] == '1') { CH3B37.Checked = true; }
                if (CurrentLetter[79] == '0') { CH3B38.Checked = false; } else if (CurrentLetter[79] == '1') { CH3B38.Checked = true; }
                if (CurrentLetter[80] == '0') { CH3B39.Checked = false; } else if (CurrentLetter[80] == '1') { CH3B39.Checked = true; }
                if (CurrentLetter[81] == '0') { CH3B40.Checked = false; } else if (CurrentLetter[81] == '1') { CH3B40.Checked = true; }
                if (CurrentLetter[82] == '0') { CH3B41.Checked = false; } else if (CurrentLetter[82] == '1') { CH3B41.Checked = true; }
                if (CurrentLetter[83] == '0') { CH3B42.Checked = false; } else if (CurrentLetter[83] == '1') { CH3B42.Checked = true; }

                if (CurrentLetter[84] == '0') { CH4B1.Checked = false; } else if (CurrentLetter[84] == '1') { CH4B1.Checked = true; }
                if (CurrentLetter[85] == '0') { CH4B2.Checked = false; } else if (CurrentLetter[85] == '1') { CH4B2.Checked = true; }
                if (CurrentLetter[86] == '0') { CH4B3.Checked = false; } else if (CurrentLetter[86] == '1') { CH4B3.Checked = true; }
                if (CurrentLetter[87] == '0') { CH4B4.Checked = false; } else if (CurrentLetter[87] == '1') { CH4B4.Checked = true; }
                if (CurrentLetter[88] == '0') { CH4B5.Checked = false; } else if (CurrentLetter[88] == '1') { CH4B5.Checked = true; }
                if (CurrentLetter[89] == '0') { CH4B6.Checked = false; } else if (CurrentLetter[89] == '1') { CH4B6.Checked = true; }
                if (CurrentLetter[90] == '0') { CH4B7.Checked = false; } else if (CurrentLetter[90] == '1') { CH4B7.Checked = true; }
                if (CurrentLetter[91] == '0') { CH4B8.Checked = false; } else if (CurrentLetter[91] == '1') { CH4B8.Checked = true; }
                if (CurrentLetter[92] == '0') { CH4B9.Checked = false; } else if (CurrentLetter[92] == '1') { CH4B9.Checked = true; }
                if (CurrentLetter[93] == '0') { CH4B10.Checked = false; } else if (CurrentLetter[93] == '1') { CH4B10.Checked = true; }
                if (CurrentLetter[94] == '0') { CH4B11.Checked = false; } else if (CurrentLetter[94] == '1') { CH4B11.Checked = true; }
                if (CurrentLetter[95] == '0') { CH4B12.Checked = false; } else if (CurrentLetter[95] == '1') { CH4B12.Checked = true; }
                if (CurrentLetter[96] == '0') { CH4B13.Checked = false; } else if (CurrentLetter[96] == '1') { CH4B13.Checked = true; }
                if (CurrentLetter[97] == '0') { CH4B14.Checked = false; } else if (CurrentLetter[97] == '1') { CH4B14.Checked = true; }
                if (CurrentLetter[98] == '0') { CH4B15.Checked = false; } else if (CurrentLetter[98] == '1') { CH4B15.Checked = true; }
                if (CurrentLetter[99] == '0') { CH4B16.Checked = false; } else if (CurrentLetter[99] == '1') { CH4B16.Checked = true; }
                if (CurrentLetter[100] == '0') { CH4B17.Checked = false; } else if (CurrentLetter[100] == '1') { CH4B17.Checked = true; }
                if (CurrentLetter[101] == '0') { CH4B18.Checked = false; } else if (CurrentLetter[101] == '1') { CH4B18.Checked = true; }
                if (CurrentLetter[102] == '0') { CH4B19.Checked = false; } else if (CurrentLetter[102] == '1') { CH4B19.Checked = true; }
                if (CurrentLetter[103] == '0') { CH4B20.Checked = false; } else if (CurrentLetter[103] == '1') { CH4B20.Checked = true; }
                if (CurrentLetter[104] == '0') { CH4B21.Checked = false; } else if (CurrentLetter[104] == '1') { CH4B21.Checked = true; }
                if (CurrentLetter[105] == '0') { CH4B22.Checked = false; } else if (CurrentLetter[105] == '1') { CH4B22.Checked = true; }
                if (CurrentLetter[106] == '0') { CH4B23.Checked = false; } else if (CurrentLetter[106] == '1') { CH4B23.Checked = true; }
                if (CurrentLetter[107] == '0') { CH4B24.Checked = false; } else if (CurrentLetter[107] == '1') { CH4B24.Checked = true; }
                if (CurrentLetter[108] == '0') { CH4B25.Checked = false; } else if (CurrentLetter[108] == '1') { CH4B25.Checked = true; }
                if (CurrentLetter[109] == '0') { CH4B26.Checked = false; } else if (CurrentLetter[109] == '1') { CH4B26.Checked = true; }
                if (CurrentLetter[110] == '0') { CH4B27.Checked = false; } else if (CurrentLetter[110] == '1') { CH4B27.Checked = true; }
                if (CurrentLetter[111] == '0') { CH4B28.Checked = false; } else if (CurrentLetter[111] == '1') { CH4B28.Checked = true; }
                if (CurrentLetter[112] == '0') { CH4B29.Checked = false; } else if (CurrentLetter[112] == '1') { CH4B29.Checked = true; }
                if (CurrentLetter[113] == '0') { CH4B30.Checked = false; } else if (CurrentLetter[113] == '1') { CH4B30.Checked = true; }
                if (CurrentLetter[114] == '0') { CH4B31.Checked = false; } else if (CurrentLetter[114] == '1') { CH4B31.Checked = true; }
                if (CurrentLetter[115] == '0') { CH4B32.Checked = false; } else if (CurrentLetter[115] == '1') { CH4B32.Checked = true; }
                if (CurrentLetter[116] == '0') { CH4B33.Checked = false; } else if (CurrentLetter[116] == '1') { CH4B33.Checked = true; }
                if (CurrentLetter[117] == '0') { CH4B34.Checked = false; } else if (CurrentLetter[117] == '1') { CH4B34.Checked = true; }
                if (CurrentLetter[118] == '0') { CH4B35.Checked = false; } else if (CurrentLetter[118] == '1') { CH4B35.Checked = true; }
                if (CurrentLetter[119] == '0') { CH4B36.Checked = false; } else if (CurrentLetter[119] == '1') { CH4B36.Checked = true; }
                if (CurrentLetter[120] == '0') { CH4B37.Checked = false; } else if (CurrentLetter[120] == '1') { CH4B37.Checked = true; }
                if (CurrentLetter[121] == '0') { CH4B38.Checked = false; } else if (CurrentLetter[121] == '1') { CH4B38.Checked = true; }
                if (CurrentLetter[122] == '0') { CH4B39.Checked = false; } else if (CurrentLetter[122] == '1') { CH4B39.Checked = true; }
                if (CurrentLetter[123] == '0') { CH4B40.Checked = false; } else if (CurrentLetter[123] == '1') { CH4B40.Checked = true; }
                if (CurrentLetter[124] == '0') { CH4B41.Checked = false; } else if (CurrentLetter[124] == '1') { CH4B41.Checked = true; }
                if (CurrentLetter[125] == '0') { CH4B42.Checked = false; } else if (CurrentLetter[125] == '1') { CH4B42.Checked = true; }
            }
            if (text1.Length == 4)
            {
                if (CurrentLetter[0] == '0') { CH2B1.Checked = false; } else if (CurrentLetter[0] == '1') { CH2B1.Checked = true; }
                if (CurrentLetter[1] == '0') { CH2B2.Checked = false; } else if (CurrentLetter[1] == '1') { CH2B2.Checked = true; }
                if (CurrentLetter[2] == '0') { CH2B3.Checked = false; } else if (CurrentLetter[2] == '1') { CH2B3.Checked = true; }
                if (CurrentLetter[3] == '0') { CH2B4.Checked = false; } else if (CurrentLetter[3] == '1') { CH2B4.Checked = true; }
                if (CurrentLetter[4] == '0') { CH2B5.Checked = false; } else if (CurrentLetter[4] == '1') { CH2B5.Checked = true; }
                if (CurrentLetter[5] == '0') { CH2B6.Checked = false; } else if (CurrentLetter[5] == '1') { CH2B6.Checked = true; }
                if (CurrentLetter[6] == '0') { CH2B7.Checked = false; } else if (CurrentLetter[6] == '1') { CH2B7.Checked = true; }
                if (CurrentLetter[7] == '0') { CH2B8.Checked = false; } else if (CurrentLetter[7] == '1') { CH2B8.Checked = true; }
                if (CurrentLetter[8] == '0') { CH2B9.Checked = false; } else if (CurrentLetter[8] == '1') { CH2B9.Checked = true; }
                if (CurrentLetter[9] == '0') { CH2B10.Checked = false; } else if (CurrentLetter[9] == '1') { CH2B10.Checked = true; }
                if (CurrentLetter[10] == '0') { CH2B11.Checked = false; } else if (CurrentLetter[10] == '1') { CH2B11.Checked = true; }
                if (CurrentLetter[11] == '0') { CH2B12.Checked = false; } else if (CurrentLetter[11] == '1') { CH2B12.Checked = true; }
                if (CurrentLetter[12] == '0') { CH2B13.Checked = false; } else if (CurrentLetter[12] == '1') { CH2B13.Checked = true; }
                if (CurrentLetter[13] == '0') { CH2B14.Checked = false; } else if (CurrentLetter[13] == '1') { CH2B14.Checked = true; }
                if (CurrentLetter[14] == '0') { CH2B15.Checked = false; } else if (CurrentLetter[14] == '1') { CH2B15.Checked = true; }
                if (CurrentLetter[15] == '0') { CH2B16.Checked = false; } else if (CurrentLetter[15] == '1') { CH2B16.Checked = true; }
                if (CurrentLetter[16] == '0') { CH2B17.Checked = false; } else if (CurrentLetter[16] == '1') { CH2B17.Checked = true; }
                if (CurrentLetter[17] == '0') { CH2B18.Checked = false; } else if (CurrentLetter[17] == '1') { CH2B18.Checked = true; }
                if (CurrentLetter[18] == '0') { CH2B19.Checked = false; } else if (CurrentLetter[18] == '1') { CH2B19.Checked = true; }
                if (CurrentLetter[19] == '0') { CH2B20.Checked = false; } else if (CurrentLetter[19] == '1') { CH2B20.Checked = true; }
                if (CurrentLetter[20] == '0') { CH2B21.Checked = false; } else if (CurrentLetter[20] == '1') { CH2B21.Checked = true; }
                if (CurrentLetter[21] == '0') { CH2B22.Checked = false; } else if (CurrentLetter[21] == '1') { CH2B22.Checked = true; }
                if (CurrentLetter[22] == '0') { CH2B23.Checked = false; } else if (CurrentLetter[22] == '1') { CH2B23.Checked = true; }
                if (CurrentLetter[23] == '0') { CH2B24.Checked = false; } else if (CurrentLetter[23] == '1') { CH2B24.Checked = true; }
                if (CurrentLetter[24] == '0') { CH2B25.Checked = false; } else if (CurrentLetter[24] == '1') { CH2B25.Checked = true; }
                if (CurrentLetter[25] == '0') { CH2B26.Checked = false; } else if (CurrentLetter[25] == '1') { CH2B26.Checked = true; }
                if (CurrentLetter[26] == '0') { CH2B27.Checked = false; } else if (CurrentLetter[26] == '1') { CH2B27.Checked = true; }
                if (CurrentLetter[27] == '0') { CH2B28.Checked = false; } else if (CurrentLetter[27] == '1') { CH2B28.Checked = true; }
                if (CurrentLetter[28] == '0') { CH2B29.Checked = false; } else if (CurrentLetter[28] == '1') { CH2B29.Checked = true; }
                if (CurrentLetter[29] == '0') { CH2B30.Checked = false; } else if (CurrentLetter[29] == '1') { CH2B30.Checked = true; }
                if (CurrentLetter[30] == '0') { CH2B31.Checked = false; } else if (CurrentLetter[30] == '1') { CH2B31.Checked = true; }
                if (CurrentLetter[31] == '0') { CH2B32.Checked = false; } else if (CurrentLetter[31] == '1') { CH2B32.Checked = true; }
                if (CurrentLetter[32] == '0') { CH2B33.Checked = false; } else if (CurrentLetter[32] == '1') { CH2B33.Checked = true; }
                if (CurrentLetter[33] == '0') { CH2B34.Checked = false; } else if (CurrentLetter[33] == '1') { CH2B34.Checked = true; }
                if (CurrentLetter[34] == '0') { CH2B35.Checked = false; } else if (CurrentLetter[34] == '1') { CH2B35.Checked = true; }
                if (CurrentLetter[35] == '0') { CH2B36.Checked = false; } else if (CurrentLetter[35] == '1') { CH2B36.Checked = true; }
                if (CurrentLetter[36] == '0') { CH2B37.Checked = false; } else if (CurrentLetter[36] == '1') { CH2B37.Checked = true; }
                if (CurrentLetter[37] == '0') { CH2B38.Checked = false; } else if (CurrentLetter[37] == '1') { CH2B38.Checked = true; }
                if (CurrentLetter[38] == '0') { CH2B39.Checked = false; } else if (CurrentLetter[38] == '1') { CH2B39.Checked = true; }
                if (CurrentLetter[39] == '0') { CH2B40.Checked = false; } else if (CurrentLetter[39] == '1') { CH2B40.Checked = true; }
                if (CurrentLetter[40] == '0') { CH2B41.Checked = false; } else if (CurrentLetter[40] == '1') { CH2B41.Checked = true; }
                if (CurrentLetter[41] == '0') { CH2B42.Checked = false; } else if (CurrentLetter[41] == '1') { CH2B42.Checked = true; }

                if (CurrentLetter[42] == '0') { CH3B1.Checked = false; } else if (CurrentLetter[42] == '1') { CH3B1.Checked = true; }
                if (CurrentLetter[43] == '0') { CH3B2.Checked = false; } else if (CurrentLetter[43] == '1') { CH3B2.Checked = true; }
                if (CurrentLetter[44] == '0') { CH3B3.Checked = false; } else if (CurrentLetter[44] == '1') { CH3B3.Checked = true; }
                if (CurrentLetter[45] == '0') { CH3B4.Checked = false; } else if (CurrentLetter[45] == '1') { CH3B4.Checked = true; }
                if (CurrentLetter[46] == '0') { CH3B5.Checked = false; } else if (CurrentLetter[46] == '1') { CH3B5.Checked = true; }
                if (CurrentLetter[47] == '0') { CH3B6.Checked = false; } else if (CurrentLetter[47] == '1') { CH3B6.Checked = true; }
                if (CurrentLetter[48] == '0') { CH3B7.Checked = false; } else if (CurrentLetter[48] == '1') { CH3B7.Checked = true; }
                if (CurrentLetter[49] == '0') { CH3B8.Checked = false; } else if (CurrentLetter[49] == '1') { CH3B8.Checked = true; }
                if (CurrentLetter[50] == '0') { CH3B9.Checked = false; } else if (CurrentLetter[50] == '1') { CH3B9.Checked = true; }
                if (CurrentLetter[51] == '0') { CH3B10.Checked = false; } else if (CurrentLetter[51] == '1') { CH3B10.Checked = true; }
                if (CurrentLetter[52] == '0') { CH3B11.Checked = false; } else if (CurrentLetter[52] == '1') { CH3B11.Checked = true; }
                if (CurrentLetter[53] == '0') { CH3B12.Checked = false; } else if (CurrentLetter[53] == '1') { CH3B12.Checked = true; }
                if (CurrentLetter[54] == '0') { CH3B13.Checked = false; } else if (CurrentLetter[54] == '1') { CH3B13.Checked = true; }
                if (CurrentLetter[55] == '0') { CH3B14.Checked = false; } else if (CurrentLetter[55] == '1') { CH3B14.Checked = true; }
                if (CurrentLetter[56] == '0') { CH3B15.Checked = false; } else if (CurrentLetter[56] == '1') { CH3B15.Checked = true; }
                if (CurrentLetter[57] == '0') { CH3B16.Checked = false; } else if (CurrentLetter[57] == '1') { CH3B16.Checked = true; }
                if (CurrentLetter[58] == '0') { CH3B17.Checked = false; } else if (CurrentLetter[58] == '1') { CH3B17.Checked = true; }
                if (CurrentLetter[59] == '0') { CH3B18.Checked = false; } else if (CurrentLetter[59] == '1') { CH3B18.Checked = true; }
                if (CurrentLetter[60] == '0') { CH3B19.Checked = false; } else if (CurrentLetter[60] == '1') { CH3B19.Checked = true; }
                if (CurrentLetter[61] == '0') { CH3B20.Checked = false; } else if (CurrentLetter[61] == '1') { CH3B20.Checked = true; }
                if (CurrentLetter[62] == '0') { CH3B21.Checked = false; } else if (CurrentLetter[62] == '1') { CH3B21.Checked = true; }
                if (CurrentLetter[63] == '0') { CH3B22.Checked = false; } else if (CurrentLetter[63] == '1') { CH3B22.Checked = true; }
                if (CurrentLetter[64] == '0') { CH3B23.Checked = false; } else if (CurrentLetter[64] == '1') { CH3B23.Checked = true; }
                if (CurrentLetter[65] == '0') { CH3B24.Checked = false; } else if (CurrentLetter[65] == '1') { CH3B24.Checked = true; }
                if (CurrentLetter[66] == '0') { CH3B25.Checked = false; } else if (CurrentLetter[66] == '1') { CH3B25.Checked = true; }
                if (CurrentLetter[67] == '0') { CH3B26.Checked = false; } else if (CurrentLetter[67] == '1') { CH3B26.Checked = true; }
                if (CurrentLetter[68] == '0') { CH3B27.Checked = false; } else if (CurrentLetter[68] == '1') { CH3B27.Checked = true; }
                if (CurrentLetter[69] == '0') { CH3B28.Checked = false; } else if (CurrentLetter[69] == '1') { CH3B28.Checked = true; }
                if (CurrentLetter[70] == '0') { CH3B29.Checked = false; } else if (CurrentLetter[70] == '1') { CH3B29.Checked = true; }
                if (CurrentLetter[71] == '0') { CH3B30.Checked = false; } else if (CurrentLetter[71] == '1') { CH3B30.Checked = true; }
                if (CurrentLetter[72] == '0') { CH3B31.Checked = false; } else if (CurrentLetter[72] == '1') { CH3B31.Checked = true; }
                if (CurrentLetter[73] == '0') { CH3B32.Checked = false; } else if (CurrentLetter[73] == '1') { CH3B32.Checked = true; }
                if (CurrentLetter[74] == '0') { CH3B33.Checked = false; } else if (CurrentLetter[74] == '1') { CH3B33.Checked = true; }
                if (CurrentLetter[75] == '0') { CH3B34.Checked = false; } else if (CurrentLetter[75] == '1') { CH3B34.Checked = true; }
                if (CurrentLetter[76] == '0') { CH3B35.Checked = false; } else if (CurrentLetter[76] == '1') { CH3B35.Checked = true; }
                if (CurrentLetter[77] == '0') { CH3B36.Checked = false; } else if (CurrentLetter[77] == '1') { CH3B36.Checked = true; }
                if (CurrentLetter[78] == '0') { CH3B37.Checked = false; } else if (CurrentLetter[78] == '1') { CH3B37.Checked = true; }
                if (CurrentLetter[79] == '0') { CH3B38.Checked = false; } else if (CurrentLetter[79] == '1') { CH3B38.Checked = true; }
                if (CurrentLetter[80] == '0') { CH3B39.Checked = false; } else if (CurrentLetter[80] == '1') { CH3B39.Checked = true; }
                if (CurrentLetter[81] == '0') { CH3B40.Checked = false; } else if (CurrentLetter[81] == '1') { CH3B40.Checked = true; }
                if (CurrentLetter[82] == '0') { CH3B41.Checked = false; } else if (CurrentLetter[82] == '1') { CH3B41.Checked = true; }
                if (CurrentLetter[83] == '0') { CH3B42.Checked = false; } else if (CurrentLetter[83] == '1') { CH3B42.Checked = true; }

                if (CurrentLetter[84] == '0') { CH4B1.Checked = false; } else if (CurrentLetter[84] == '1') { CH4B1.Checked = true; }
                if (CurrentLetter[85] == '0') { CH4B2.Checked = false; } else if (CurrentLetter[85] == '1') { CH4B2.Checked = true; }
                if (CurrentLetter[86] == '0') { CH4B3.Checked = false; } else if (CurrentLetter[86] == '1') { CH4B3.Checked = true; }
                if (CurrentLetter[87] == '0') { CH4B4.Checked = false; } else if (CurrentLetter[87] == '1') { CH4B4.Checked = true; }
                if (CurrentLetter[88] == '0') { CH4B5.Checked = false; } else if (CurrentLetter[88] == '1') { CH4B5.Checked = true; }
                if (CurrentLetter[89] == '0') { CH4B6.Checked = false; } else if (CurrentLetter[89] == '1') { CH4B6.Checked = true; }
                if (CurrentLetter[90] == '0') { CH4B7.Checked = false; } else if (CurrentLetter[90] == '1') { CH4B7.Checked = true; }
                if (CurrentLetter[91] == '0') { CH4B8.Checked = false; } else if (CurrentLetter[91] == '1') { CH4B8.Checked = true; }
                if (CurrentLetter[92] == '0') { CH4B9.Checked = false; } else if (CurrentLetter[92] == '1') { CH4B9.Checked = true; }
                if (CurrentLetter[93] == '0') { CH4B10.Checked = false; } else if (CurrentLetter[93] == '1') { CH4B10.Checked = true; }
                if (CurrentLetter[94] == '0') { CH4B11.Checked = false; } else if (CurrentLetter[94] == '1') { CH4B11.Checked = true; }
                if (CurrentLetter[95] == '0') { CH4B12.Checked = false; } else if (CurrentLetter[95] == '1') { CH4B12.Checked = true; }
                if (CurrentLetter[96] == '0') { CH4B13.Checked = false; } else if (CurrentLetter[96] == '1') { CH4B13.Checked = true; }
                if (CurrentLetter[97] == '0') { CH4B14.Checked = false; } else if (CurrentLetter[97] == '1') { CH4B14.Checked = true; }
                if (CurrentLetter[98] == '0') { CH4B15.Checked = false; } else if (CurrentLetter[98] == '1') { CH4B15.Checked = true; }
                if (CurrentLetter[99] == '0') { CH4B16.Checked = false; } else if (CurrentLetter[99] == '1') { CH4B16.Checked = true; }
                if (CurrentLetter[100] == '0') { CH4B17.Checked = false; } else if (CurrentLetter[100] == '1') { CH4B17.Checked = true; }
                if (CurrentLetter[101] == '0') { CH4B18.Checked = false; } else if (CurrentLetter[101] == '1') { CH4B18.Checked = true; }
                if (CurrentLetter[102] == '0') { CH4B19.Checked = false; } else if (CurrentLetter[102] == '1') { CH4B19.Checked = true; }
                if (CurrentLetter[103] == '0') { CH4B20.Checked = false; } else if (CurrentLetter[103] == '1') { CH4B20.Checked = true; }
                if (CurrentLetter[104] == '0') { CH4B21.Checked = false; } else if (CurrentLetter[104] == '1') { CH4B21.Checked = true; }
                if (CurrentLetter[105] == '0') { CH4B22.Checked = false; } else if (CurrentLetter[105] == '1') { CH4B22.Checked = true; }
                if (CurrentLetter[106] == '0') { CH4B23.Checked = false; } else if (CurrentLetter[106] == '1') { CH4B23.Checked = true; }
                if (CurrentLetter[107] == '0') { CH4B24.Checked = false; } else if (CurrentLetter[107] == '1') { CH4B24.Checked = true; }
                if (CurrentLetter[108] == '0') { CH4B25.Checked = false; } else if (CurrentLetter[108] == '1') { CH4B25.Checked = true; }
                if (CurrentLetter[109] == '0') { CH4B26.Checked = false; } else if (CurrentLetter[109] == '1') { CH4B26.Checked = true; }
                if (CurrentLetter[110] == '0') { CH4B27.Checked = false; } else if (CurrentLetter[110] == '1') { CH4B27.Checked = true; }
                if (CurrentLetter[111] == '0') { CH4B28.Checked = false; } else if (CurrentLetter[111] == '1') { CH4B28.Checked = true; }
                if (CurrentLetter[112] == '0') { CH4B29.Checked = false; } else if (CurrentLetter[112] == '1') { CH4B29.Checked = true; }
                if (CurrentLetter[113] == '0') { CH4B30.Checked = false; } else if (CurrentLetter[113] == '1') { CH4B30.Checked = true; }
                if (CurrentLetter[114] == '0') { CH4B31.Checked = false; } else if (CurrentLetter[114] == '1') { CH4B31.Checked = true; }
                if (CurrentLetter[115] == '0') { CH4B32.Checked = false; } else if (CurrentLetter[115] == '1') { CH4B32.Checked = true; }
                if (CurrentLetter[116] == '0') { CH4B33.Checked = false; } else if (CurrentLetter[116] == '1') { CH4B33.Checked = true; }
                if (CurrentLetter[117] == '0') { CH4B34.Checked = false; } else if (CurrentLetter[117] == '1') { CH4B34.Checked = true; }
                if (CurrentLetter[118] == '0') { CH4B35.Checked = false; } else if (CurrentLetter[118] == '1') { CH4B35.Checked = true; }
                if (CurrentLetter[119] == '0') { CH4B36.Checked = false; } else if (CurrentLetter[119] == '1') { CH4B36.Checked = true; }
                if (CurrentLetter[120] == '0') { CH4B37.Checked = false; } else if (CurrentLetter[120] == '1') { CH4B37.Checked = true; }
                if (CurrentLetter[121] == '0') { CH4B38.Checked = false; } else if (CurrentLetter[121] == '1') { CH4B38.Checked = true; }
                if (CurrentLetter[122] == '0') { CH4B39.Checked = false; } else if (CurrentLetter[122] == '1') { CH4B39.Checked = true; }
                if (CurrentLetter[123] == '0') { CH4B40.Checked = false; } else if (CurrentLetter[123] == '1') { CH4B40.Checked = true; }
                if (CurrentLetter[124] == '0') { CH4B41.Checked = false; } else if (CurrentLetter[124] == '1') { CH4B41.Checked = true; }
                if (CurrentLetter[125] == '0') { CH4B42.Checked = false; } else if (CurrentLetter[125] == '1') { CH4B42.Checked = true; }

                if (CurrentLetter[126] == '0') { CH5B1.Checked = false; } else if (CurrentLetter[125] == '1') { CH5B1.Checked = true; }
                if (CurrentLetter[127] == '0') { CH5B2.Checked = false; } else if (CurrentLetter[127] == '1') { CH5B2.Checked = true; }
                if (CurrentLetter[128] == '0') { CH5B3.Checked = false; } else if (CurrentLetter[128] == '1') { CH5B3.Checked = true; }
                if (CurrentLetter[129] == '0') { CH5B4.Checked = false; } else if (CurrentLetter[129] == '1') { CH5B4.Checked = true; }
                if (CurrentLetter[130] == '0') { CH5B5.Checked = false; } else if (CurrentLetter[130] == '1') { CH5B5.Checked = true; }
                if (CurrentLetter[131] == '0') { CH5B6.Checked = false; } else if (CurrentLetter[131] == '1') { CH5B6.Checked = true; }
                if (CurrentLetter[132] == '0') { CH5B7.Checked = false; } else if (CurrentLetter[132] == '1') { CH5B7.Checked = true; }
                if (CurrentLetter[133] == '0') { CH5B8.Checked = false; } else if (CurrentLetter[133] == '1') { CH5B8.Checked = true; }
                if (CurrentLetter[134] == '0') { CH5B9.Checked = false; } else if (CurrentLetter[134] == '1') { CH5B9.Checked = true; }
                if (CurrentLetter[135] == '0') { CH5B10.Checked = false; } else if (CurrentLetter[135] == '1') { CH5B10.Checked = true; }
                if (CurrentLetter[136] == '0') { CH5B11.Checked = false; } else if (CurrentLetter[136] == '1') { CH5B11.Checked = true; }
                if (CurrentLetter[137] == '0') { CH5B12.Checked = false; } else if (CurrentLetter[137] == '1') { CH5B12.Checked = true; }
                if (CurrentLetter[138] == '0') { CH5B13.Checked = false; } else if (CurrentLetter[138] == '1') { CH5B13.Checked = true; }
                if (CurrentLetter[139] == '0') { CH5B14.Checked = false; } else if (CurrentLetter[139] == '1') { CH5B14.Checked = true; }
                if (CurrentLetter[140] == '0') { CH5B15.Checked = false; } else if (CurrentLetter[140] == '1') { CH5B15.Checked = true; }
                if (CurrentLetter[141] == '0') { CH5B16.Checked = false; } else if (CurrentLetter[141] == '1') { CH5B16.Checked = true; }
                if (CurrentLetter[142] == '0') { CH5B17.Checked = false; } else if (CurrentLetter[142] == '1') { CH5B17.Checked = true; }
                if (CurrentLetter[143] == '0') { CH5B18.Checked = false; } else if (CurrentLetter[143] == '1') { CH5B18.Checked = true; }
                if (CurrentLetter[144] == '0') { CH5B19.Checked = false; } else if (CurrentLetter[144] == '1') { CH5B19.Checked = true; }
                if (CurrentLetter[145] == '0') { CH5B20.Checked = false; } else if (CurrentLetter[145] == '1') { CH5B20.Checked = true; }
                if (CurrentLetter[146] == '0') { CH5B21.Checked = false; } else if (CurrentLetter[146] == '1') { CH5B21.Checked = true; }
                if (CurrentLetter[147] == '0') { CH5B22.Checked = false; } else if (CurrentLetter[147] == '1') { CH5B22.Checked = true; }
                if (CurrentLetter[148] == '0') { CH5B23.Checked = false; } else if (CurrentLetter[148] == '1') { CH5B23.Checked = true; }
                if (CurrentLetter[149] == '0') { CH5B24.Checked = false; } else if (CurrentLetter[149] == '1') { CH5B24.Checked = true; }
                if (CurrentLetter[150] == '0') { CH5B25.Checked = false; } else if (CurrentLetter[150] == '1') { CH5B25.Checked = true; }
                if (CurrentLetter[151] == '0') { CH5B26.Checked = false; } else if (CurrentLetter[151] == '1') { CH5B26.Checked = true; }
                if (CurrentLetter[152] == '0') { CH5B27.Checked = false; } else if (CurrentLetter[152] == '1') { CH5B27.Checked = true; }
                if (CurrentLetter[153] == '0') { CH5B28.Checked = false; } else if (CurrentLetter[153] == '1') { CH5B28.Checked = true; }
                if (CurrentLetter[154] == '0') { CH5B29.Checked = false; } else if (CurrentLetter[154] == '1') { CH5B29.Checked = true; }
                if (CurrentLetter[155] == '0') { CH5B30.Checked = false; } else if (CurrentLetter[155] == '1') { CH5B30.Checked = true; }
                if (CurrentLetter[156] == '0') { CH5B31.Checked = false; } else if (CurrentLetter[156] == '1') { CH5B31.Checked = true; }
                if (CurrentLetter[157] == '0') { CH5B32.Checked = false; } else if (CurrentLetter[157] == '1') { CH5B32.Checked = true; }
                if (CurrentLetter[158] == '0') { CH5B33.Checked = false; } else if (CurrentLetter[158] == '1') { CH5B33.Checked = true; }
                if (CurrentLetter[159] == '0') { CH5B34.Checked = false; } else if (CurrentLetter[159] == '1') { CH5B34.Checked = true; }
                if (CurrentLetter[160] == '0') { CH5B35.Checked = false; } else if (CurrentLetter[160] == '1') { CH5B35.Checked = true; }
                if (CurrentLetter[161] == '0') { CH5B36.Checked = false; } else if (CurrentLetter[161] == '1') { CH5B36.Checked = true; }
                if (CurrentLetter[162] == '0') { CH5B37.Checked = false; } else if (CurrentLetter[162] == '1') { CH5B37.Checked = true; }
                if (CurrentLetter[163] == '0') { CH5B38.Checked = false; } else if (CurrentLetter[163] == '1') { CH5B38.Checked = true; }
                if (CurrentLetter[164] == '0') { CH5B39.Checked = false; } else if (CurrentLetter[164] == '1') { CH5B39.Checked = true; }
                if (CurrentLetter[165] == '0') { CH5B40.Checked = false; } else if (CurrentLetter[165] == '1') { CH5B40.Checked = true; }
                if (CurrentLetter[166] == '0') { CH5B41.Checked = false; } else if (CurrentLetter[166] == '1') { CH5B41.Checked = true; }
                if (CurrentLetter[167] == '0') { CH5B42.Checked = false; } else if (CurrentLetter[167] == '1') { CH5B42.Checked = true; }
            }

            if (text1.Length == 5)
            {
                if (CurrentLetter[0] == '0') { CH2B1.Checked = false; } else if (CurrentLetter[0] == '1') { CH2B1.Checked = true; }
                if (CurrentLetter[1] == '0') { CH2B2.Checked = false; } else if (CurrentLetter[1] == '1') { CH2B2.Checked = true; }
                if (CurrentLetter[2] == '0') { CH2B3.Checked = false; } else if (CurrentLetter[2] == '1') { CH2B3.Checked = true; }
                if (CurrentLetter[3] == '0') { CH2B4.Checked = false; } else if (CurrentLetter[3] == '1') { CH2B4.Checked = true; }
                if (CurrentLetter[4] == '0') { CH2B5.Checked = false; } else if (CurrentLetter[4] == '1') { CH2B5.Checked = true; }
                if (CurrentLetter[5] == '0') { CH2B6.Checked = false; } else if (CurrentLetter[5] == '1') { CH2B6.Checked = true; }
                if (CurrentLetter[6] == '0') { CH2B7.Checked = false; } else if (CurrentLetter[6] == '1') { CH2B7.Checked = true; }
                if (CurrentLetter[7] == '0') { CH2B8.Checked = false; } else if (CurrentLetter[7] == '1') { CH2B8.Checked = true; }
                if (CurrentLetter[8] == '0') { CH2B9.Checked = false; } else if (CurrentLetter[8] == '1') { CH2B9.Checked = true; }
                if (CurrentLetter[9] == '0') { CH2B10.Checked = false; } else if (CurrentLetter[9] == '1') { CH2B10.Checked = true; }
                if (CurrentLetter[10] == '0') { CH2B11.Checked = false; } else if (CurrentLetter[10] == '1') { CH2B11.Checked = true; }
                if (CurrentLetter[11] == '0') { CH2B12.Checked = false; } else if (CurrentLetter[11] == '1') { CH2B12.Checked = true; }
                if (CurrentLetter[12] == '0') { CH2B13.Checked = false; } else if (CurrentLetter[12] == '1') { CH2B13.Checked = true; }
                if (CurrentLetter[13] == '0') { CH2B14.Checked = false; } else if (CurrentLetter[13] == '1') { CH2B14.Checked = true; }
                if (CurrentLetter[14] == '0') { CH2B15.Checked = false; } else if (CurrentLetter[14] == '1') { CH2B15.Checked = true; }
                if (CurrentLetter[15] == '0') { CH2B16.Checked = false; } else if (CurrentLetter[15] == '1') { CH2B16.Checked = true; }
                if (CurrentLetter[16] == '0') { CH2B17.Checked = false; } else if (CurrentLetter[16] == '1') { CH2B17.Checked = true; }
                if (CurrentLetter[17] == '0') { CH2B18.Checked = false; } else if (CurrentLetter[17] == '1') { CH2B18.Checked = true; }
                if (CurrentLetter[18] == '0') { CH2B19.Checked = false; } else if (CurrentLetter[18] == '1') { CH2B19.Checked = true; }
                if (CurrentLetter[19] == '0') { CH2B20.Checked = false; } else if (CurrentLetter[19] == '1') { CH2B20.Checked = true; }
                if (CurrentLetter[20] == '0') { CH2B21.Checked = false; } else if (CurrentLetter[20] == '1') { CH2B21.Checked = true; }
                if (CurrentLetter[21] == '0') { CH2B22.Checked = false; } else if (CurrentLetter[21] == '1') { CH2B22.Checked = true; }
                if (CurrentLetter[22] == '0') { CH2B23.Checked = false; } else if (CurrentLetter[22] == '1') { CH2B23.Checked = true; }
                if (CurrentLetter[23] == '0') { CH2B24.Checked = false; } else if (CurrentLetter[23] == '1') { CH2B24.Checked = true; }
                if (CurrentLetter[24] == '0') { CH2B25.Checked = false; } else if (CurrentLetter[24] == '1') { CH2B25.Checked = true; }
                if (CurrentLetter[25] == '0') { CH2B26.Checked = false; } else if (CurrentLetter[25] == '1') { CH2B26.Checked = true; }
                if (CurrentLetter[26] == '0') { CH2B27.Checked = false; } else if (CurrentLetter[26] == '1') { CH2B27.Checked = true; }
                if (CurrentLetter[27] == '0') { CH2B28.Checked = false; } else if (CurrentLetter[27] == '1') { CH2B28.Checked = true; }
                if (CurrentLetter[28] == '0') { CH2B29.Checked = false; } else if (CurrentLetter[28] == '1') { CH2B29.Checked = true; }
                if (CurrentLetter[29] == '0') { CH2B30.Checked = false; } else if (CurrentLetter[29] == '1') { CH2B30.Checked = true; }
                if (CurrentLetter[30] == '0') { CH2B31.Checked = false; } else if (CurrentLetter[30] == '1') { CH2B31.Checked = true; }
                if (CurrentLetter[31] == '0') { CH2B32.Checked = false; } else if (CurrentLetter[31] == '1') { CH2B32.Checked = true; }
                if (CurrentLetter[32] == '0') { CH2B33.Checked = false; } else if (CurrentLetter[32] == '1') { CH2B33.Checked = true; }
                if (CurrentLetter[33] == '0') { CH2B34.Checked = false; } else if (CurrentLetter[33] == '1') { CH2B34.Checked = true; }
                if (CurrentLetter[34] == '0') { CH2B35.Checked = false; } else if (CurrentLetter[34] == '1') { CH2B35.Checked = true; }
                if (CurrentLetter[35] == '0') { CH2B36.Checked = false; } else if (CurrentLetter[35] == '1') { CH2B36.Checked = true; }
                if (CurrentLetter[36] == '0') { CH2B37.Checked = false; } else if (CurrentLetter[36] == '1') { CH2B37.Checked = true; }
                if (CurrentLetter[37] == '0') { CH2B38.Checked = false; } else if (CurrentLetter[37] == '1') { CH2B38.Checked = true; }
                if (CurrentLetter[38] == '0') { CH2B39.Checked = false; } else if (CurrentLetter[38] == '1') { CH2B39.Checked = true; }
                if (CurrentLetter[39] == '0') { CH2B40.Checked = false; } else if (CurrentLetter[39] == '1') { CH2B40.Checked = true; }
                if (CurrentLetter[40] == '0') { CH2B41.Checked = false; } else if (CurrentLetter[40] == '1') { CH2B41.Checked = true; }
                if (CurrentLetter[41] == '0') { CH2B42.Checked = false; } else if (CurrentLetter[41] == '1') { CH2B42.Checked = true; }

                if (CurrentLetter[42] == '0') { CH3B1.Checked = false; } else if (CurrentLetter[42] == '1') { CH3B1.Checked = true; }
                if (CurrentLetter[43] == '0') { CH3B2.Checked = false; } else if (CurrentLetter[43] == '1') { CH3B2.Checked = true; }
                if (CurrentLetter[44] == '0') { CH3B3.Checked = false; } else if (CurrentLetter[44] == '1') { CH3B3.Checked = true; }
                if (CurrentLetter[45] == '0') { CH3B4.Checked = false; } else if (CurrentLetter[45] == '1') { CH3B4.Checked = true; }
                if (CurrentLetter[46] == '0') { CH3B5.Checked = false; } else if (CurrentLetter[46] == '1') { CH3B5.Checked = true; }
                if (CurrentLetter[47] == '0') { CH3B6.Checked = false; } else if (CurrentLetter[47] == '1') { CH3B6.Checked = true; }
                if (CurrentLetter[48] == '0') { CH3B7.Checked = false; } else if (CurrentLetter[48] == '1') { CH3B7.Checked = true; }
                if (CurrentLetter[49] == '0') { CH3B8.Checked = false; } else if (CurrentLetter[49] == '1') { CH3B8.Checked = true; }
                if (CurrentLetter[50] == '0') { CH3B9.Checked = false; } else if (CurrentLetter[50] == '1') { CH3B9.Checked = true; }
                if (CurrentLetter[51] == '0') { CH3B10.Checked = false; } else if (CurrentLetter[51] == '1') { CH3B10.Checked = true; }
                if (CurrentLetter[52] == '0') { CH3B11.Checked = false; } else if (CurrentLetter[52] == '1') { CH3B11.Checked = true; }
                if (CurrentLetter[53] == '0') { CH3B12.Checked = false; } else if (CurrentLetter[53] == '1') { CH3B12.Checked = true; }
                if (CurrentLetter[54] == '0') { CH3B13.Checked = false; } else if (CurrentLetter[54] == '1') { CH3B13.Checked = true; }
                if (CurrentLetter[55] == '0') { CH3B14.Checked = false; } else if (CurrentLetter[55] == '1') { CH3B14.Checked = true; }
                if (CurrentLetter[56] == '0') { CH3B15.Checked = false; } else if (CurrentLetter[56] == '1') { CH3B15.Checked = true; }
                if (CurrentLetter[57] == '0') { CH3B16.Checked = false; } else if (CurrentLetter[57] == '1') { CH3B16.Checked = true; }
                if (CurrentLetter[58] == '0') { CH3B17.Checked = false; } else if (CurrentLetter[58] == '1') { CH3B17.Checked = true; }
                if (CurrentLetter[59] == '0') { CH3B18.Checked = false; } else if (CurrentLetter[59] == '1') { CH3B18.Checked = true; }
                if (CurrentLetter[60] == '0') { CH3B19.Checked = false; } else if (CurrentLetter[60] == '1') { CH3B19.Checked = true; }
                if (CurrentLetter[61] == '0') { CH3B20.Checked = false; } else if (CurrentLetter[61] == '1') { CH3B20.Checked = true; }
                if (CurrentLetter[62] == '0') { CH3B21.Checked = false; } else if (CurrentLetter[62] == '1') { CH3B21.Checked = true; }
                if (CurrentLetter[63] == '0') { CH3B22.Checked = false; } else if (CurrentLetter[63] == '1') { CH3B22.Checked = true; }
                if (CurrentLetter[64] == '0') { CH3B23.Checked = false; } else if (CurrentLetter[64] == '1') { CH3B23.Checked = true; }
                if (CurrentLetter[65] == '0') { CH3B24.Checked = false; } else if (CurrentLetter[65] == '1') { CH3B24.Checked = true; }
                if (CurrentLetter[66] == '0') { CH3B25.Checked = false; } else if (CurrentLetter[66] == '1') { CH3B25.Checked = true; }
                if (CurrentLetter[67] == '0') { CH3B26.Checked = false; } else if (CurrentLetter[67] == '1') { CH3B26.Checked = true; }
                if (CurrentLetter[68] == '0') { CH3B27.Checked = false; } else if (CurrentLetter[68] == '1') { CH3B27.Checked = true; }
                if (CurrentLetter[69] == '0') { CH3B28.Checked = false; } else if (CurrentLetter[69] == '1') { CH3B28.Checked = true; }
                if (CurrentLetter[70] == '0') { CH3B29.Checked = false; } else if (CurrentLetter[70] == '1') { CH3B29.Checked = true; }
                if (CurrentLetter[71] == '0') { CH3B30.Checked = false; } else if (CurrentLetter[71] == '1') { CH3B30.Checked = true; }
                if (CurrentLetter[72] == '0') { CH3B31.Checked = false; } else if (CurrentLetter[72] == '1') { CH3B31.Checked = true; }
                if (CurrentLetter[73] == '0') { CH3B32.Checked = false; } else if (CurrentLetter[73] == '1') { CH3B32.Checked = true; }
                if (CurrentLetter[74] == '0') { CH3B33.Checked = false; } else if (CurrentLetter[74] == '1') { CH3B33.Checked = true; }
                if (CurrentLetter[75] == '0') { CH3B34.Checked = false; } else if (CurrentLetter[75] == '1') { CH3B34.Checked = true; }
                if (CurrentLetter[76] == '0') { CH3B35.Checked = false; } else if (CurrentLetter[76] == '1') { CH3B35.Checked = true; }
                if (CurrentLetter[77] == '0') { CH3B36.Checked = false; } else if (CurrentLetter[77] == '1') { CH3B36.Checked = true; }
                if (CurrentLetter[78] == '0') { CH3B37.Checked = false; } else if (CurrentLetter[78] == '1') { CH3B37.Checked = true; }
                if (CurrentLetter[79] == '0') { CH3B38.Checked = false; } else if (CurrentLetter[79] == '1') { CH3B38.Checked = true; }
                if (CurrentLetter[80] == '0') { CH3B39.Checked = false; } else if (CurrentLetter[80] == '1') { CH3B39.Checked = true; }
                if (CurrentLetter[81] == '0') { CH3B40.Checked = false; } else if (CurrentLetter[81] == '1') { CH3B40.Checked = true; }
                if (CurrentLetter[82] == '0') { CH3B41.Checked = false; } else if (CurrentLetter[82] == '1') { CH3B41.Checked = true; }
                if (CurrentLetter[83] == '0') { CH3B42.Checked = false; } else if (CurrentLetter[83] == '1') { CH3B42.Checked = true; }

                if (CurrentLetter[84] == '0') { CH4B1.Checked = false; } else if (CurrentLetter[84] == '1') { CH4B1.Checked = true; }
                if (CurrentLetter[85] == '0') { CH4B2.Checked = false; } else if (CurrentLetter[85] == '1') { CH4B2.Checked = true; }
                if (CurrentLetter[86] == '0') { CH4B3.Checked = false; } else if (CurrentLetter[86] == '1') { CH4B3.Checked = true; }
                if (CurrentLetter[87] == '0') { CH4B4.Checked = false; } else if (CurrentLetter[87] == '1') { CH4B4.Checked = true; }
                if (CurrentLetter[88] == '0') { CH4B5.Checked = false; } else if (CurrentLetter[88] == '1') { CH4B5.Checked = true; }
                if (CurrentLetter[89] == '0') { CH4B6.Checked = false; } else if (CurrentLetter[89] == '1') { CH4B6.Checked = true; }
                if (CurrentLetter[90] == '0') { CH4B7.Checked = false; } else if (CurrentLetter[90] == '1') { CH4B7.Checked = true; }
                if (CurrentLetter[91] == '0') { CH4B8.Checked = false; } else if (CurrentLetter[91] == '1') { CH4B8.Checked = true; }
                if (CurrentLetter[92] == '0') { CH4B9.Checked = false; } else if (CurrentLetter[92] == '1') { CH4B9.Checked = true; }
                if (CurrentLetter[93] == '0') { CH4B10.Checked = false; } else if (CurrentLetter[93] == '1') { CH4B10.Checked = true; }
                if (CurrentLetter[94] == '0') { CH4B11.Checked = false; } else if (CurrentLetter[94] == '1') { CH4B11.Checked = true; }
                if (CurrentLetter[95] == '0') { CH4B12.Checked = false; } else if (CurrentLetter[95] == '1') { CH4B12.Checked = true; }
                if (CurrentLetter[96] == '0') { CH4B13.Checked = false; } else if (CurrentLetter[96] == '1') { CH4B13.Checked = true; }
                if (CurrentLetter[97] == '0') { CH4B14.Checked = false; } else if (CurrentLetter[97] == '1') { CH4B14.Checked = true; }
                if (CurrentLetter[98] == '0') { CH4B15.Checked = false; } else if (CurrentLetter[98] == '1') { CH4B15.Checked = true; }
                if (CurrentLetter[99] == '0') { CH4B16.Checked = false; } else if (CurrentLetter[99] == '1') { CH4B16.Checked = true; }
                if (CurrentLetter[100] == '0') { CH4B17.Checked = false; } else if (CurrentLetter[100] == '1') { CH4B17.Checked = true; }
                if (CurrentLetter[101] == '0') { CH4B18.Checked = false; } else if (CurrentLetter[101] == '1') { CH4B18.Checked = true; }
                if (CurrentLetter[102] == '0') { CH4B19.Checked = false; } else if (CurrentLetter[102] == '1') { CH4B19.Checked = true; }
                if (CurrentLetter[103] == '0') { CH4B20.Checked = false; } else if (CurrentLetter[103] == '1') { CH4B20.Checked = true; }
                if (CurrentLetter[104] == '0') { CH4B21.Checked = false; } else if (CurrentLetter[104] == '1') { CH4B21.Checked = true; }
                if (CurrentLetter[105] == '0') { CH4B22.Checked = false; } else if (CurrentLetter[105] == '1') { CH4B22.Checked = true; }
                if (CurrentLetter[106] == '0') { CH4B23.Checked = false; } else if (CurrentLetter[106] == '1') { CH4B23.Checked = true; }
                if (CurrentLetter[107] == '0') { CH4B24.Checked = false; } else if (CurrentLetter[107] == '1') { CH4B24.Checked = true; }
                if (CurrentLetter[108] == '0') { CH4B25.Checked = false; } else if (CurrentLetter[108] == '1') { CH4B25.Checked = true; }
                if (CurrentLetter[109] == '0') { CH4B26.Checked = false; } else if (CurrentLetter[109] == '1') { CH4B26.Checked = true; }
                if (CurrentLetter[110] == '0') { CH4B27.Checked = false; } else if (CurrentLetter[110] == '1') { CH4B27.Checked = true; }
                if (CurrentLetter[111] == '0') { CH4B28.Checked = false; } else if (CurrentLetter[111] == '1') { CH4B28.Checked = true; }
                if (CurrentLetter[112] == '0') { CH4B29.Checked = false; } else if (CurrentLetter[112] == '1') { CH4B29.Checked = true; }
                if (CurrentLetter[113] == '0') { CH4B30.Checked = false; } else if (CurrentLetter[113] == '1') { CH4B30.Checked = true; }
                if (CurrentLetter[114] == '0') { CH4B31.Checked = false; } else if (CurrentLetter[114] == '1') { CH4B31.Checked = true; }
                if (CurrentLetter[115] == '0') { CH4B32.Checked = false; } else if (CurrentLetter[115] == '1') { CH4B32.Checked = true; }
                if (CurrentLetter[116] == '0') { CH4B33.Checked = false; } else if (CurrentLetter[116] == '1') { CH4B33.Checked = true; }
                if (CurrentLetter[117] == '0') { CH4B34.Checked = false; } else if (CurrentLetter[117] == '1') { CH4B34.Checked = true; }
                if (CurrentLetter[118] == '0') { CH4B35.Checked = false; } else if (CurrentLetter[118] == '1') { CH4B35.Checked = true; }
                if (CurrentLetter[119] == '0') { CH4B36.Checked = false; } else if (CurrentLetter[119] == '1') { CH4B36.Checked = true; }
                if (CurrentLetter[120] == '0') { CH4B37.Checked = false; } else if (CurrentLetter[120] == '1') { CH4B37.Checked = true; }
                if (CurrentLetter[121] == '0') { CH4B38.Checked = false; } else if (CurrentLetter[121] == '1') { CH4B38.Checked = true; }
                if (CurrentLetter[122] == '0') { CH4B39.Checked = false; } else if (CurrentLetter[122] == '1') { CH4B39.Checked = true; }
                if (CurrentLetter[123] == '0') { CH4B40.Checked = false; } else if (CurrentLetter[123] == '1') { CH4B40.Checked = true; }
                if (CurrentLetter[124] == '0') { CH4B41.Checked = false; } else if (CurrentLetter[124] == '1') { CH4B41.Checked = true; }
                if (CurrentLetter[125] == '0') { CH4B42.Checked = false; } else if (CurrentLetter[125] == '1') { CH4B42.Checked = true; }

                if (CurrentLetter[126] == '0') { CH5B1.Checked = false; } else if (CurrentLetter[125] == '1') { CH5B1.Checked = true; }
                if (CurrentLetter[127] == '0') { CH5B2.Checked = false; } else if (CurrentLetter[127] == '1') { CH5B2.Checked = true; }
                if (CurrentLetter[128] == '0') { CH5B3.Checked = false; } else if (CurrentLetter[128] == '1') { CH5B3.Checked = true; }
                if (CurrentLetter[129] == '0') { CH5B4.Checked = false; } else if (CurrentLetter[129] == '1') { CH5B4.Checked = true; }
                if (CurrentLetter[130] == '0') { CH5B5.Checked = false; } else if (CurrentLetter[130] == '1') { CH5B5.Checked = true; }
                if (CurrentLetter[131] == '0') { CH5B6.Checked = false; } else if (CurrentLetter[131] == '1') { CH5B6.Checked = true; }
                if (CurrentLetter[132] == '0') { CH5B7.Checked = false; } else if (CurrentLetter[132] == '1') { CH5B7.Checked = true; }
                if (CurrentLetter[133] == '0') { CH5B8.Checked = false; } else if (CurrentLetter[133] == '1') { CH5B8.Checked = true; }
                if (CurrentLetter[134] == '0') { CH5B9.Checked = false; } else if (CurrentLetter[134] == '1') { CH5B9.Checked = true; }
                if (CurrentLetter[135] == '0') { CH5B10.Checked = false; } else if (CurrentLetter[135] == '1') { CH5B10.Checked = true; }
                if (CurrentLetter[136] == '0') { CH5B11.Checked = false; } else if (CurrentLetter[136] == '1') { CH5B11.Checked = true; }
                if (CurrentLetter[137] == '0') { CH5B12.Checked = false; } else if (CurrentLetter[137] == '1') { CH5B12.Checked = true; }
                if (CurrentLetter[138] == '0') { CH5B13.Checked = false; } else if (CurrentLetter[138] == '1') { CH5B13.Checked = true; }
                if (CurrentLetter[139] == '0') { CH5B14.Checked = false; } else if (CurrentLetter[139] == '1') { CH5B14.Checked = true; }
                if (CurrentLetter[140] == '0') { CH5B15.Checked = false; } else if (CurrentLetter[140] == '1') { CH5B15.Checked = true; }
                if (CurrentLetter[141] == '0') { CH5B16.Checked = false; } else if (CurrentLetter[141] == '1') { CH5B16.Checked = true; }
                if (CurrentLetter[142] == '0') { CH5B17.Checked = false; } else if (CurrentLetter[142] == '1') { CH5B17.Checked = true; }
                if (CurrentLetter[143] == '0') { CH5B18.Checked = false; } else if (CurrentLetter[143] == '1') { CH5B18.Checked = true; }
                if (CurrentLetter[144] == '0') { CH5B19.Checked = false; } else if (CurrentLetter[144] == '1') { CH5B19.Checked = true; }
                if (CurrentLetter[145] == '0') { CH5B20.Checked = false; } else if (CurrentLetter[145] == '1') { CH5B20.Checked = true; }
                if (CurrentLetter[146] == '0') { CH5B21.Checked = false; } else if (CurrentLetter[146] == '1') { CH5B21.Checked = true; }
                if (CurrentLetter[147] == '0') { CH5B22.Checked = false; } else if (CurrentLetter[147] == '1') { CH5B22.Checked = true; }
                if (CurrentLetter[148] == '0') { CH5B23.Checked = false; } else if (CurrentLetter[148] == '1') { CH5B23.Checked = true; }
                if (CurrentLetter[149] == '0') { CH5B24.Checked = false; } else if (CurrentLetter[149] == '1') { CH5B24.Checked = true; }
                if (CurrentLetter[150] == '0') { CH5B25.Checked = false; } else if (CurrentLetter[150] == '1') { CH5B25.Checked = true; }
                if (CurrentLetter[151] == '0') { CH5B26.Checked = false; } else if (CurrentLetter[151] == '1') { CH5B26.Checked = true; }
                if (CurrentLetter[152] == '0') { CH5B27.Checked = false; } else if (CurrentLetter[152] == '1') { CH5B27.Checked = true; }
                if (CurrentLetter[153] == '0') { CH5B28.Checked = false; } else if (CurrentLetter[153] == '1') { CH5B28.Checked = true; }
                if (CurrentLetter[154] == '0') { CH5B29.Checked = false; } else if (CurrentLetter[154] == '1') { CH5B29.Checked = true; }
                if (CurrentLetter[155] == '0') { CH5B30.Checked = false; } else if (CurrentLetter[155] == '1') { CH5B30.Checked = true; }
                if (CurrentLetter[156] == '0') { CH5B31.Checked = false; } else if (CurrentLetter[156] == '1') { CH5B31.Checked = true; }
                if (CurrentLetter[157] == '0') { CH5B32.Checked = false; } else if (CurrentLetter[157] == '1') { CH5B32.Checked = true; }
                if (CurrentLetter[158] == '0') { CH5B33.Checked = false; } else if (CurrentLetter[158] == '1') { CH5B33.Checked = true; }
                if (CurrentLetter[159] == '0') { CH5B34.Checked = false; } else if (CurrentLetter[159] == '1') { CH5B34.Checked = true; }
                if (CurrentLetter[160] == '0') { CH5B35.Checked = false; } else if (CurrentLetter[160] == '1') { CH5B35.Checked = true; }
                if (CurrentLetter[161] == '0') { CH5B36.Checked = false; } else if (CurrentLetter[161] == '1') { CH5B36.Checked = true; }
                if (CurrentLetter[162] == '0') { CH5B37.Checked = false; } else if (CurrentLetter[162] == '1') { CH5B37.Checked = true; }
                if (CurrentLetter[163] == '0') { CH5B38.Checked = false; } else if (CurrentLetter[163] == '1') { CH5B38.Checked = true; }
                if (CurrentLetter[164] == '0') { CH5B39.Checked = false; } else if (CurrentLetter[164] == '1') { CH5B39.Checked = true; }
                if (CurrentLetter[165] == '0') { CH5B40.Checked = false; } else if (CurrentLetter[165] == '1') { CH5B40.Checked = true; }
                if (CurrentLetter[166] == '0') { CH5B41.Checked = false; } else if (CurrentLetter[166] == '1') { CH5B41.Checked = true; }
                if (CurrentLetter[167] == '0') { CH5B42.Checked = false; } else if (CurrentLetter[167] == '1') { CH5B42.Checked = true; }

                if (CurrentLetter[168] == '0') { CH6B1.Checked = false; } else if (CurrentLetter[168] == '1') { CH6B1.Checked = true; }
                if (CurrentLetter[169] == '0') { CH6B2.Checked = false; } else if (CurrentLetter[169] == '1') { CH6B2.Checked = true; }
                if (CurrentLetter[170] == '0') { CH6B3.Checked = false; } else if (CurrentLetter[170] == '1') { CH6B3.Checked = true; }
                if (CurrentLetter[171] == '0') { CH6B4.Checked = false; } else if (CurrentLetter[171] == '1') { CH6B4.Checked = true; }
                if (CurrentLetter[172] == '0') { CH6B5.Checked = false; } else if (CurrentLetter[172] == '1') { CH6B5.Checked = true; }
                if (CurrentLetter[173] == '0') { CH6B6.Checked = false; } else if (CurrentLetter[173] == '1') { CH6B6.Checked = true; }
                if (CurrentLetter[174] == '0') { CH6B7.Checked = false; } else if (CurrentLetter[174] == '1') { CH6B7.Checked = true; }
                if (CurrentLetter[175] == '0') { CH6B8.Checked = false; } else if (CurrentLetter[175] == '1') { CH6B8.Checked = true; }
                if (CurrentLetter[176] == '0') { CH6B9.Checked = false; } else if (CurrentLetter[176] == '1') { CH6B9.Checked = true; }
                if (CurrentLetter[177] == '0') { CH6B10.Checked = false; } else if (CurrentLetter[177] == '1') { CH6B10.Checked = true; }
                if (CurrentLetter[178] == '0') { CH6B11.Checked = false; } else if (CurrentLetter[178] == '1') { CH6B11.Checked = true; }
                if (CurrentLetter[179] == '0') { CH6B12.Checked = false; } else if (CurrentLetter[179] == '1') { CH6B12.Checked = true; }
                if (CurrentLetter[180] == '0') { CH6B13.Checked = false; } else if (CurrentLetter[180] == '1') { CH6B13.Checked = true; }
                if (CurrentLetter[181] == '0') { CH6B14.Checked = false; } else if (CurrentLetter[181] == '1') { CH6B14.Checked = true; }
                if (CurrentLetter[182] == '0') { CH6B15.Checked = false; } else if (CurrentLetter[182] == '1') { CH6B15.Checked = true; }
                if (CurrentLetter[183] == '0') { CH6B16.Checked = false; } else if (CurrentLetter[183] == '1') { CH6B16.Checked = true; }
                if (CurrentLetter[184] == '0') { CH6B17.Checked = false; } else if (CurrentLetter[184] == '1') { CH6B17.Checked = true; }
                if (CurrentLetter[185] == '0') { CH6B18.Checked = false; } else if (CurrentLetter[185] == '1') { CH6B18.Checked = true; }
                if (CurrentLetter[186] == '0') { CH6B19.Checked = false; } else if (CurrentLetter[186] == '1') { CH6B19.Checked = true; }
                if (CurrentLetter[187] == '0') { CH6B20.Checked = false; } else if (CurrentLetter[187] == '1') { CH6B20.Checked = true; }
                if (CurrentLetter[188] == '0') { CH6B21.Checked = false; } else if (CurrentLetter[188] == '1') { CH6B21.Checked = true; }
                if (CurrentLetter[189] == '0') { CH6B22.Checked = false; } else if (CurrentLetter[189] == '1') { CH6B22.Checked = true; }
                if (CurrentLetter[190] == '0') { CH6B23.Checked = false; } else if (CurrentLetter[190] == '1') { CH6B23.Checked = true; }
                if (CurrentLetter[191] == '0') { CH6B24.Checked = false; } else if (CurrentLetter[191] == '1') { CH6B24.Checked = true; }
                if (CurrentLetter[192] == '0') { CH6B25.Checked = false; } else if (CurrentLetter[192] == '1') { CH6B25.Checked = true; }
                if (CurrentLetter[193] == '0') { CH6B26.Checked = false; } else if (CurrentLetter[193] == '1') { CH6B26.Checked = true; }
                if (CurrentLetter[194] == '0') { CH6B27.Checked = false; } else if (CurrentLetter[194] == '1') { CH6B27.Checked = true; }
                if (CurrentLetter[195] == '0') { CH6B28.Checked = false; } else if (CurrentLetter[195] == '1') { CH6B28.Checked = true; }
                if (CurrentLetter[196] == '0') { CH6B29.Checked = false; } else if (CurrentLetter[196] == '1') { CH6B29.Checked = true; }
                if (CurrentLetter[197] == '0') { CH6B30.Checked = false; } else if (CurrentLetter[197] == '1') { CH6B30.Checked = true; }
                if (CurrentLetter[198] == '0') { CH6B31.Checked = false; } else if (CurrentLetter[198] == '1') { CH6B31.Checked = true; }
                if (CurrentLetter[199] == '0') { CH6B32.Checked = false; } else if (CurrentLetter[199] == '1') { CH6B32.Checked = true; }
                if (CurrentLetter[200] == '0') { CH6B33.Checked = false; } else if (CurrentLetter[200] == '1') { CH6B33.Checked = true; }
                if (CurrentLetter[201] == '0') { CH6B34.Checked = false; } else if (CurrentLetter[201] == '1') { CH6B34.Checked = true; }
                if (CurrentLetter[202] == '0') { CH6B35.Checked = false; } else if (CurrentLetter[202] == '1') { CH6B35.Checked = true; }
                if (CurrentLetter[203] == '0') { CH6B36.Checked = false; } else if (CurrentLetter[203] == '1') { CH6B36.Checked = true; }
                if (CurrentLetter[204] == '0') { CH6B37.Checked = false; } else if (CurrentLetter[204] == '1') { CH6B37.Checked = true; }
                if (CurrentLetter[205] == '0') { CH6B38.Checked = false; } else if (CurrentLetter[205] == '1') { CH6B38.Checked = true; }
                if (CurrentLetter[206] == '0') { CH6B39.Checked = false; } else if (CurrentLetter[206] == '1') { CH6B39.Checked = true; }
                if (CurrentLetter[207] == '0') { CH6B40.Checked = false; } else if (CurrentLetter[207] == '1') { CH6B40.Checked = true; }
                if (CurrentLetter[208] == '0') { CH6B41.Checked = false; } else if (CurrentLetter[208] == '1') { CH6B41.Checked = true; }
                if (CurrentLetter[209] == '0') { CH6B42.Checked = false; } else if (CurrentLetter[209] == '1') { CH6B42.Checked = true; }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void coToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewHelp f2 = new ViewHelp();
            f2.ShowDialog();

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs f3 = new ContactUs();
            f3.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}