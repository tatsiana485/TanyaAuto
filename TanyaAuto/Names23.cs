using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Names23
    {
		    public void name(string[] names)
			{
				for (int i = 0; i < names.Length; i++)
				{
					if (i < names.Length - 1)
						Console.Write(names[i] + ", ");
					else
						Console.Write(names[i] + "\n");

				}
			}
			public void name(string[] nam, string symbol)
			{
				for (int i = 0; i < nam.Length; i++)
				{
					if (i < nam.Length - 1)
						Console.Write(nam[i] + symbol + " ");
					else
						Console.Write(nam[i] + "\n");
				}
			}
	}
}
