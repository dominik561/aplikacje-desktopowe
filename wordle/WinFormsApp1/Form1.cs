using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> _words;
        string _secretWord;
        TextBox[,] _textBoxTable;

        int _indexI;
        int _indexJ;
        public Form1()
        {
            InitializeComponent();
            _textBoxTable = new TextBox[6, 6];

            _indexI = 0;
            _indexJ = 0;

            Start();
        }



        void ReadWords()
        {
            try
            {
                var lines = File.ReadAllLines("slowa.txt");
                _words = lines.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie mo¿na odczytaæ danych z pliku.");
            }
        }

        private void Start()
        {
            ReadWords();
            GenerateRandomWord();
        }

        private void CompareWords(string secretWord, string userWord)
        {
            if (secretWord.ToUpper() == userWord.ToUpper())
            {
                MessageBox.Show("Wygra³eœ!");
            }

            char[] secretChars = secretWord.ToUpper().ToCharArray();
            char[] userChars = userWord.ToUpper().ToCharArray();

            for (int i = 0; i < userChars.Length; i++)
            {
                char userChar = userChars[i];
                char secretChar = secretChars[i];
                
                if(userChar == secretChar)
                {
                    _textBoxTable[_indexI, i].BackColor = Color.Green;
                }
                else if (secretChars.Contains(userChar))
                {
                    _textBoxTable[_indexI, i].BackColor = Color.Yellow;
                }
            }
        }

        private void GenerateRandomWord()
        {
            var rand = new Random();
            int index = rand.Next(0, _words.Count);
            _secretWord = _words[index];
        }

        private void FillTextBox(char sign)
        {
            if(_indexJ > 4)
            {
                return;
            }

            if(_indexI > 4)
            {
                return;
            }

            var textBox = _textBoxTable[_indexI, _indexJ];
            textBox.Text = sign.ToString();

            _indexJ++;
        }

        private void EndGame()
        {
            MessageBox.Show("Koniec gry!");
        }

        private void FillTextboxTable()
        {
            _textBoxTable[0, 0] = textBox11;
            _textBoxTable[1, 0] = textBox12;
            _textBoxTable[2, 0] = textBox13;
            _textBoxTable[3, 0] = textBox14;
            _textBoxTable[4, 0] = textBox15;
            _textBoxTable[0, 1] = textBox21;
            _textBoxTable[1, 1] = textBox22;
            _textBoxTable[2, 1] = textBox23;
            _textBoxTable[3, 1] = textBox24;
            _textBoxTable[4, 1] = textBox25;
            _textBoxTable[0, 2] = textBox31;
            _textBoxTable[1, 2] = textBox32;
            _textBoxTable[2, 2] = textBox33;
            _textBoxTable[3, 2] = textBox34;
            _textBoxTable[4, 2] = textBox35;
            _textBoxTable[0, 3] = textBox41;
            _textBoxTable[1, 3] = textBox42;
            _textBoxTable[2, 3] = textBox43;
            _textBoxTable[3, 3] = textBox44;
            _textBoxTable[4, 3] = textBox45;
            _textBoxTable[0, 4] = textBox51;
            _textBoxTable[1, 4] = textBox52;
            _textBoxTable[2, 4] = textBox53;
            _textBoxTable[3, 4] = textBox54;
            _textBoxTable[4, 4] = textBox55;
            _textBoxTable[0, 5] = textBox61;
            _textBoxTable[1, 5] = textBox62;
            _textBoxTable[2, 5] = textBox63;
            _textBoxTable[3, 5] = textBox64;
            _textBoxTable[4, 5] = textBox65;
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            FillTextBox('q');
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            FillTextBox('w');
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            FillTextBox('e');
        }
        private void buttonR_Click(object sender, EventArgs e)
        {
            FillTextBox('r');
        }
        private void buttonT_Click(object sender, EventArgs e)
        {
            FillTextBox('t');
        }
        private void buttonY_Click(object sender, EventArgs e)
        {
            FillTextBox('y');
        }
        private void buttonU_Click(object sender, EventArgs e)
        {
            FillTextBox('u');
        }
        private void buttonI_Click(object sender, EventArgs e)
        {
            FillTextBox('i');
        }
        private void buttonO_Click(object sender, EventArgs e)
        {
            FillTextBox('o');
        }
        private void buttonP_Click(object sender, EventArgs e)
        {
            FillTextBox('p');
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            FillTextBox('a');
        }
        private void buttonS_Click(object sender, EventArgs e)
        {
            FillTextBox('s');
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            FillTextBox('d');
        }
        private void buttonF_Click(object sender, EventArgs e)
        {
            FillTextBox('f');
        }
        private void buttonG_Click(object sender, EventArgs e)
        {
            FillTextBox('g');
        }
        private void buttonH_Click(object sender, EventArgs e)
        {
            FillTextBox('h');
        }
        private void buttonJ_Click(object sender, EventArgs e)
        {
            FillTextBox('j');
        }
        private void buttonK_Click(object sender, EventArgs e)
        {
            FillTextBox('k');
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            FillTextBox('l');
        }
        private void buttonZ_Click(object sender, EventArgs e)
        {
            FillTextBox('z');
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            FillTextBox('x');
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            FillTextBox('c');
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            FillTextBox('v');
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            FillTextBox('b');
        }
        private void buttonN_Click(object sender, EventArgs e)
        {
            FillTextBox('n');
        }
        private void buttonM_Click(object sender, EventArgs e)
        {
            FillTextBox('m');
        }

        private void buttonAA_Click(object sender, EventArgs e)
        {
            FillTextBox('¹');
        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            FillTextBox('æ');
        }

        private void buttonEE_Click(object sender, EventArgs e)
        {
            FillTextBox('ê');
        }

        private void buttonOO_Click(object sender, EventArgs e)
        {
            FillTextBox('ó');
        }

        private void buttonNN_Click(object sender, EventArgs e)
        {
            FillTextBox('ñ');
        }

        private void buttonZZ_Click(object sender, EventArgs e)
        {
            FillTextBox('¿');
        }

        private void buttonZZZ_Click(object sender, EventArgs e)
        {
            FillTextBox('Ÿ');
        }

        private void buttonLL_Click(object sender, EventArgs e)
        {
            FillTextBox('³');
        }

        private void buttonSS_Click(object sender, EventArgs e)
        {
            FillTextBox('œ');
        }
        private void buttonENTER_click(object sender, EventArgs e)
        {
            if(_indexJ != 5)
            {
                MessageBox.Show("Za malo liter");
            }

            string userWord = GetuserWord();

            CompareWords(_secretWord, userWord);

            _indexI++;
            _indexJ = 0;

            if(_indexI > 4)
            {
                EndGame();
            }
        }

        private string GetuserWord()
        {
            string userWord = "";

            for (int j = 0; j < 5; j++)
            {
                string letter = _textBoxTable[_indexI, j].Text;
                userWord += letter;
            }
            return userWord;
        }

        private void buttonBS_click(object sender, EventArgs e)
        {
            if (_indexJ == 0)
            {
                return;
            }
            _textBoxTable[_indexI, _indexJ - 1].Text = "";
            _indexJ--;
        }
    }
}
