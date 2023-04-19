namespace Clock;

public partial class patternGrid : Grid
{
	public patternGrid()
	{
		InitializeComponent();
	}

	public void ChangeGridForANumb(int value)
	{
		//Creating array for BoxViews
		BoxView[,] boxViews = new BoxView[myGrid.RowDefinitions.Count, myGrid.ColumnDefinitions.Count];

		//Filling array BoxView
		for(int i = 0; i < myGrid.RowDefinitions.Count; i++)
		{
			for(int j = 0; j < myGrid.ColumnDefinitions.Count; j++)
			{
				boxViews[i, j] = myGrid.FindByName($"Box{i}{j}") as BoxView;
                boxViews[i, j].Color = Colors.Black;
			}
		}

		//Drawing number
		switch(value)
		{
			case 0:
				boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 0].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 1:
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 1].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 2:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 0].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 3:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 4:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 5:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 6:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 0].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 7:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 8:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[3, 0].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
			case 9:
                boxViews[0, 0].Color = Colors.White;
                boxViews[0, 1].Color = Colors.White;
                boxViews[0, 2].Color = Colors.White;
                boxViews[1, 0].Color = Colors.White;
                boxViews[1, 2].Color = Colors.White;
                boxViews[2, 0].Color = Colors.White;
                boxViews[2, 1].Color = Colors.White;
                boxViews[2, 2].Color = Colors.White;
                boxViews[3, 2].Color = Colors.White;
                boxViews[4, 0].Color = Colors.White;
                boxViews[4, 1].Color = Colors.White;
                boxViews[4, 2].Color = Colors.White;
                break;
		}
	}
}