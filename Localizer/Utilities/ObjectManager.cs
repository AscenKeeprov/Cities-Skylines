using System.Reflection;

namespace Localizer.Utilities
{
	public static class ObjectManager
	{
		public static object GetPrivateField(object obj, string fieldName)
		{
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
			FieldInfo field = obj.GetType().GetField(fieldName, bindingFlags);
			return field.GetValue(obj);
		}
	}
}
