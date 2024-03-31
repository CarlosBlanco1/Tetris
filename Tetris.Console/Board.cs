// See https://aka.ms/new-console-template for more information

public class Board()
{
    List<List<string>> Grid {get; set;} = new();
    public IEnumerable<List<string>>? CreateBoard(int rows, int columns)
    {
        if(rows > 0)
        {
            for (int i = 0; i < rows; i++)
            {
                var temp = new List<string>();

                for (int j = 0; j < columns; j++)
                {
                    temp.Add(" ");
                }
                
                Grid.Add(temp);     
            }

            return Grid;
        }
        return new List<List<string>>(){};
    }
}
