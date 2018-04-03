using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace exampleMenu
{

    public partial class keyboard : Form
    {
        private string[] textFile;
        private Color activeColor = Color.Yellow;
        private Color inactiveColor = SystemColors.Control;
        private Boolean addTime = true;
        private string txtTarget;
        private string txtDisp;
        private int correct = 0;
        private int wrong = 0;
        private double tries = 0;
        private double accuracy = 0;
        private int time;

        public keyboard(int currentLevel)
        {
            InitializeComponent();
            textFile = System.IO.File.ReadAllLines("TextFile.txt");


            switch (currentLevel)
            {
                case 1:
                    time = 300;
                    try
                    {
                        richTextBox1.Text = textFile[0];
                    }
                    catch
                    {
                        MessageBox.Show(textFile.Length.ToString(), "Error Testing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    time = 200;
                    try
                    {
                        richTextBox1.Text = textFile[1];
                    }
                    catch
                    {
                        MessageBox.Show(textFile.Length.ToString(), "Error Testing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    time = 100;
                    try
                    {
                        richTextBox1.Text = textFile[2];
                    }
                    catch
                    {
                        MessageBox.Show(textFile.Length.ToString(), "Error Testing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void keyboard_Load(object sender, EventArgs e)
        {
            //panelKeyboard.Visible = true;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                buttonCapsLock.BackColor = activeColor;
            }
            txtTarget = richTextBox1.Text;
        }

        private void keyboard_KeyDown(object sender, KeyEventArgs e)
        {
            key_down(e);
            CheckKey(e);
        }

        private void keyboard_KeyUp(object sender, KeyEventArgs e)
        {
            key_up(e);
        }

        private void key_down(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonQ);
                    break;
                case Keys.W:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonW);
                    break;
                case Keys.E:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonE);
                    break;
                case Keys.R:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonR);
                    break;
                case Keys.T:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonT);
                    break;
                case Keys.Y:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonY);
                    break;
                case Keys.U:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonU);
                    break;
                case Keys.I:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonI);
                    break;
                case Keys.O:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonO);
                    break;
                case Keys.P:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonP);
                    break;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.A:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonA);
                    break;
                case Keys.S:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonS);
                    break;
                case Keys.D:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonD);
                    break;
                case Keys.F:
                    buttons_active(buttonF);
                    if (e.Alt)
                    {
                        AdditionalTime();
                        buttons_inactive(buttonF);
                        buttons_inactive(buttonAlt1);
                        buttons_inactive(buttonAlt2);
                        tries--;
                        break;
                    }
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    break;
                case Keys.G:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonG);
                    break;
                case Keys.H:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonH);
                    break;
                case Keys.J:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonJ);
                    break;
                case Keys.K:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonK);
                    break;
                case Keys.L:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonL);
                    break;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Z:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonZ);
                    break;
                case Keys.X:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonX);
                    break;
                case Keys.C:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonC);
                    break;
                case Keys.V:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonV);
                    break;
                case Keys.B:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonB);
                    break;
                case Keys.N:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonN);
                    break;
                case Keys.M:
                    if (e.Shift)
                    {
                        keywithshift(e);
                    }
                    else
                    {
                        keywithoutshift(e);
                    }
                    buttons_active(buttonM);
                    break;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Return:
                    buttons_active(buttonEnter);
                    EndGame();
                    break;
                case Keys.Back:
                    buttons_active(buttonBackspace);
                    if (!(displayMsg.Text == ""))
                    {
                        displayMsg.Text = displayMsg.Text.Remove(displayMsg.Text.Length - 1, 1);

                    }
                    else
                    {
                        if (tries != 0)
                        {
                            tries--;
                        }
                    }
                    break;
                case Keys.Space:
                    buttons_active(buttonSpace);
                    displayMsg.Text += " ";
                    break;
                case Keys.Capital:
                    if (Control.IsKeyLocked(Keys.CapsLock))
                    {
                        buttons_active(buttonCapsLock);
                    }
                    else
                    {
                        buttons_inactive(buttonCapsLock);
                    }
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
                case Keys.Menu:
                    buttons_active(buttonAlt1);
                    buttons_active(buttonAlt2);
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
                case Keys.ControlKey:
                    buttons_active(buttonCtrl1);
                    buttons_active(buttonCtrl2);
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
                case Keys.Tab:
                    buttons_active(buttonTab);
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
                case Keys.ShiftKey:
                    buttons_active(buttonShift1);
                    buttons_active(buttonShift2);
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.D1:
                    if (e.Shift)
                    {
                        SpecialCharacter("!");
                    }
                    else
                    {
                        SpecialCharacter("1");
                    }
                    buttons_active(button1);
                    break;
                case Keys.D2:
                    if (e.Shift)
                    {
                        SpecialCharacter("@");
                    }
                    else
                    {
                        SpecialCharacter("2");
                    }
                    buttons_active(button2);
                    break;
                case Keys.D3:
                    if (e.Shift)
                    {
                        SpecialCharacter("#");
                    }
                    else
                    {
                        SpecialCharacter("3");
                    }
                    buttons_active(button3);
                    break;
                case Keys.D4:
                    if (e.Shift)
                    {
                        SpecialCharacter("$");
                    }
                    else
                    {
                        SpecialCharacter("4");
                    }
                    buttons_active(button4);
                    break;
                case Keys.D5:
                    if (e.Shift)
                    {
                        SpecialCharacter("%");
                    }
                    else
                    {
                        SpecialCharacter("5");
                    }
                    buttons_active(button5);
                    break;
                case Keys.D6:
                    if (e.Shift)
                    {
                        SpecialCharacter("^");
                    }
                    else
                    {
                        SpecialCharacter("6");
                    }
                    buttons_active(button6);
                    break;
                case Keys.D7:
                    if (e.Shift)
                    {
                        SpecialCharacter("&");
                    }
                    else
                    {
                        SpecialCharacter("7");
                    }
                    buttons_active(button7);
                    break;
                case Keys.D8:
                    if (e.Shift)
                    {
                        SpecialCharacter("*");
                    }
                    else
                    {
                        SpecialCharacter("8");
                    }
                    buttons_active(button8);
                    break;
                case Keys.D9:
                    if (e.Shift)
                    {
                        SpecialCharacter("(");
                    }
                    else
                    {
                        SpecialCharacter("9");
                    }
                    buttons_active(button9);
                    break;
                case Keys.D0:
                    if (e.Shift)
                    {
                        SpecialCharacter(")");
                    }
                    else
                    {
                        SpecialCharacter("0");
                    }
                    buttons_active(button0);
                    break;
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Oemtilde:
                    if (e.Shift)
                    {
                        SpecialCharacter("~");
                    }
                    else
                    {
                        SpecialCharacter("`");
                    }
                    buttons_active(buttonU1);
                    break;
                case Keys.OemMinus:
                    if (e.Shift)
                    {
                        SpecialCharacter("_");
                    }
                    else
                    {
                        SpecialCharacter("-");
                    }
                    buttons_active(buttonU2);
                    break;
                case Keys.Oemplus:
                    if (e.Shift)
                    {
                        SpecialCharacter("+");
                    }
                    else
                    {
                        SpecialCharacter("=");
                    }
                    buttons_active(buttonU3);
                    break;
                case Keys.OemOpenBrackets:
                    if (e.Shift)
                    {
                        SpecialCharacter("{");
                    }
                    else
                    {
                        SpecialCharacter("[");
                    }
                    buttons_active(buttonU4);
                    break;
                case Keys.Oem6:
                    if (e.Shift)
                    {
                        SpecialCharacter("}");
                    }
                    else
                    {
                        SpecialCharacter("]");
                    }
                    buttons_active(buttonU5);
                    break;
                case Keys.Oem5:
                    if (e.Shift)
                    {
                        SpecialCharacter("|");
                    }
                    else
                    {
                        SpecialCharacter("\\");
                    }
                    buttons_active(buttonU6);
                    break;
                case Keys.Oem1:
                    if (e.Shift)
                    {
                        SpecialCharacter(":");
                    }
                    else
                    {
                        SpecialCharacter(";");
                    }
                    buttons_active(buttonU7);
                    break;
                case Keys.Oem7:
                    if (e.Shift)
                    {
                        SpecialCharacter("\"");
                    }
                    else
                    {
                        SpecialCharacter("'");
                    }
                    buttons_active(buttonU8);
                    break;
                case Keys.Oemcomma:
                    if (e.Shift)
                    {
                        SpecialCharacter("<");
                    }
                    else
                    {
                        SpecialCharacter(",");
                    }
                    buttons_active(buttonU9);
                    break;
                case Keys.OemPeriod:
                    if (e.Shift)
                    {
                        SpecialCharacter(">");
                    }
                    else
                    {
                        SpecialCharacter(".");
                    }
                    buttons_active(buttonU10);
                    break;
                case Keys.OemQuestion:
                    if (e.Shift)
                    {
                        SpecialCharacter("?");
                    }
                    else
                    {
                        SpecialCharacter("/");
                    }
                    buttons_active(buttonU11);
                    break;
                default:
                    if (tries != 0)
                    {
                        tries--;
                    }
                    break;
            }
            tries++;
        }

        private void key_up(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    buttons_inactive(buttonQ);
                    break;
                case Keys.W:
                    buttons_inactive(buttonW);
                    break;
                case Keys.E:
                    buttons_inactive(buttonE);
                    break;
                case Keys.R:
                    buttons_inactive(buttonR);
                    break;
                case Keys.T:
                    buttons_inactive(buttonT);
                    break;
                case Keys.Y:
                    buttons_inactive(buttonY);
                    break;
                case Keys.U:
                    buttons_inactive(buttonU);
                    break;
                case Keys.I:
                    buttons_inactive(buttonI);
                    break;
                case Keys.O:
                    buttons_inactive(buttonO);
                    break;
                case Keys.P:
                    buttons_inactive(buttonP);
                    break;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.A:
                    buttons_inactive(buttonA);
                    break;
                case Keys.S:
                    buttons_inactive(buttonS);
                    break;
                case Keys.D:
                    buttons_inactive(buttonD);
                    break;
                case Keys.F:
                    buttons_inactive(buttonF);
                    break;
                case Keys.G:
                    buttons_inactive(buttonG);
                    break;
                case Keys.H:
                    buttons_inactive(buttonH);
                    break;
                case Keys.J:
                    buttons_inactive(buttonJ);
                    break;
                case Keys.K:
                    buttons_inactive(buttonK);
                    break;
                case Keys.L:
                    buttons_inactive(buttonL);
                    break;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Z:
                    buttons_inactive(buttonZ);
                    break;
                case Keys.X:
                    buttons_inactive(buttonX);
                    break;
                case Keys.C:
                    buttons_inactive(buttonC);
                    break;
                case Keys.V:
                    buttons_inactive(buttonV);
                    break;
                case Keys.B:
                    buttons_inactive(buttonB);
                    break;
                case Keys.N:
                    buttons_inactive(buttonN);
                    break;
                case Keys.M:
                    buttons_inactive(buttonM);
                    break;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Return:
                    buttons_inactive(buttonEnter);
                    break;
                case Keys.Back:
                    buttons_inactive(buttonBackspace);
                    break;
                case Keys.Space:
                    buttons_inactive(buttonSpace);
                    break;
                case Keys.Menu:
                    buttons_inactive(buttonAlt1);
                    buttons_inactive(buttonAlt2);
                    break;
                case Keys.ControlKey:
                    buttons_inactive(buttonCtrl1);
                    buttons_inactive(buttonCtrl2);
                    break;
                case Keys.Tab:
                    buttons_inactive(buttonTab);
                    break;
                case Keys.ShiftKey:
                    buttons_inactive(buttonShift1);
                    buttons_inactive(buttonShift2);
                    break;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.D1:
                    buttons_inactive(button1);
                    break;
                case Keys.D2:
                    buttons_inactive(button2);
                    break;
                case Keys.D3:
                    buttons_inactive(button3);
                    break;
                case Keys.D4:
                    buttons_inactive(button4);
                    break;
                case Keys.D5:
                    buttons_inactive(button5);
                    break;
                case Keys.D6:
                    buttons_inactive(button6);
                    break;
                case Keys.D7:
                    buttons_inactive(button7);
                    break;
                case Keys.D8:
                    buttons_inactive(button8);
                    break;
                case Keys.D9:
                    buttons_inactive(button9);
                    break;
                case Keys.D0:
                    buttons_inactive(button0);
                    break;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case Keys.Oemtilde:
                    buttons_inactive(buttonU1);
                    break;
                case Keys.OemMinus:
                    buttons_inactive(buttonU2);
                    break;
                case Keys.Oemplus:
                    buttons_inactive(buttonU3);
                    break;
                case Keys.OemOpenBrackets:
                    buttons_inactive(buttonU4);
                    break;
                case Keys.Oem6:
                    buttons_inactive(buttonU5);
                    break;
                case Keys.Oem5:
                    buttons_inactive(buttonU6);
                    break;
                case Keys.Oem1:
                    buttons_inactive(buttonU7);
                    break;
                case Keys.Oem7:
                    buttons_inactive(buttonU8);
                    break;
                case Keys.Oemcomma:
                    buttons_inactive(buttonU9);
                    break;
                case Keys.OemPeriod:
                    buttons_inactive(buttonU10);
                    break;
                case Keys.OemQuestion:
                    buttons_inactive(buttonU11);
                    break;
            }

        }

        private void keywithshift(KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                displayMsg.Text += e.KeyCode.ToString().ToLower();
            }
            else
            {
                displayMsg.Text += e.KeyCode.ToString();
                if (tries == 1)
                {
                    tries--;
                }
            }
        }

        private void keywithoutshift(KeyEventArgs e)
        {
            if (!e.Shift)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {

                    displayMsg.Text += e.KeyCode.ToString();
                    if (tries == 1)
                    {
                        tries--;
                    }
                }
                else
                {
                    displayMsg.Text += e.KeyCode.ToString().ToLower();
                }
            }

        }

        private void SpecialCharacter(string character)
        {
            displayMsg.Text += character;
        }

        private void buttons_active(Button button)
        {
            SoundPlayer sndplayr = new SoundPlayer(exampleMenu.Properties.Resources.keysound);
            sndplayr.Play();
            button.BackColor = activeColor;
        }

        private void buttons_inactive(Button button)
        {
            button.BackColor = Color.MediumSeaGreen;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = Color.Red;
        }

        private void AdditionalTime()
        {
            if (addTime == true)
            {
                time = time + 15;
                MessageBox.Show("Additonal Time 15 secs.\nCan be used ONCE!", "PowerUp (Add Time)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (addTime == false)
            {
                MessageBox.Show("PowerUp used before !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            addTime = false;
            StatusTimePowerUp(addTime);
        }

        private void StatusTimePowerUp(Boolean status)
        {
            if (status == true)
            {
                disableDisplayTxt.Visible = false;
                enableDisplayTxt.Visible = true;
            }
            else
            {
                disableDisplayTxt.Visible = true;
                enableDisplayTxt.Visible = false;
            }

        }

        public void CheckKey(KeyEventArgs e)
        {
            //richTextBox1.Text is txtTarget which is the RichTextBox to display the text that is provided by the program for users to type.

            txtDisp = displayMsg.Text; //displayMsg.Text is the TextBox to display the text that is typed by user.
            if (displayMsg.Text != "") //if the displayMsg.Text is not empty then..
            {
                if (e.KeyCode != Keys.Back) //if there is not any backspace key is typed.
                {
                    if (displayMsg.Text.Length <= richTextBox1.Text.Length) //if the displayMsg.Text is less than the richTextBox1.Text
                    {
                        richTextBox1.Select(txtDisp.Length - 1, 1); //select the particular alphabet 
                        if (txtTarget[txtDisp.Length - 1] == txtDisp[txtDisp.Length - 1]) //if the txtTarget(the particular letter) is equals to the txtDisp(letter typed by user) by using pointers to check 
                        {
                            if (richTextBox1.SelectionBackColor != Color.Green) //if the particular letter in richTextBox1 is not green then,
                            {
                                richTextBox1.SelectionBackColor = Color.Green; //switches the backColor to green.
                                richTextBox1.SelectionColor = Color.White; //switches the color to white
                                correct++; //increase correct by one.
                            }
                        }
                        else //if the TxtTarget(the particular letter) is NOT equals to the txtDisp(letter typed by user)
                        {
                            richTextBox1.SelectionBackColor = Color.Red; //switches the particular letter's backColor to Red.
                            richTextBox1.SelectionColor = Color.White; //switches the color to White.
                            wrong++; //increase wrong by one.

                        }
                    }
                }
                else //if there is backspace key is typed
                {
                    if (displayMsg.Text.Length >= richTextBox1.Text.Length) //if the lenght of displayMsg.Text is more than the length of richTextBox1.Text(which is the text provided by the program)
                    {
                        //do not perform any calculation to count the correct or wrong variable  
                    }
                    else
                    {
                        richTextBox1.Select(txtDisp.Length, 1); //select the particular letter
                        if (richTextBox1.SelectionBackColor == Color.Green) //if the particular letter previously was green then,
                        {
                            correct--; //decrease correct by one

                        }
                        else //if the particular letter previously was red then,
                        {
                            wrong--; //decrease wrong by one

                        }
                        richTextBox1.SelectionBackColor = System.Drawing.SystemColors.Control;
                        richTextBox1.SelectionColor = System.Drawing.SystemColors.WindowText;
                    }
                }

            }
            else //if displayMsg.text is empty 
            {
                richTextBox1.Select(txtDisp.Length, 1);
                richTextBox1.SelectionBackColor = System.Drawing.SystemColors.Control;
                richTextBox1.SelectionColor = System.Drawing.SystemColors.WindowText;
                wrong = 0; //assign wrong to zero
                correct = 0; //assign correct to zero
            }
            accuracy = (correct / tries) * 100; //accuracy is calculated by correct divides by tries(tries increase by one for every keydown event that occurs) then multiply with 100 
            CorrectLbl.Text = "Correct: " + correct; //display the amount of correct words that is typed
            WrongLbl.Text = "Wrong: " + wrong; //display the amount of wrong words that is typed
            AccuracyLbl.Text = "Accuracy: " + Convert.ToInt32(accuracy) + "%"; //display the accuracy in int to users
                                                                               
                                                                               //CheckKey method always be called for every keydown event that occurs.
        }

        public void EndGame()
        {
            bool levelCleared;
            if (txtDisp == txtTarget)
            {
                levelCleared = true;
            }
            else
            {
                levelCleared = false;
            }
            TimeLeft.Stop();
            Results(levelCleared);
        }

        public void Results(bool levelCleared)
        {
            int score;
            if (levelCleared == true)
            {
                score = Convert.ToInt32((correct * time) * (accuracy / 100) + correct); //uses double for accuracy because to calculate more accurate for the highscore

                MessageBox.Show("Level Cleared Successfully!!\nCorrect: " + correct + "\nWrong: " + wrong + "\n\nHighScore: " + score, "Level Cleared!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                score = 0;
                MessageBox.Show("Level Not Cleared\nCorrect: " + correct + "\nWrong: " + wrong + "\n\nHighScore: " + score, "LEVEL NOT CLEARED!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            highscore(score);
            this.Visible = false;
        }

        public void highscore(int score)
        {
            int previous_score = 0;
            using (StreamReader sr = new StreamReader("highscore_time.txt"))
            {
                previous_score = Convert.ToInt32(sr.ReadLine());
            }
            if (score > previous_score)
            {
                using (StreamWriter sw = new StreamWriter("highscore_time.txt"))
                    sw.Write(score);
            }
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            if (time != 0)
            {
                TimeLbl.Text = "Timer: " + time;
                time -= 1;
            }

            else
            {
                EndGame();
            }
        }

    }
}
