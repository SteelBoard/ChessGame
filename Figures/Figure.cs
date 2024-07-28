public abstract class Figure
{
    public bool isWhite { get; private set; }
    public abstract int[][] GetMoves(int[] posotion);
}