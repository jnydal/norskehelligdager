/*
 * Created by SharpDevelop.
 * User: tnydal
 * Date: 03.05.2017
 * Time: 13:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

/// <summary>
/// Description of MyClass.
/// </summary>

namespace NK
{

public class Helligdager
{
	public static List<DateTime> hentAlle(int year)
	{
		List<DateTime> result = new List<DateTime> {};
		int day = 0;
	    int month = 0;
	
	    int g = year % 19;
	    int c = year / 100;
	    int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
	    int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));
	
	    day   = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 28;
	    month = 3;
	
	    if (day > 31)
	    {
	        month++;
	        day -= 31;
	    }

	    DateTime paaskeSoendag = new DateTime(year, month, day);
	    DateTime himmelfartsdag = paaskeSoendag.AddDays(39);
	    DateTime pinsedag = paaskeSoendag.AddDays(50);
	    DateTime skjaertorsdag = paaskeSoendag.AddDays(-3);
	    DateTime langfredag = paaskeSoendag.AddDays(-2);
	    DateTime paaskedag = paaskeSoendag.AddDays(1);
	    DateTime mai1 = new DateTime(year, 5, 1);
	    DateTime nasjonaldag = new DateTime(year, 5, 17);
	    DateTime nyttaarsdag = new DateTime(year,1,1);
	    DateTime juledag = new DateTime(year, 12, 25);
	    DateTime juledag2 = new DateTime(year, 12, 26);
	    result.Add(nyttaarsdag);
	    result.Add(skjaertorsdag);
	    result.Add(langfredag);
	    result.Add(paaskeSoendag);
	    result.Add(paaskedag);
	    result.Add(mai1);
	    result.Add(nasjonaldag);
	    result.Add(himmelfartsdag);
	    result.Add(pinsedag);		    
	    result.Add(juledag);
	    result.Add(juledag2);
	    return result;
	}
}

}