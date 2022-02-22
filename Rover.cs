using System.Collections.Generic;


namespace HepsiBuradaProject
{
    public class Rover {

        private Direction currentDirection;

        private Dictionary<string,Direction> directions = new Dictionary<string, Direction>();

        private int X,Y,MaxX,MaxY;

        public Rover(string X,string Y, string MaxX, string MaxY, string direction){

            this.X = Convert.ToInt32(X);
            this.Y = Convert.ToInt32(Y);
            this.MaxX = Convert.ToInt32(MaxX);
            this.MaxY = Convert.ToInt32(MaxY);
            directions.Add("N", Direction.N);
            directions.Add("S", Direction.S);
            directions.Add("E", Direction.E);
            directions.Add("W", Direction.W);
            this.currentDirection = directions[direction];
        }

        public void Move(char move) {

            switch(move){
                case 'L':
                 currentDirection = (Direction)(((int)currentDirection + 270) % 360);
                 break;
                case 'R':
                 currentDirection = (Direction)(((int)currentDirection + 90) % 360);
                 break;
                case 'M':
                  moveForward();
                  break;
            }
        }

        public string GetLatestLocation() {
            return string.Format("{0} {1} {2}", X,Y,Convert.ToString(currentDirection));
        }

        private void moveForward() {

            switch(currentDirection){

                case Direction.N:
                    Y++;
                    break;
                case Direction.S:
                    Y--;
                    break;
                case Direction.W:
                    X--;
                    break;
                case Direction.E:
                    X++;
                    break;
            }
            
            if (X > MaxX) {
               X = MaxX-1;
            }
            if (Y > MaxY) {
                Y = MaxY -1 ;
            }
        }
     }
}

