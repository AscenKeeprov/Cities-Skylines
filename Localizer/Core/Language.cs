using System;

namespace Localizer.Core
{
	public class Language : IComparable
	{
		public string Code { get; private set; }
		public string Name { get; private set; }

		public Language() { }

		public Language(string code, string name)
		{
			Code = code.ToLower();
			Name = name;
		}

		public int CompareTo(object obj)
		{
			if (obj is Language that) return Name.CompareTo(that.Name);
			throw new ArgumentException($"Can only compare to objects of type {nameof(Language)}!");
		}

		public override string ToString()
		{
			return $"{Name} [{Code}]";
		}
	}
}
