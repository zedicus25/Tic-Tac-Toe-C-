using System.Windows.Forms;

namespace TicTacToe
{
    partial class SelectingForm
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
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Selecting Form";

            //
            // _sizeL
            //
            this._sizeL = new Label();
            this._sizeL.Size = new System.Drawing.Size(100,50);
            this._sizeL.Location = new System.Drawing.Point(30, 400);
            this._sizeL.Font = new System.Drawing.Font(this._sizeL.Font.FontFamily, 12);
            this._sizeL.Text = "Size: ";
            this.Controls.Add(_sizeL);

            //
            //  _startBtn
            //
            this._startBtn = new System.Windows.Forms.Button();
            this._startBtn.Size = new System.Drawing.Size(100, 50);
            this._startBtn.Location = new System.Drawing.Point(300, 400);
            this._startBtn.Text = "Start";
            this._startBtn.Click += this.StartGame;
            this.Controls.Add(_startBtn);
            
        }

        private Button[,] _field;
        private Label _sizeL;
        private Button _startBtn;
        private int _startSize = 9;

        #endregion
    }
}