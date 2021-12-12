using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Currency
    {
		public static string FormatCurrency(string currencyCode, decimal amount)
		{
			CultureInfo culture = (from c in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
								   let r = new RegionInfo(c.LCID)
								   where r != null
								   && r.ISOCurrencySymbol.ToUpper() == currencyCode.ToUpper()
								   select c).FirstOrDefault();
			if (culture == null)
			{
				// fall back to current culture if none is found
				// you could throw an exception here if that's not supposed to happen
				culture = CultureInfo.CurrentCulture;

			}
			culture = (CultureInfo)culture.Clone();
			culture.NumberFormat.CurrencySymbol = currencyCode;
			culture.NumberFormat.CurrencyPositivePattern = culture.NumberFormat.CurrencyPositivePattern == 0 ? 2 : 3;
			var cnp = culture.NumberFormat.CurrencyNegativePattern;
			switch (cnp)
			{
				case 0: cnp = 14; break;
				case 1: cnp = 9; break;
				case 2: cnp = 12; break;
				case 3: cnp = 11; break;
				case 4: cnp = 15; break;
				case 5: cnp = 8; break;
				case 6: cnp = 13; break;
				case 7: cnp = 10; break;
			}
			culture.NumberFormat.CurrencyNegativePattern = cnp;

			return amount.ToString("C" + ((amount % 1) == 0 ? "0" : "2"), culture);
		}
	}
}
