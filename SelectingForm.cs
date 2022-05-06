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
    public partial class SelectingForm : Form
    {
        public int _X { get; private set; }
        public int _Y { get; private set; }
        public SelectingForm()
        {
            InitializeComponent();
            CreateField();
        }

        private void CreateField()
        {
            _field = new Button[_startSize, _startSize];
            int width = 35;
            int height = 35;
            _field[0,0] = CreateButton(width, height,new Point(25,25));
            _field[0, 0].Name = "0 0";
            for (int i = 0; i < _startSize; i++)
            {
                for (int j = 0; j < _startSize; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    _field[i, j] = CreateButton(width, height, new Point(this._field[0, 0].Location.X + (i * width), 
                        this._field[0, 0].Location.Y + (j * height)));
                    _field[i, j].Name = $"{i} {j}";
                }
            }
        }

        private Button CreateButton(int width, int height, Point location)
        {
            Button b = new Button();
            b.Size = new Size(width, height);
            b.Location = location;
            b.BackColor = Color.White;
            b.MouseClick += this.B_MouseClick;
            this.Controls.Add(b);
            return b;
        }

        private void B_MouseClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor != Color.ForestGreen)
            {
                ResetButton();
                b.BackColor = Color.ForestGreen;
                Fill(b.Name);
            } 
        }
        private void StartGame(object sender, System.EventArgs e)
        {
            if(this._X >= 2 && this._Y >=3)            
                this.Close();
        }

        private void Fill(string index)
        {
            _X = int.Parse(index.Substring(0, index.Length - index.IndexOf(" "))) + 1;
            _Y = int.Parse(index.Substring(index.Length - index.IndexOf(" "))) + 1;
            for (int i = 0; i < _X; i++)
            {
                for (int j = 0; j < _Y; j++)
                {
                    _field[i, j].BackColor = Color.LawnGreen;
                }
            }
            this._sizeL.Text = $"Size: {_X}x{_Y}";
        }
        

        private void ResetButton()
        {
            for (int i = 0; i < _startSize; i++)
            {
                for (int j = 0; j < _startSize; j++)
                {
                    _field[i, j].BackColor = Color.White;
                }
            }
            this._sizeL.Text = "Size:";
        }
    }
}
