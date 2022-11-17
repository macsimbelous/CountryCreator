using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ImageMagick;

namespace CountryCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void party_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox1.Enabled = true;
                this.popularity_textBox1.Enabled = true;
                this.adj_textBox1.Enabled = true;
                this.loc_name_gov_textBox1.Enabled = true;
                this.flag_1_button.Enabled = true;
            }
            else
            {
                this.party_textBox1.Enabled = false;
                this.popularity_textBox1.Enabled = false;
                this.adj_textBox1.Enabled = false;
                this.loc_name_gov_textBox1.Enabled = false;
                this.flag_1_button.Enabled = false;
            }
        }

        private void party_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox2.Enabled = true;
                this.popularity_textBox2.Enabled = true;
                this.adj_textBox2.Enabled = true;
                this.loc_name_gov_textBox2.Enabled = true;
                this.flag_2_button.Enabled = true;
            }
            else
            {
                this.party_textBox2.Enabled = false;
                this.popularity_textBox2.Enabled = false;
                this.adj_textBox2.Enabled = false;
                this.loc_name_gov_textBox2.Enabled = false;
                this.flag_2_button.Enabled = false;
            }
        }

        private void party_checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox3.Enabled = true;
                this.popularity_textBox3.Enabled = true;
                this.adj_textBox3.Enabled = true;
                this.loc_name_gov_textBox3.Enabled = true;
                this.flag_3_button.Enabled = true;
            }
            else
            {
                this.party_textBox3.Enabled = false;
                this.popularity_textBox3.Enabled = false;
                this.adj_textBox3.Enabled = false;
                this.loc_name_gov_textBox3.Enabled = false;
                this.flag_3_button.Enabled = false;
            }
        }

        private void party_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox4.Enabled = true;
                this.popularity_textBox4.Enabled = true;
                this.adj_textBox4.Enabled = true;
                this.loc_name_gov_textBox4.Enabled = true;
                this.flag_4_button.Enabled = true;
            }
            else
            {
                this.party_textBox4.Enabled = false;
                this.popularity_textBox4.Enabled = false;
                this.adj_textBox4.Enabled = false;
                this.loc_name_gov_textBox4.Enabled = false;
                this.flag_4_button.Enabled = false;
            }
        }

        private void party_checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox5.Enabled = true;
                this.popularity_textBox5.Enabled = true;
                this.adj_textBox5.Enabled = true;
                this.loc_name_gov_textBox5.Enabled = true;
                this.flag_5_button.Enabled = true;
            }
            else
            {
                this.party_textBox5.Enabled = false;
                this.popularity_textBox5.Enabled = false;
                this.adj_textBox5.Enabled = false;
                this.loc_name_gov_textBox5.Enabled = false;
                this.flag_5_button.Enabled = false;
            }
        }

        private void party_checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox6.Enabled = true;
                this.popularity_textBox6.Enabled = true;
                this.adj_textBox6.Enabled = true;
                this.loc_name_gov_textBox6.Enabled = true;
                this.flag_6_button.Enabled = true;
            }
            else
            {
                this.party_textBox6.Enabled = false;
                this.popularity_textBox6.Enabled = false;
                this.adj_textBox6.Enabled = false;
                this.loc_name_gov_textBox6.Enabled = false;
                this.flag_6_button.Enabled = false;
            }
        }

        private void party_checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox7.Enabled = true;
                this.popularity_textBox7.Enabled = true;
                this.adj_textBox7.Enabled = true;
                this.loc_name_gov_textBox7.Enabled = true;
                this.flag_7_button.Enabled = true;
            }
            else
            {
                this.party_textBox7.Enabled = false;
                this.popularity_textBox7.Enabled = false;
                this.adj_textBox7.Enabled = false;
                this.loc_name_gov_textBox7.Enabled = false;
                this.flag_7_button.Enabled = false;
            }
        }

        private void party_checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox8.Enabled = true;
                this.popularity_textBox8.Enabled = true;
                this.adj_textBox8.Enabled = true;
                this.loc_name_gov_textBox8.Enabled = true;
                this.flag_8_button.Enabled = true;
            }
            else
            {
                this.party_textBox8.Enabled = false;
                this.popularity_textBox8.Enabled = false;
                this.adj_textBox8.Enabled = false;
                this.loc_name_gov_textBox8.Enabled = false;
                this.flag_8_button.Enabled = false;
            }
        }

        private void party_checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox9.Enabled = true;
                this.popularity_textBox9.Enabled = true;
                this.adj_textBox9.Enabled = true;
                this.loc_name_gov_textBox9.Enabled = true;
                this.flag_9_button.Enabled = true;
            }
            else
            {
                this.party_textBox9.Enabled = false;
                this.popularity_textBox9.Enabled = false;
                this.adj_textBox9.Enabled = false;
                this.loc_name_gov_textBox9.Enabled = false;
                this.flag_9_button.Enabled = false;
            }
        }

        private void party_checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                this.party_textBox10.Enabled = true;
                this.popularity_textBox10.Enabled = true;
                this.adj_textBox10.Enabled = true;
                this.loc_name_gov_textBox10.Enabled = true;
                this.flag_10_button.Enabled = true;
            }
            else
            {
                this.party_textBox10.Enabled = false;
                this.popularity_textBox10.Enabled = false;
                this.adj_textBox10.Enabled = false;
                this.loc_name_gov_textBox10.Enabled = false;
                this.flag_10_button.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisablePartyBox();

            this.tag_textBox.Text = Properties.Settings.Default.Tag;
            this.name_textBox.Text = Properties.Settings.Default.Name;
            this.oob_textBox.Text = Properties.Settings.Default.OOB;
            this.capital_textBox.Text = Properties.Settings.Default.Capital.ToString();
            this.rule_party_textBox.Text = Properties.Settings.Default.RulingParty;
            this.research_slots_textBox.Text = Properties.Settings.Default.ResearchSlots.ToString();
            this.start_pp_textBox.Text = Properties.Settings.Default.PolitPower.ToString();
            this.stability_textBox.Text = Properties.Settings.Default.Stability.ToString();
            this.war_suport_textBox.Text = Properties.Settings.Default.WarSupport.ToString();
            this.convoys_textBox.Text = Properties.Settings.Default.Convoys.ToString();
            this.option_textBox.Text = Properties.Settings.Default.Option;
            this.path_to_mod_textBox.Text = Properties.Settings.Default.PathToMod;
            if (Properties.Settings.Default.GenerateFlag)
            {
                this.generate_flag_radioButton.Checked = true;
            }
            else
            {
                this.select_flag_radioButton.Checked = true;
            }

            this.party_checkBox1.Checked = Properties.Settings.Default.Party1;
            this.party_textBox1.Text = Properties.Settings.Default.Party1_name;
            this.popularity_textBox1.Text = Properties.Settings.Default.Party1_popularity.ToString();
            this.adj_textBox1.Text = Properties.Settings.Default.Party1_adj;
            this.loc_name_gov_textBox1.Text = Properties.Settings.Default.Party1_loc_name_gov;

            this.party_checkBox2.Checked = Properties.Settings.Default.Party2;
            this.party_textBox2.Text = Properties.Settings.Default.Party2_name;
            this.popularity_textBox2.Text = Properties.Settings.Default.Party2_popularity.ToString();
            this.adj_textBox2.Text = Properties.Settings.Default.Party2_adj;
            this.loc_name_gov_textBox2.Text = Properties.Settings.Default.Party2_loc_name_gov;

            this.party_checkBox3.Checked = Properties.Settings.Default.Party3;
            this.party_textBox3.Text = Properties.Settings.Default.Party3_name;
            this.popularity_textBox3.Text = Properties.Settings.Default.Party3_popularity.ToString();
            this.adj_textBox3.Text = Properties.Settings.Default.Party3_adj;
            this.loc_name_gov_textBox3.Text = Properties.Settings.Default.Party3_loc_name_gov;

            this.party_checkBox4.Checked = Properties.Settings.Default.Party4;
            this.party_textBox4.Text = Properties.Settings.Default.Party4_name;
            this.popularity_textBox4.Text = Properties.Settings.Default.Party4_popularity.ToString();
            this.adj_textBox4.Text = Properties.Settings.Default.Party4_adj;
            this.loc_name_gov_textBox4.Text = Properties.Settings.Default.Party4_loc_name_gov;

            this.party_checkBox5.Checked = Properties.Settings.Default.Party5;
            this.party_textBox5.Text = Properties.Settings.Default.Party5_name;
            this.popularity_textBox5.Text = Properties.Settings.Default.Party5_popularity.ToString();
            this.adj_textBox5.Text = Properties.Settings.Default.Party5_adj;
            this.loc_name_gov_textBox5.Text = Properties.Settings.Default.Party5_loc_name_gov;

            this.party_checkBox6.Checked = Properties.Settings.Default.Party6;
            this.party_textBox6.Text = Properties.Settings.Default.Party6_name;
            this.popularity_textBox6.Text = Properties.Settings.Default.Party6_popularity.ToString();
            this.adj_textBox6.Text = Properties.Settings.Default.Party6_adj;
            this.loc_name_gov_textBox6.Text = Properties.Settings.Default.Party6_loc_name_gov;

            this.party_checkBox7.Checked = Properties.Settings.Default.Party7;
            this.party_textBox7.Text = Properties.Settings.Default.Party7_name;
            this.popularity_textBox7.Text = Properties.Settings.Default.Party7_popularity.ToString();
            this.adj_textBox7.Text = Properties.Settings.Default.Party7_adj;
            this.loc_name_gov_textBox7.Text = Properties.Settings.Default.Party7_loc_name_gov;

            this.party_checkBox8.Checked = Properties.Settings.Default.Party8;
            this.party_textBox8.Text = Properties.Settings.Default.Party8_name;
            this.popularity_textBox8.Text = Properties.Settings.Default.Party8_popularity.ToString();
            this.adj_textBox8.Text = Properties.Settings.Default.Party8_adj;
            this.loc_name_gov_textBox8.Text = Properties.Settings.Default.Party8_loc_name_gov;

            this.party_checkBox9.Checked = Properties.Settings.Default.Party9;
            this.party_textBox9.Text = Properties.Settings.Default.Party9_name;
            this.popularity_textBox9.Text = Properties.Settings.Default.Party9_popularity.ToString();
            this.adj_textBox9.Text = Properties.Settings.Default.Party9_adj;
            this.loc_name_gov_textBox9.Text = Properties.Settings.Default.Party9_loc_name_gov;

            this.party_checkBox10.Checked = Properties.Settings.Default.Party10;
            this.party_textBox10.Text = Properties.Settings.Default.Party10_name;
            this.popularity_textBox10.Text = Properties.Settings.Default.Party10_popularity.ToString();
            this.adj_textBox10.Text = Properties.Settings.Default.Party10_adj;
            this.loc_name_gov_textBox10.Text = Properties.Settings.Default.Party10_loc_name_gov;

            this.flag_1_button.Enabled = false;
            this.flag_2_button.Enabled = false;
            this.flag_3_button.Enabled = false;
            this.flag_4_button.Enabled = false;
            this.flag_5_button.Enabled = false;
            this.flag_6_button.Enabled = false;
            this.flag_7_button.Enabled = false;
            this.flag_8_button.Enabled = false;
            this.flag_9_button.Enabled = false;
            this.flag_10_button.Enabled = false;
            if (this.select_flag_radioButton.Checked)
            {
                if (this.party_checkBox1.Checked)
                {
                    this.flag_1_button.Enabled = true;
                }
                if (this.party_checkBox2.Checked)
                {
                    this.flag_2_button.Enabled = true;
                }
                if (this.party_checkBox3.Checked)
                {
                    this.flag_3_button.Enabled = true;
                }
                if (this.party_checkBox4.Checked)
                {
                    this.flag_4_button.Enabled = true;
                }
                if (this.party_checkBox5.Checked)
                {
                    this.flag_5_button.Enabled = true;
                }
                if (this.party_checkBox6.Checked)
                {
                    this.flag_6_button.Enabled = true;
                }
                if (this.party_checkBox7.Checked)
                {
                    this.flag_7_button.Enabled = true;
                }
                if (this.party_checkBox8.Checked)
                {
                    this.flag_8_button.Enabled = true;
                }
                if (this.party_checkBox9.Checked)
                {
                    this.flag_9_button.Enabled = true;
                }
                if (this.party_checkBox10.Checked)
                {
                    this.flag_10_button.Enabled = true;
                }
            }
            Random rg = new Random();
            Color color = Color.FromArgb(rg.Next(0, 255), rg.Next(0, 255), rg.Next(0, 255));
            this.color_panel.BackColor = color;
            this.color_ui_panel.BackColor = color;
        }
        private void DisablePartyBox()
        {
            this.party_textBox1.Enabled = false;
            this.popularity_textBox1.Enabled = false;
            this.adj_textBox1.Enabled = false;
            this.loc_name_gov_textBox1.Enabled = false;

            this.party_textBox2.Enabled = false;
            this.popularity_textBox2.Enabled = false;
            this.adj_textBox2.Enabled = false;
            this.loc_name_gov_textBox2.Enabled = false;

            this.party_textBox3.Enabled = false;
            this.popularity_textBox3.Enabled = false;
            this.adj_textBox3.Enabled = false;
            this.loc_name_gov_textBox3.Enabled = false;

            this.party_textBox4.Enabled = false;
            this.popularity_textBox4.Enabled = false;
            this.adj_textBox4.Enabled = false;
            this.loc_name_gov_textBox4.Enabled = false;

            this.party_textBox5.Enabled = false;
            this.popularity_textBox5.Enabled = false;
            this.adj_textBox5.Enabled = false;
            this.loc_name_gov_textBox5.Enabled = false;

            this.party_textBox6.Enabled = false;
            this.popularity_textBox6.Enabled = false;
            this.adj_textBox6.Enabled = false;
            this.loc_name_gov_textBox6.Enabled = false;

            this.party_textBox7.Enabled = false;
            this.popularity_textBox7.Enabled = false;
            this.adj_textBox7.Enabled = false;
            this.loc_name_gov_textBox7.Enabled = false;

            this.party_textBox8.Enabled = false;
            this.popularity_textBox8.Enabled = false;
            this.adj_textBox8.Enabled = false;
            this.loc_name_gov_textBox8.Enabled = false;

            this.party_textBox9.Enabled = false;
            this.popularity_textBox9.Enabled = false;
            this.adj_textBox9.Enabled = false;
            this.loc_name_gov_textBox9.Enabled = false;

            this.party_textBox10.Enabled = false;
            this.popularity_textBox10.Enabled = false;
            this.adj_textBox10.Enabled = false;
            this.loc_name_gov_textBox10.Enabled = false;
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.color_panel.BackColor;
            this.colorDialog1.FullOpen = true;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.color_panel.BackColor = this.colorDialog1.Color;
                this.color_ui_panel.BackColor = this.colorDialog1.Color;
            }
        }

        private void random_color_button_Click(object sender, EventArgs e)
        {
            Random rg = new Random();
            Color color = Color.FromArgb(rg.Next(0, 255), rg.Next(0, 255), rg.Next(0, 255));
            this.color_panel.BackColor = color;
            this.color_ui_panel.BackColor = color;
        }

        private void random_color_ui_button_Click(object sender, EventArgs e)
        {
            Random rg = new Random();
            Color color = Color.FromArgb(rg.Next(0, 255), rg.Next(0, 255), rg.Next(0, 255));
            this.color_ui_panel.BackColor = color;
        }

        private void color_ui_button_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.color_ui_panel.BackColor;
            this.colorDialog1.FullOpen = true;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.color_ui_panel.BackColor = this.colorDialog1.Color;
            }
        }

        private void path_to_mod_button_Click(object sender, EventArgs e)
        {
            if(this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.path_to_mod_textBox.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Tag = this.tag_textBox.Text;
            Properties.Settings.Default.Name = this.name_textBox.Text;
            Properties.Settings.Default.OOB = this.oob_textBox.Text;
            Properties.Settings.Default.Capital = int.Parse(this.capital_textBox.Text);
            Properties.Settings.Default.RulingParty = this.rule_party_textBox.Text;
            Properties.Settings.Default.ResearchSlots = int.Parse(this.research_slots_textBox.Text);
            Properties.Settings.Default.PolitPower = int.Parse(this.start_pp_textBox.Text);
            Properties.Settings.Default.Stability = float.Parse(this.stability_textBox.Text);
            Properties.Settings.Default.WarSupport = float.Parse(this.war_suport_textBox.Text);
            Properties.Settings.Default.Convoys = int.Parse(this.convoys_textBox.Text);
            Properties.Settings.Default.Option = this.option_textBox.Text;
            Properties.Settings.Default.PathToMod = this.path_to_mod_textBox.Text;
            Properties.Settings.Default.GenerateFlag = this.generate_flag_radioButton.Checked;

            Properties.Settings.Default.Party1 = this.party_checkBox1.Checked;
            Properties.Settings.Default.Party1_name = this.party_textBox1.Text;
            Properties.Settings.Default.Party1_popularity = int.Parse(this.popularity_textBox1.Text);
            Properties.Settings.Default.Party1_adj = this.adj_textBox1.Text;
            Properties.Settings.Default.Party1_loc_name_gov = this.loc_name_gov_textBox1.Text;

            Properties.Settings.Default.Party2 = this.party_checkBox2.Checked;
            Properties.Settings.Default.Party2_name = this.party_textBox2.Text;
            Properties.Settings.Default.Party2_popularity = int.Parse(this.popularity_textBox2.Text);
            Properties.Settings.Default.Party2_adj = this.adj_textBox2.Text;
            Properties.Settings.Default.Party2_loc_name_gov = this.loc_name_gov_textBox2.Text;

            Properties.Settings.Default.Party3 = this.party_checkBox3.Checked;
            Properties.Settings.Default.Party3_name = this.party_textBox3.Text;
            Properties.Settings.Default.Party3_popularity = int.Parse(this.popularity_textBox3.Text);
            Properties.Settings.Default.Party3_adj = this.adj_textBox3.Text;
            Properties.Settings.Default.Party3_loc_name_gov = this.loc_name_gov_textBox3.Text;

            Properties.Settings.Default.Party4 = this.party_checkBox4.Checked;
            Properties.Settings.Default.Party4_name = this.party_textBox4.Text;
            Properties.Settings.Default.Party4_popularity = int.Parse(this.popularity_textBox4.Text);
            Properties.Settings.Default.Party4_adj = this.adj_textBox4.Text;
            Properties.Settings.Default.Party4_loc_name_gov = this.loc_name_gov_textBox4.Text;

            Properties.Settings.Default.Party5 = this.party_checkBox5.Checked;
            Properties.Settings.Default.Party5_name = this.party_textBox5.Text;
            Properties.Settings.Default.Party5_popularity = int.Parse(this.popularity_textBox5.Text);
            Properties.Settings.Default.Party5_adj = this.adj_textBox5.Text;
            Properties.Settings.Default.Party5_loc_name_gov = this.loc_name_gov_textBox5.Text;

            Properties.Settings.Default.Party6 = this.party_checkBox6.Checked;
            Properties.Settings.Default.Party6_name = this.party_textBox6.Text;
            Properties.Settings.Default.Party6_popularity = int.Parse(this.popularity_textBox6.Text);
            Properties.Settings.Default.Party6_adj = this.adj_textBox6.Text;
            Properties.Settings.Default.Party6_loc_name_gov = this.loc_name_gov_textBox6.Text;

            Properties.Settings.Default.Party7 = this.party_checkBox7.Checked;
            Properties.Settings.Default.Party7_name = this.party_textBox7.Text;
            Properties.Settings.Default.Party7_popularity = int.Parse(this.popularity_textBox7.Text);
            Properties.Settings.Default.Party7_adj = this.adj_textBox7.Text;
            Properties.Settings.Default.Party7_loc_name_gov = this.loc_name_gov_textBox7.Text;

            Properties.Settings.Default.Party8 = this.party_checkBox8.Checked;
            Properties.Settings.Default.Party8_name = this.party_textBox8.Text;
            Properties.Settings.Default.Party8_popularity = int.Parse(this.popularity_textBox8.Text);
            Properties.Settings.Default.Party8_adj = this.adj_textBox8.Text;
            Properties.Settings.Default.Party8_loc_name_gov = this.loc_name_gov_textBox8.Text;

            Properties.Settings.Default.Party9 = this.party_checkBox9.Checked;
            Properties.Settings.Default.Party9_name = this.party_textBox9.Text;
            Properties.Settings.Default.Party9_popularity = int.Parse(this.popularity_textBox9.Text);
            Properties.Settings.Default.Party9_adj = this.adj_textBox9.Text;
            Properties.Settings.Default.Party9_loc_name_gov = this.loc_name_gov_textBox9.Text;

            Properties.Settings.Default.Party10 = this.party_checkBox10.Checked;
            Properties.Settings.Default.Party10_name = this.party_textBox10.Text;
            Properties.Settings.Default.Party10_popularity = int.Parse(this.popularity_textBox10.Text);
            Properties.Settings.Default.Party10_adj = this.adj_textBox10.Text;
            Properties.Settings.Default.Party10_loc_name_gov = this.loc_name_gov_textBox10.Text;

            Properties.Settings.Default.Save();
        }

        private void tag_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //string path = this.path_to_mod_textBox.Text + "\\history\\countries\\" + this.tag_textBox.Text + " - " + this.name_textBox.Text + ".txt";
                string[] files = Directory.GetFiles(this.path_to_mod_textBox.Text + "\\history\\countries", this.tag_textBox.Text + "*.txt");
                //if (File.Exists(path))
                if (files.Length > 0)
                {
                    this.create_button.BackColor = Color.Red;
                }
                else
                {
                    this.create_button.BackColor = Color.Green;
                }
            }
            catch(DirectoryNotFoundException)
            {
                this.create_button.BackColor = Color.Red;
            }
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            //Проверяем
            if (!Directory.Exists(this.path_to_mod_textBox.Text))
            {
                MessageBox.Show("Не указан каталог мода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.tag_textBox.Text))
            {
                MessageBox.Show("Не указан тег!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.name_textBox.Text))
            {
                MessageBox.Show("Не указано название!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.oob_textBox.Text))
            {
                MessageBox.Show("Не указан OOB!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.capital_textBox.Text))
            {
                MessageBox.Show("Не указана столица!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.rule_party_textBox.Text))
            {
                MessageBox.Show("Не указана правящая партия!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.research_slots_textBox.Text))
            {
                MessageBox.Show("Не указано количество ячеек для исследований!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.start_pp_textBox.Text))
            {
                MessageBox.Show("Не указана стартовая политическая власть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.stability_textBox.Text))
            {
                MessageBox.Show("Не указана стартовая стабильность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.war_suport_textBox.Text))
            {
                MessageBox.Show("Не указана стартовая поддержка войны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(this.convoys_textBox.Text))
            {
                MessageBox.Show("Не указана стартовое количество конвоев!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!(party_checkBox1.Checked || party_checkBox2.Checked || party_checkBox3.Checked || party_checkBox4.Checked || party_checkBox5.Checked || party_checkBox6.Checked || party_checkBox7.Checked || party_checkBox8.Checked || party_checkBox9.Checked || party_checkBox10.Checked))
            {
                MessageBox.Show("Не указать хотябы одну идеологию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Directory.Exists(this.path_to_mod_textBox.Text + "\\history\\countries"))
            {
                string[] files = Directory.GetFiles(this.path_to_mod_textBox.Text + "\\history\\countries\\", this.tag_textBox.Text + "*.txt");
                if (files.Length > 0)
                {
                    MessageBox.Show("Страна с таким тегом уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int pp_count = 0;
            if (this.party_checkBox1.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox1.Text);
                if (String.IsNullOrEmpty(this.flag_1_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_1_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox2.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox2.Text);
                if (String.IsNullOrEmpty(this.flag_2_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_2_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox3.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox3.Text);
                if (String.IsNullOrEmpty(this.flag_3_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_3_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox4.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox4.Text);
                if (String.IsNullOrEmpty(this.flag_4_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_4_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox5.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox5.Text);
                if (String.IsNullOrEmpty(this.flag_5_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_5_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox6.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox6.Text);
                if (String.IsNullOrEmpty(this.flag_6_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_6_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox7.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox7.Text);
                if (String.IsNullOrEmpty(this.flag_7_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_7_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox8.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox8.Text);
                if (String.IsNullOrEmpty(this.flag_8_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_8_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox9.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox9.Text);
                if (String.IsNullOrEmpty(this.flag_9_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_9_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (this.party_checkBox10.Checked)
            {
                pp_count = pp_count + int.Parse(this.popularity_textBox10.Text);
                if (String.IsNullOrEmpty(this.flag_10_pictureBox.ImageLocation))
                {
                    MessageBox.Show("Не выбран флаг для " + this.flag_10_label.Text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(pp_count > 100)
            {
                MessageBox.Show("Суммарная популярность идеологий не должна превышать 100%!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Создаём
            Directory.CreateDirectory(this.path_to_mod_textBox.Text + "\\history\\countries");
            using (StreamWriter fs = new StreamWriter(this.path_to_mod_textBox.Text + "\\history\\countries\\" + this.tag_textBox.Text + " - " + this.name_textBox.Text + ".txt", false, new UTF8Encoding(false)))
            {
                fs.WriteLine($"capital = {this.capital_textBox.Text}");
                fs.WriteLine("set_technology = {");
                fs.WriteLine("	infantry_weapons = 1");
                fs.WriteLine("}");
                fs.WriteLine($"set_convoys = {this.convoys_textBox.Text}");
                fs.WriteLine($"add_political_power = {this.start_pp_textBox.Text}");
                fs.WriteLine($"set_research_slots = {this.research_slots_textBox.Text}");
                fs.WriteLine($"set_stability = {this.stability_textBox.Text}");
                fs.WriteLine($"set_war_support = {this.war_suport_textBox.Text}");
                fs.WriteLine($"set_oob = \"{this.oob_textBox.Text}\"");
                fs.WriteLine("set_politics = {");
                fs.WriteLine($"	ruling_party = {this.rule_party_textBox.Text}");
                fs.WriteLine("	last_election = \"1936.1.1\"");
                fs.WriteLine("	election_frequency = 48");
                fs.WriteLine("	elections_allowed = yes");
                fs.WriteLine("}");
                fs.WriteLine("set_popularities = {");
                if (this.party_checkBox1.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox1.Text} = {this.popularity_textBox1.Text}");
                }
                if (this.party_checkBox2.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox2.Text} = {this.popularity_textBox2.Text}");
                }
                if (this.party_checkBox3.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox3.Text} = {this.popularity_textBox3.Text}");
                }
                if (this.party_checkBox4.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox4.Text} = {this.popularity_textBox4.Text}");
                }
                if (this.party_checkBox5.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox5.Text} = {this.popularity_textBox5.Text}");
                }
                if (this.party_checkBox6.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox6.Text} = {this.popularity_textBox6.Text}");
                }
                if (this.party_checkBox7.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox7.Text} = {this.popularity_textBox7.Text}");
                }
                if (this.party_checkBox8.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox8.Text} = {this.popularity_textBox8.Text}");
                }
                if (this.party_checkBox9.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox9.Text} = {this.popularity_textBox9.Text}");
                }
                if (this.party_checkBox10.Checked)
                {
                    fs.WriteLine($"\t{this.party_textBox10.Text} = {this.popularity_textBox10.Text}");
                }
                fs.WriteLine("}");
                fs.WriteLine(this.option_textBox.Text);
                fs.Close();
            }
            Directory.CreateDirectory(this.path_to_mod_textBox.Text + "\\common\\country_tags");
            using (StreamWriter fs = new StreamWriter(this.path_to_mod_textBox.Text + "\\common\\country_tags\\00_countries.txt", true, new UTF8Encoding(false)))
            {
                fs.WriteLine($"{this.tag_textBox.Text} = \"countries/{this.name_textBox.Text}.txt\"");
                fs.Close();
            }
            Directory.CreateDirectory(this.path_to_mod_textBox.Text + "\\common\\countries");
            using (StreamWriter fs = new StreamWriter(this.path_to_mod_textBox.Text + "\\common\\countries\\" + this.name_textBox.Text + ".txt", false, new UTF8Encoding(false)))
            {
               fs.WriteLine("graphical_culture = western_european_gfx");
               fs.WriteLine("graphical_culture_2d = western_european_2d");
               fs.WriteLine($"color = {{{this.color_panel.BackColor.R}  {this.color_panel.BackColor.G}  {this.color_panel.BackColor.B}}}");
               fs.Close();
            }
            Directory.CreateDirectory(this.path_to_mod_textBox.Text + "\\common\\countries");
            using (StreamWriter fs = new StreamWriter(this.path_to_mod_textBox.Text + "\\common\\countries\\colors.txt", true, new UTF8Encoding(false)))
            {
                fs.WriteLine($"{this.tag_textBox.Text} = {{");
                fs.WriteLine($"color = rgb {{ {this.color_panel.BackColor.R}  {this.color_panel.BackColor.G}  {this.color_panel.BackColor.B} }}");
                fs.WriteLine($"color_ui = rgb {{ {this.color_ui_panel.BackColor.R}  {this.color_ui_panel.BackColor.G}  {this.color_ui_panel.BackColor.B} }}");
                fs.WriteLine("}");
                fs.Close();
            }
            Directory.CreateDirectory(this.path_to_mod_textBox.Text + "\\localisation");
            using (StreamWriter fs = new StreamWriter(this.path_to_mod_textBox.Text + "\\localisation\\countries_l_russian.txt", true, new UTF8Encoding(true)))
            {
                if(fs.BaseStream.Length == 0)
                {
                    fs.WriteLine("l_russian:");
                }
                if (this.party_checkBox1.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox1.Text}:0 \"{this.loc_name_gov_textBox1.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox1.Text}_DEF:0 \"{this.loc_name_gov_textBox1.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox1.Text}_ADJ:0 \"{this.adj_textBox1.Text}\"");
                }
                if (this.party_checkBox2.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox2.Text}:0 \"{this.loc_name_gov_textBox2.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox2.Text}_DEF:0 \"{this.loc_name_gov_textBox2.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox2.Text}_ADJ:0 \"{this.adj_textBox2.Text}\"");
                }
                if (this.party_checkBox3.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox3.Text}:0 \"{this.loc_name_gov_textBox3.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox3.Text}_DEF:0 \"{this.loc_name_gov_textBox3.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox3.Text}_ADJ:0 \"{this.adj_textBox3.Text}\"");
                }
                if (this.party_checkBox4.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox4.Text}:0 \"{this.loc_name_gov_textBox4.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox4.Text}_DEF:0 \"{this.loc_name_gov_textBox4.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox4.Text}_ADJ:0 \"{this.adj_textBox4.Text}\"");
                }
                if (this.party_checkBox5.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox5.Text}:0 \"{this.loc_name_gov_textBox5.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox5.Text}_DEF:0 \"{this.loc_name_gov_textBox5.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox5.Text}_ADJ:0 \"{this.adj_textBox5.Text}\"");
                }
                if (this.party_checkBox6.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox6.Text}:0 \"{this.loc_name_gov_textBox6.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox6.Text}_DEF:0 \"{this.loc_name_gov_textBox6.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox6.Text}_ADJ:0 \"{this.adj_textBox6.Text}\"");
                }
                if (this.party_checkBox7.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox7.Text}:0 \"{this.loc_name_gov_textBox7.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox7.Text}_DEF:0 \"{this.loc_name_gov_textBox7.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox7.Text}_ADJ:0 \"{this.adj_textBox7.Text}\"");
                }
                if (this.party_checkBox8.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox8.Text}:0 \"{this.loc_name_gov_textBox8.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox8.Text}_DEF:0 \"{this.loc_name_gov_textBox8.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox8.Text}_ADJ:0 \"{this.adj_textBox8.Text}\"");
                }
                if (this.party_checkBox9.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox9.Text}:0 \"{this.loc_name_gov_textBox9.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox9.Text}_DEF:0 \"{this.loc_name_gov_textBox9.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox9.Text}_ADJ:0 \"{this.adj_textBox9.Text}\"");
                }
                if (this.party_checkBox10.Checked)
                {
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox10.Text}:0 \"{this.loc_name_gov_textBox10.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox10.Text}_DEF:0 \"{this.loc_name_gov_textBox10.Text}\"");
                    fs.WriteLine($" {this.tag_textBox.Text}_{this.party_textBox10.Text}_ADJ:0 \"{this.adj_textBox10.Text}\"");
                }
                fs.Close();
            }
            if (this.generate_flag_radioButton.Checked)
            {
                GenFlagsFromColor(this.tag_textBox.Text);
            }
            else
            {
                GenFlagsFromImages(this.tag_textBox.Text);
            }
            MessageBox.Show("Всё окей!");
        }
        private void GenFlagsFromColor(string Tag)
        {
            var mf = new MagickFactory();
            MagickImage communism = new MagickImage(mf.Image.Create(Properties.Resources.communism));
            MagickImage democratic = new MagickImage(mf.Image.Create(Properties.Resources.democratic));
            MagickImage fascism = new MagickImage(mf.Image.Create(Properties.Resources.fascism));
            MagickImage neutrality = new MagickImage(mf.Image.Create(Properties.Resources.neutrality));
            //MagickImage communism = new MagickImage("communism.png");
            //MagickImage democratic = new MagickImage("democratic.png");
            //MagickImage fascism = new MagickImage("fascism.png");
            //MagickImage neutrality = new MagickImage("neutrality.png");
            string gfx_path = this.path_to_mod_textBox.Text + "\\gfx";
            Directory.CreateDirectory(gfx_path + "\\flags\\medium");
            Directory.CreateDirectory(gfx_path + "\\flags\\small");
            var m_size = new MagickGeometry(41, 26);
            m_size.IgnoreAspectRatio = true;
            var s_size = new MagickGeometry(10, 7);
            s_size.IgnoreAspectRatio = true;
            ColorRGB fon_color = new ColorRGB(this.color_panel.BackColor.R, this.color_panel.BackColor.G, this.color_panel.BackColor.B);
            MagickImage fon = new MagickImage(fon_color.ToMagickColor(), 82, 52);
                using (var flag_communism = new MagickImageCollection())
                {
                    // Add the first image

                    flag_communism.Add(fon.Clone());

                    // Add the second image

                    flag_communism.Add(communism.Clone());


                    using (var result = flag_communism.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        //result.Flip();
                        // Save the result
                        result.Write(gfx_path + "\\flags\\" + this.tag_textBox.Text + "_communism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\medium\\" + this.tag_textBox.Text + "_communism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\small\\" + this.tag_textBox.Text + "_communism.tga");
                    }

                }
                using (var flag_democratic = new MagickImageCollection())
                {
                    // Add the first image

                    flag_democratic.Add(fon.Clone());

                    // Add the second image

                    flag_democratic.Add(democratic.Clone());


                    using (var result = flag_democratic.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "\\flags\\" + this.tag_textBox.Text + "_democratic.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\medium\\" + this.tag_textBox.Text + "_democratic.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\small\\" + this.tag_textBox.Text + "_democratic.tga");
                    }

                }
                using (var flag_fascism = new MagickImageCollection())
                {

                    // Add the first image

                    flag_fascism.Add(fon.Clone());

                    // Add the second image

                    flag_fascism.Add(fascism.Clone());


                    using (var result = flag_fascism.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "\\flags\\" + this.tag_textBox.Text + "_fascism.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\medium\\" + this.tag_textBox.Text + "_fascism.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\small\\" + this.tag_textBox.Text + "_fascism.tga");
                    }

                }
                using (var flag_neutrality = new MagickImageCollection())
                {
                    // Add the first image

                    flag_neutrality.Add(fon.Clone());

                    // Add the second image

                    flag_neutrality.Add(neutrality.Clone());


                    using (var result = flag_neutrality.Mosaic())
                    {
                        result.Flip();
                        result.Orientation = OrientationType.BottomLeft;
                        // Save the result
                        result.Write(gfx_path + "\\flags\\" + this.tag_textBox.Text + "_neutrality.tga");
                        result.Resize(m_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\medium\\" + this.tag_textBox.Text + "_neutrality.tga");
                        result.Resize(s_size);
                        // Save the result
                        result.Write(gfx_path + "\\flags\\small\\" + this.tag_textBox.Text + "_neutrality.tga");
                    }

                }
        }
        private void GenFlagsFromImages(string Tag)
        {
            var mf = new MagickFactory();
            string flags_path = this.path_to_mod_textBox.Text + "\\gfx\\flags";
            string flags_medium_path = this.path_to_mod_textBox.Text + "\\gfx\\flags\\medium";
            string flags_small_path = this.path_to_mod_textBox.Text + "\\gfx\\flags\\small";
            Directory.CreateDirectory(flags_medium_path);
            Directory.CreateDirectory(flags_small_path);
            var f_size = new MagickGeometry(82, 52);
            f_size.IgnoreAspectRatio = true;
            var m_size = new MagickGeometry(41, 26);
            m_size.IgnoreAspectRatio = true;
            var s_size = new MagickGeometry(10, 7);
            s_size.IgnoreAspectRatio = true;
            if (this.party_checkBox1.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_1_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox1.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox1.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox1.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox2.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_2_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox2.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox2.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox2.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox3.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_3_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox3.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox3.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox3.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox4.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_4_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox4.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox4.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox4.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox5.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_5_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox5.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox5.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox5.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox6.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_6_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox6.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox6.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox6.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox7.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_7_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox7.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox7.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox7.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox8.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_8_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox8.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox8.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox8.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox9.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_9_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox9.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox9.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox9.Text + ".tga");
                    }
                }
            }
            if (this.party_checkBox10.Checked)
            {
                using (MagickImage source = new MagickImage(this.flag_10_pictureBox.ImageLocation))
                {
                    source.Alpha(AlphaOption.On);
                    using (MagickImage f_flag = new MagickImage(source.Clone()))
                    {
                        f_flag.Resize(f_size);
                        f_flag.Write(flags_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox10.Text + ".tga");
                    }
                    using (MagickImage m_flag = new MagickImage(source.Clone()))
                    {
                        m_flag.Resize(m_size);
                        m_flag.Write(flags_medium_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox10.Text + ".tga");
                    }
                    using (MagickImage s_flag = new MagickImage(source.Clone()))
                    {
                        s_flag.Resize(s_size);
                        s_flag.Write(flags_small_path + "\\" + this.tag_textBox.Text + "_" + this.party_textBox10.Text + ".tga");
                    }
                }
            }
        }

        private void flag_1_button_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_1_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_2_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_2_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_3_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_3_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_4_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_4_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_5_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_5_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_6_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_6_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_7_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_7_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_8_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_8_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_9_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_9_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void flag_10_button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.flag_10_pictureBox.ImageLocation = this.openFileDialog1.FileName;
            }
        }

        private void party_textBox1_TextChanged(object sender, EventArgs e)
        {
            this.flag_1_label.Text = this.party_textBox1.Text;
        }

        private void party_textBox2_TextChanged(object sender, EventArgs e)
        {
            this.flag_2_label.Text = this.party_textBox2.Text;
        }

        private void party_textBox3_TextChanged(object sender, EventArgs e)
        {
            this.flag_3_label.Text = this.party_textBox3.Text;
        }

        private void party_textBox4_TextChanged(object sender, EventArgs e)
        {
            this.flag_4_label.Text = this.party_textBox4.Text;
        }

        private void party_textBox5_TextChanged(object sender, EventArgs e)
        {
            this.flag_5_label.Text = this.party_textBox5.Text;
        }

        private void party_textBox6_TextChanged(object sender, EventArgs e)
        {
            this.flag_6_label.Text = this.party_textBox6.Text;
        }

        private void party_textBox7_TextChanged(object sender, EventArgs e)
        {
            this.flag_7_label.Text = this.party_textBox7.Text;
        }

        private void party_textBox8_TextChanged(object sender, EventArgs e)
        {
            this.flag_8_label.Text = this.party_textBox8.Text;
        }

        private void party_textBox9_TextChanged(object sender, EventArgs e)
        {
            this.flag_9_label.Text = this.party_textBox9.Text;
        }

        private void party_textBox10_TextChanged(object sender, EventArgs e)
        {
            this.flag_10_label.Text = this.party_textBox10.Text;
        }

        private void select_flag_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.select_flag_radioButton.Checked)
            {
                if (this.party_checkBox1.Checked)
                {
                    this.flag_1_button.Enabled = true;
                }
                if (this.party_checkBox2.Checked)
                {
                    this.flag_2_button.Enabled = true;
                }
                if (this.party_checkBox3.Checked)
                {
                    this.flag_3_button.Enabled = true;
                }
                if (this.party_checkBox4.Checked)
                {
                    this.flag_4_button.Enabled = true;
                }
                if (this.party_checkBox5.Checked)
                {
                    this.flag_5_button.Enabled = true;
                }
                if (this.party_checkBox6.Checked)
                {
                    this.flag_6_button.Enabled = true;
                }
                if (this.party_checkBox7.Checked)
                {
                    this.flag_7_button.Enabled = true;
                }
                if (this.party_checkBox8.Checked)
                {
                    this.flag_8_button.Enabled = true;
                }
                if (this.party_checkBox9.Checked)
                {
                    this.flag_9_button.Enabled = true;
                }
                if (this.party_checkBox10.Checked)
                {
                    this.flag_10_button.Enabled = true;
                }
            }
            else
            {
                this.flag_1_button.Enabled = false;
                this.flag_2_button.Enabled = false;
                this.flag_3_button.Enabled = false;
                this.flag_4_button.Enabled = false;
                this.flag_5_button.Enabled = false;
                this.flag_6_button.Enabled = false;
                this.flag_7_button.Enabled = false;
                this.flag_8_button.Enabled = false;
                this.flag_9_button.Enabled = false;
                this.flag_10_button.Enabled = false;
            }
        }

        private void capital_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void research_slots_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void start_pp_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stability_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void war_suport_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void convoys_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void popularity_textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
