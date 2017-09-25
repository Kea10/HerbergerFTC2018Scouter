using System;
namespace HerbergerFTC2018_Scouter
{
	public class AutonomousProgram
	{
		public bool Program;
		public bool Balence;
		public bool ColorSensor;
		public bool JewelCapability;
		public bool BoxCapability;
		public int BoxesPlaced;
		public int BoxesPlacedRow;
		public bool CorrectBoxPlacement;
		public bool JewelKnock;
		public bool Park;
		public int AvgPoints
		{
			get
			{
				int points = 0;
				if (!Program || !Balence)
				{
					return points;
				}
				if (JewelKnock && ColorSensor)
				{
					points = points + 30;
				}
				points = points + (BoxesPlaced * 15);
				if (Park)
				{
					points = points + 10;
				}
				if (CorrectBoxPlacement)
				{
					points = points + 30;
				}
				else
				{
					points = points + (10 * BoxesPlacedRow);
				}
				return points;
			}
		}
		public int MaxPoints
		{
			get
			{
				int points = 0;
				if (!Program || !Balence)
				{
					return points;
				}
				if (JewelCapability)
				{
					points = points + 30;
				}
				points = points + 45;
				if (Park)
				{
					points = points + 10;
				}
				if (BoxCapability)
				{
					points = points + 30;
				}
				return points;
			}
		}
		public AutonomousProgram(bool program, bool balence, bool color, bool jcap, bool bcap, int bplaced, int bplacedrow, bool cboxp, bool jknock, bool park)
		{
			Program = program;
			Balence = balence;
			ColorSensor = color;
			JewelCapability = jcap;
			BoxCapability = bcap;
			BoxesPlaced = bplaced;
			BoxesPlacedRow = bplacedrow;
			CorrectBoxPlacement = cboxp;
			JewelKnock = jknock;
			Park = park;
		}
	}
}