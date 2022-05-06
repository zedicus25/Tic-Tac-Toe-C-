using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, System.EventArgs e)
        {
            if (CanStart() && NotRepeat())
            {
                Form f = new GameForm(_firstUserTB.Text, _secondUserTB.Text, _selectSizeCB.SelectedIndex);
                f.ShowDialog();
            }
            else
            {
                if (this._firstUserTB.Text == String.Empty)
                    _firstUserTB.BackColor = Color.IndianRed;
                if (this._secondUserTB.Text == String.Empty)
                    _secondUserTB.BackColor = Color.IndianRed;
            }
        }

        private void TBEnterText(object sender, System.EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.BackColor = Color.White;
        }

        private bool CanStart() => !(this._firstUserTB.Text == String.Empty || this._secondUserTB.Text == String.Empty);

        private bool NotRepeat() => !(this._firstUserTB.Text.ToLower().Equals(this._secondUserTB.Text.ToLower()));
    }
}
