namespace DangerousFloor
{
    public class Directions
    {
        private int[] position;

        public int[] Position
        {
            get => this.position;
            set => position = value;
        }

        public virtual bool ValidDiagonallMoves(int[] futurePosition)
        {
            bool diagonalUpperLeft = futurePosition[1] != this.position[1] &&
                                     futurePosition[0] != this.position[0];
            bool diagonalUpperRight = futurePosition[1] != this.position[1] &&
                                      futurePosition[0] != this.position[0];
            bool diagonalLowerLeft = futurePosition[1] != this.position[1] &&
                                     futurePosition[0] != this.position[0];
            bool diagonalLowerRight = futurePosition[1] != this.position[1] &&
                                      futurePosition[0] != this.position[0];

            if (diagonalUpperLeft && diagonalUpperRight &&
                diagonalLowerLeft && diagonalLowerRight)
            {
                return true;
            }

            return false;
        }

        public virtual bool ValidHorizontallMoves(int[] futurePosition)
        {
            if (futurePosition[0] != this.position[0] &&
                futurePosition[1] == this.position[1])
            {
                return true;
            }

            return false;
        }

        public virtual bool ValidVerticallMoves(int[] futurePosition)
        {
            if (futurePosition[1] != this.position[1] &&
                futurePosition[0] == this.position[0])
            {
                return true;
            }

            return false;
        }

        public virtual bool ValidOnceMove(int[] futurePosition)
        {
            if (futurePosition[0] == this.position[0] - 1)
            {
                return true;
            }

            return false;
        }
    }
}