using System;

namespace Localizer.Core
{
	public class Language : IComparable
	{
		public string Code { get; set; }
		public string Name { get; set; }

		public int CompareTo(object obj)
		{
			if (obj is Language that) return this.Name.CompareTo(that.Name);
			throw new ArgumentException("Object is not a Language");
		}

		public override string ToString()
		{
			return $"{Name} [{Code}]";
		}
	}
}
