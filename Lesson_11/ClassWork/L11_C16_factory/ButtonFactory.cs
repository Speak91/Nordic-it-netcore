using System;

namespace L11_C16_factory
{
	class ButtonFactory
	{
		public bool PushButtonOnCreate { get; set; }

		public Button CreateButton()
		{
			if (PushButtonOnCreate)
				return new Button(true);
			else
				return new Button();
		}
	}
}