using System;
using System.Drawing;

public class GridMaker
{
	public double screenWidth { get; set; }
	public double screenHeight { get; set; }
	public string screenResolution { get; set; }
    public double screenAspectRatio { get; set; }

    public GridMaker()
	{
        //this needs to get the screen size of the user's monitor and pass it
        
     this.screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
     this.screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
     

    }
    public void UIGridInfo()
    {
        // This method will display the grid information on the UI
        string screenWidth = this.screenWidth.ToString();
        string screenHeight = this.screenHeight.ToString();
        // TODO - Make a text that shows the width and height found, maybe do a manual width and height and position if user wants specific zones
        this.screenAspectRatio = this.screenWidth / this.screenHeight;
        if (this.screenAspectRatio > 1)
        {
            this.screenResolution = $"{this.screenWidth} x {this.screenHeight} (Landscape)";

        }
        else if (this.screenAspectRatio < 1)
        {
            this.screenResolution = $"{this.screenWidth} x {this.screenHeight} (Portrait)";
        }
        else
        {
            this.screenResolution = $"{this.screenWidth} x {this.screenHeight} (Square)";
        }


    }

    public void GridDrawer(double screenWith, double screenHeight)
	{
		//this needs to take the screen with and height and split it into equal sized squars based on user preferences
	}
}
