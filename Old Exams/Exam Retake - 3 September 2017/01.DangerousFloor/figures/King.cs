namespace DangerousFloor
{
    public class King : Directions
    {
        private int[] position;

        public int[] Position
        {
            get => this.position;
            set => position = value;
        }

        public override bool ValidVerticallMoves(int[] futurePosition)
        {
            if (futurePosition[1] == this.position[1] + 1 ||
                futurePosition[1] == this.position[1] - 1)
            {
                return true;
            }

            return false;
        }

        public override bool ValidHorizontallMoves(int[] futurePosition)
        {
            if (futurePosition[0] == this.position[0] + 1 ||
                futurePosition[0] == this.position[0] - 1)
            {
                return true;
            }

            return false;
        }

        public override bool ValidDiagonallMoves(int[] futurePosition)
        {
            bool diagonalUpperLeft = futurePosition[1] == this.position[1] - 1 &&
                                     futurePosition[0] == this.position[0] + 1;
            bool diagonalUpperRight = futurePosition[1] == this.position[1] - 1 &&
                                      futurePosition[0] == this.position[0] - 1;
            bool diagonalLowerLeft = futurePosition[1] == this.position[1] + 1 &&
                                     futurePosition[0] == this.position[0] - 1;
            bool diagonalLowerRight = futurePosition[1] == this.position[1] + 1 &&
                                      futurePosition[0] == this.position[0] + 1;

            if (diagonalUpperLeft && diagonalUpperRight &&
                diagonalLowerLeft && diagonalLowerRight)
            {
                return true;
            }

            return false;
        }               
    }
}
