﻿namespace Desktop.common.nomitech.common.bim
{
	public class BIMRamp : BIMBuildingElement
	{
	  public const string RAMP = "ramp";

	  private double bottomArea;

	  private int bottomAreaQT;

	  private double volume;

	  private int volumeQT;

	  private double height;

	  private int heightQT;

	  private double length;

	  private int lengthQT;

	  public BIMRamp()
	  {
		  GroupType = "ramp";
	  }

	  public virtual double Height
	  {
		  get
		  {
			  return this.height;
		  }
		  set
		  {
			  this.height = value;
		  }
	  }


	  public virtual int HeightQT
	  {
		  get
		  {
			  return this.heightQT;
		  }
		  set
		  {
			  this.heightQT = value;
		  }
	  }


	  public virtual double BottomArea
	  {
		  get
		  {
			  return this.bottomArea;
		  }
		  set
		  {
			  this.bottomArea = value;
		  }
	  }


	  public virtual int BottomAreaQT
	  {
		  get
		  {
			  return this.bottomAreaQT;
		  }
		  set
		  {
			  this.bottomAreaQT = value;
		  }
	  }


	  public virtual double Volume
	  {
		  get
		  {
			  return this.volume;
		  }
		  set
		  {
			  this.volume = value;
		  }
	  }


	  public virtual int VolumeQT
	  {
		  get
		  {
			  return this.volumeQT;
		  }
		  set
		  {
			  this.volumeQT = value;
		  }
	  }


	  public virtual double Length
	  {
		  get
		  {
			  return this.length;
		  }
		  set
		  {
			  this.length = value;
		  }
	  }


	  public virtual int LengthQT
	  {
		  get
		  {
			  return this.lengthQT;
		  }
		  set
		  {
			  this.lengthQT = value;
		  }
	  }

	}


	/* Location:              C:\Users\TomJames_zyl8law\Lightos\Lightos Hub - Documents\01-Clients\CostOS\Solution from Java Source Code\common\!\nomitech\common\bim\BIMRamp.class
	 * Java compiler version: 8 (52.0)
	 * JD-Core Version:       1.0.7
	 */
}