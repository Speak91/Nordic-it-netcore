using System;

namespace L13_C05_abstract_members_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var plane = new Plane(100, 4);
			//plane.TakeUpper(120);
			//plane.TakeLower(100);
			//plane.WriteAllProperties();

			var helicopter = new Helicopter(80, 3);
			//helicopter.TakeUpper(120);
			//helicopter.TakeLower(60);
			//helicopter.WriteAllProperties();
			//helicopter.TakeLower(21);

			FlyingObject[] fos = new FlyingObject[2];
			fos[0] = plane;
			fos[1] = helicopter;

			foreach (FlyingObject fo in fos)
			{
				fo.TakeUpper(120);
				fo.TakeLower(60);
				fo.TakeLower(21);
				if (fo is IAllPropertiesWriter)
				{
					((IAllPropertiesWriter)fo).WriteAllProperties();
				}
			}
		}
	}
}
