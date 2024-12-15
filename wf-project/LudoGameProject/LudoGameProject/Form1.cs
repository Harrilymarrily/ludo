using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGameProject
{
    public partial class Form1 : Form
    {
        Random Number = new Random();
        List<BoardDirection> BlueDirections = new List<BoardDirection>();
        List<BoardDirection> RedDirections = new List<BoardDirection>();
        List<BoardDirection> GreenDirections = new List<BoardDirection>();
        List<BoardDirection> YellowDirections = new List<BoardDirection>();

        int bluePiecePos = 0;
        int bluePieceDirection = 0;

        int redPiecePos = 0;
        int redPieceDirection = 0;

        int greenPiecePos = 0;
        int greenPieceDirection = 0;

        int yellowPiecePos = 0;
        int yellowPieceDirection = 0;

        public Form1()
        {
            InitializeComponent();
            BlueDirections.Add(new BoardDirection(5, "LAcross"));    //Direction and turns for Pawns, the number is the amount of places, the word determines which direction.
            BlueDirections.Add(new BoardDirection(6, "Down"));
            BlueDirections.Add(new BoardDirection(2, "LAcross"));
            BlueDirections.Add(new BoardDirection(6, "Up"));
            BlueDirections.Add(new BoardDirection(6, "LAcross"));
            BlueDirections.Add(new BoardDirection(2, "Up"));
            BlueDirections.Add(new BoardDirection(6, "RAcross"));
            BlueDirections.Add(new BoardDirection(6, "Up"));
            BlueDirections.Add(new BoardDirection(2, "RAcross"));
            BlueDirections.Add(new BoardDirection(6, "Down"));
            BlueDirections.Add(new BoardDirection(6, "RAcross"));
            BlueDirections.Add(new BoardDirection(1, "Down"));
            BlueDirections.Add(new BoardDirection(6, "LAcross"));

            RedDirections.Add(new BoardDirection(5, "Up"));
            RedDirections.Add(new BoardDirection(6, "LAcross"));
            RedDirections.Add(new BoardDirection(2, "Up"));
            RedDirections.Add(new BoardDirection(6, "RAcross"));
            RedDirections.Add(new BoardDirection(6, "Up"));
            RedDirections.Add(new BoardDirection(2, "RAcross"));
            RedDirections.Add(new BoardDirection(6, "Down"));
            RedDirections.Add(new BoardDirection(6, "RAcross"));
            RedDirections.Add(new BoardDirection(2, "Down"));
            RedDirections.Add(new BoardDirection(6, "LAcross"));
            RedDirections.Add(new BoardDirection(6, "Down"));
            RedDirections.Add(new BoardDirection(1, "LAcross"));
            RedDirections.Add(new BoardDirection(6, "Up"));

            GreenDirections.Add(new BoardDirection(5, "RAcross"));
            GreenDirections.Add(new BoardDirection(6, "Up"));
            GreenDirections.Add(new BoardDirection(2, "RAcross"));
            GreenDirections.Add(new BoardDirection(6, "Down"));
            GreenDirections.Add(new BoardDirection(6, "RAcross"));
            GreenDirections.Add(new BoardDirection(2, "Down"));
            GreenDirections.Add(new BoardDirection(6, "LAcross"));
            GreenDirections.Add(new BoardDirection(6, "Down"));
            GreenDirections.Add(new BoardDirection(2, "LAcross"));
            GreenDirections.Add(new BoardDirection(6, "Up"));
            GreenDirections.Add(new BoardDirection(6, "LAcross"));
            GreenDirections.Add(new BoardDirection(1, "Up"));
            GreenDirections.Add(new BoardDirection(6, "RAcross"));

            YellowDirections.Add(new BoardDirection(5, "Down"));
            YellowDirections.Add(new BoardDirection(6, "RAcross"));
            YellowDirections.Add(new BoardDirection(2, "Down"));
            YellowDirections.Add(new BoardDirection(6, "LAcross"));
            YellowDirections.Add(new BoardDirection(6, "Down"));
            YellowDirections.Add(new BoardDirection(2, "LAcross"));
            YellowDirections.Add(new BoardDirection(6, "Up"));
            YellowDirections.Add(new BoardDirection(6, "LAcross"));
            YellowDirections.Add(new BoardDirection(2, "Up"));
            YellowDirections.Add(new BoardDirection(6, "RAcross"));
            YellowDirections.Add(new BoardDirection(6, "Up"));
            YellowDirections.Add(new BoardDirection(1, "RAcross"));
            YellowDirections.Add(new BoardDirection(6, "Down"));
        }
        public void playerturn()
        {
            List<string> players = new List<string>();

            players.Add("blue");
            players.Add("red");
            players.Add("green");
            players.Add("yellow");


        }
        private void start_Click(object sender, EventArgs e)
        {           
            start.Text = "Your turn";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Number.Next(1, 7);      // Replicates the dice roll for blue
            Diceresult.Text = a.ToString();

            int b = Number.Next(1, 7);      // Replicates the dice roll for red
            Diceresult.Text = b.ToString();

            int c = Number.Next(1, 7);      // Replicates the dice roll for green
            Diceresult.Text = c.ToString();

            int d = Number.Next(1, 7);      // Replicates the dice roll for yellow
            Diceresult.Text = d.ToString();

            MoveBluepiece(a);
            MoveRedpiece(b);       
            MoveGreenpiece(c);
            MoveYellowpiece(d);

        }

        void MoveBluepiece(int distance)
        {
            BoardDirection current = BlueDirections[bluePieceDirection];
            for(int i=0;i< distance; i++)
            {
                if (bluePiecePos != current.amount)
                {
                    switch(current.direction)  //Determines how the Pawn moves.
                    {
                        case "LAcross":
                            bluePawn.Location = new Point(bluePawn.Location.X - 64, bluePawn.Location.Y);   // Moves the pawn on the X-Axis
                            break;
                        case "RAcross":
                            bluePawn.Location = new Point(bluePawn.Location.X + 64, bluePawn.Location.Y);
                            break;
                        case "Down":
                            bluePawn.Location = new Point(bluePawn.Location.X, bluePawn.Location.Y+65);   // Moves the pawn on the Y-Axis
                            break;
                        case "Up":
                            bluePawn.Location = new Point(bluePawn.Location.X, bluePawn.Location.Y-65);
                            break;
                    }
                    bluePiecePos++;
                }
                else
                {
                    bluePieceDirection++;
                    bluePiecePos = 0;
                    current = BlueDirections[bluePieceDirection];
                }
            }
        }

        void MoveRedpiece(int distance)
        {
            BoardDirection current = RedDirections[redPieceDirection];
            for (int i = 0; i < distance; i++)
            {
                if (redPiecePos != current.amount)
                {
                    switch (current.direction)
                    {
                        case "LAcross":
                            redPawn.Location = new Point(redPawn.Location.X - 64, redPawn.Location.Y);
                            break;
                        case "RAcross":
                            redPawn.Location = new Point(redPawn.Location.X + 64, redPawn.Location.Y);
                            break;
                        case "Down":
                            redPawn.Location = new Point(redPawn.Location.X, redPawn.Location.Y + 65);
                            break;
                        case "Up":
                            redPawn.Location = new Point(redPawn.Location.X, redPawn.Location.Y - 65);
                            break;
                    }
                    redPiecePos++;
                }
                else
                {
                    redPieceDirection++;
                    redPiecePos = 0;
                    current = RedDirections[redPieceDirection];
                }
            }
        }
        void MoveGreenpiece(int distance)
        {
            BoardDirection current = GreenDirections[greenPieceDirection];
            for (int i = 0; i < distance; i++)
            {
                if (greenPiecePos != current.amount)
                {
                    switch (current.direction)
                    {
                        case "LAcross":
                            greenPawn.Location = new Point(greenPawn.Location.X - 65, greenPawn.Location.Y);
                            break;
                        case "RAcross":
                            greenPawn.Location = new Point(greenPawn.Location.X + 65, greenPawn.Location.Y);
                            break;
                        case "Down":
                            greenPawn.Location = new Point(greenPawn.Location.X, greenPawn.Location.Y + 65);
                            break;
                        case "Up":
                            greenPawn.Location = new Point(greenPawn.Location.X, greenPawn.Location.Y - 65);
                            break;
                    }
                    greenPiecePos++;
                }
                else
                {
                    greenPieceDirection++;
                    greenPiecePos = 0;
                    current = GreenDirections[greenPieceDirection];
                }
            }
        }
        void MoveYellowpiece(int distance)
        {
            BoardDirection current = YellowDirections[yellowPieceDirection];
            for (int i = 0; i < distance; i++)
            {
                if (yellowPiecePos != current.amount)
                {
                    switch (current.direction)
                    {
                        case "LAcross":
                            yellowPawn.Location = new Point(yellowPawn.Location.X - 65, yellowPawn.Location.Y);
                            break;
                        case "RAcross":
                            yellowPawn.Location = new Point(yellowPawn.Location.X + 65, yellowPawn.Location.Y);
                            break;
                        case "Down":
                            yellowPawn.Location = new Point(yellowPawn.Location.X, yellowPawn.Location.Y + 65);
                            break;
                        case "Up":
                            yellowPawn.Location = new Point(yellowPawn.Location.X, yellowPawn.Location.Y - 65);
                            break;
                    }
                    yellowPiecePos++;
                }
                else
                {
                    yellowPieceDirection++;
                    yellowPiecePos = 0;
                    current = YellowDirections[yellowPieceDirection];
                }
            }
        }
    }

    public class BoardDirection
    {
        public int amount;
        public string direction;

        public BoardDirection(int a, string d)   // class for Pawn movement and direction
        {
            amount = a;
            direction = d;
        }
    }
}
