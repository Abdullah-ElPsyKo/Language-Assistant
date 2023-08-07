using project;

namespace GUI_langA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Parent = panel2;
            mainBody.Parent = panel2;
            panel1.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e) //title
        {

        }

        private void button2_Click(object sender, EventArgs e) //list
        {
            mainBody.Visible = false;
            panel1.Visible = true;
            textBox5.Text = "";
            FileClass fileClass = new FileClass();
            string fileTranslated = Path.Combine(FileClass.path, fileClass.Translated);
            string fileToTranslate = Path.Combine(FileClass.path, fileClass.ToTranslate);
            var listToTranslate = fileClass.ReadListFromFile(fileToTranslate);
            var listTranslated = fileClass.ReadListFromFile(fileTranslated);

            for (int i = 0; i < listToTranslate.Count; i++)
            {
                textBox5.Text += $"{listToTranslate[i],-30}{listTranslated[i]}{Environment.NewLine}{Environment.NewLine}";
            }
        }

        private void label1_Click_1(object sender, EventArgs e) //menu title
        {

        }

        private void button1_Click(object sender, EventArgs e) //translateBtn
        {
            mainBody.Visible = true;
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) //sidepanel
        {

        }

        private void mainBody_Paint(object sender, PaintEventArgs e) //mainbody
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e) //toppanel
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) //titlepanel
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            textBox1.Text = "";
            textBox2.Text = "";
            error.Visible = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.Text == "Pick a language" || toolStripComboBox1.Text == "Pick a language" || toolStripComboBox2.Text == "" || toolStripComboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                error.Text = "Error could not save.";
                error.Visible = true;
                return;
            }
            error.Visible = false;
            FileClass fileClass = new FileClass();
            string fileTranslated = Path.Combine(FileClass.path, fileClass.Translated);
            string fileToTranslate = Path.Combine(FileClass.path, fileClass.ToTranslate);
            // Save translations
            fileClass.AddDataFile($"{textBox2.Text} ({from_lang})", fileToTranslate);
            fileClass.AddDataFile($"{textBox1.Text} ({to_lang})", fileTranslated);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Pick a language";
            toolStripComboBox2.Text = "Pick a language";
            error.Visible = false;
        }
        // Global variables to prevent user from saving translations in wrong languages
        private string from_lang = "";
        private string to_lang = "";
        private async void confirm_Click(object sender, EventArgs e)
        {
            string toTranslate = textBox2.Text;
            string from_language = toolStripComboBox1.Text;
            string to_language = toolStripComboBox2.Text;
            if (toTranslate == "")
            {
                error.Text = "Please enter a valid text to translate. The input text should not be empty.";
                error.Visible = true;
                return;
            }
            if (from_language == "Pick a language" || to_language == "Pick a language" || from_language == "" || to_language == "")
            {
                error.Text = "Please choose valid languages for translation.";
                error.Visible = true;
                return;
            }
            error.Visible = false;
            // get the correct language code ex: English (en) <--- "en" needed for translator
            from_lang = from_language.Substring(from_language.Length - 3, 2);
            to_lang = to_language.Substring(to_language.Length - 3, 2);
            // Await for translation
            string translatedData = await Translator.Translate(toTranslate, from_lang, to_lang);
            // Display translation
            textBox1.Text = translatedData;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void clipboard_Click(object sender, EventArgs e)
        {
            string clipboard_text = GetClipContent.ClipboardText();
            textBox2.Text = clipboard_text;
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void error_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2title_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            FileClass fileClass = new FileClass();
            fileClass.removeData(removeTranslation.Text);
            removeTranslation.Text = "";
            button2_Click(sender, e);
        }

        private void removeTranslation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}