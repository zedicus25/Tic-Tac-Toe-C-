using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class StartGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.MaximumSize = new System.Drawing.Size(400, 550);
            this.MinimumSize = new System.Drawing.Size(400, 550);
            this.Location = new System.Drawing.Point(500, 500);
            this.Text = "Start Game Form";
            this.BackColor = Color.LightGreen;


            //
            //  _firstUserNameL
            //
            this._firstUserNameL = new Label();
            this._firstUserNameL.Size = new System.Drawing.Size(250,30);
            this._firstUserNameL.Location = new System.Drawing.Point((this.Width/2) - (this._firstUserNameL.Width/2), 30);
            this._firstUserNameL.Font = new System.Drawing.Font(this._firstUserNameL.Font.FontFamily, 15);
            this._firstUserNameL.Text = "Enter first user name";
            this._firstUserNameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Controls.Add(_firstUserNameL);

            //
            //  _firstUserTB
            //
            this._firstUserTB = new TextBox();
            this._firstUserTB.TextChanged += TBEnterText;
            this._firstUserTB.Font = new System.Drawing.Font(this._firstUserTB.Font.FontFamily, 15);
            this._firstUserTB.Location = new System.Drawing.Point((this.Width / 2) - (this._firstUserTB.Width / 2),70);
            this.Controls.Add(_firstUserTB);

            //
            //  _secondUserNameL
            //
            this._secondUserNameL = new Label();
            this._secondUserNameL.Size = new System.Drawing.Size(250, 30);
            this._secondUserNameL.Location = new System.Drawing.Point((this.Width / 2) - (this._secondUserNameL.Width / 2), 110);
            this._secondUserNameL.Font = new System.Drawing.Font(this._secondUserNameL.Font.FontFamily, 15);
            this._secondUserNameL.Text = "Enter second user name";
            this._secondUserNameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Controls.Add(_secondUserNameL);

            //
            //  _secondUserTB
            //
            this._secondUserTB = new TextBox();
            this._secondUserTB.TextChanged += TBEnterText;
            this._secondUserTB.Font = new System.Drawing.Font(this._secondUserTB.Font.FontFamily, 15);
            this._secondUserTB.Location = new System.Drawing.Point((this.Width / 2) - (this._secondUserTB.Width / 2), 145);
            this.Controls.Add(_secondUserTB);

            //
            //  _startGameBtn
            //
            this._startGameBtn = new Button();
            this._startGameBtn.Size = new System.Drawing.Size(100, 100);
            this._startGameBtn.Location = new System.Drawing.Point((this.Width / 2) + (this._startGameBtn.Width / 2), 280);
            this._startGameBtn.Text = "Start";
            this._startGameBtn.Font = new System.Drawing.Font(_startGameBtn.Font.FontFamily, 15);
            this._startGameBtn.BackColor = Color.DarkOrange;
            this._startGameBtn.Click += StartGame;
            this.Controls.Add(_startGameBtn);

            //
            //  _mainMenuBtn
            //
            this._mainMenuBtn = new Button();
            this._mainMenuBtn.Size = new System.Drawing.Size(100, 100);
            this._mainMenuBtn.Location = new System.Drawing.Point((this.Width / 2) - (this._startGameBtn.Width + (this._startGameBtn.Width / 2))
                , 280);
            this._mainMenuBtn.Text = "Back to main menu";
            this._mainMenuBtn.Font = new System.Drawing.Font(_mainMenuBtn.Font.FontFamily, 15);
            this._mainMenuBtn.BackColor = Color.DarkOrange;
            this._mainMenuBtn.Click += (s,e) => this.Close();
            this.Controls.Add(_mainMenuBtn);

            //
            //  _selectSizeCB
            //
            string[] sizes = new string[] { "3x3","6x6","9x9", "Custom" };
            this._selectSizeCB = new System.Windows.Forms.ComboBox();
            this._selectSizeCB.Items.AddRange(sizes);
            this._selectSizeCB.SelectedIndex = 0;
            this._selectSizeCB.Location = new Point(this.Width/2 - (_selectSizeCB.Width/2), 200);
            this.Controls.Add(_selectSizeCB);
        }

        private Label _firstUserNameL;
        private Label _secondUserNameL;
        private TextBox _firstUserTB;
        private TextBox _secondUserTB;
        private Button _startGameBtn;
        private Button _mainMenuBtn;
        private ComboBox _selectSizeCB;

        #endregion
    }
}