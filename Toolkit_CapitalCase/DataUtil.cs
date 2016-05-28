using System;
using System.Collections;
using System.Collections.Generic;

namespace com.finegamedesign.utils
{
	/**
	 * Another option is an extension method.
	 * In-case someone else already made a different extension method, 
	 * or the language has different syntax, I used static functions.
	 * For examples of divergent syntax:
	 * ActionScript:  items.length
	 * C#:  items.Count
	 * Python:  len(items)
	 * Some of these use different method names or property names in different languages.
	 */
	public sealed class DataUtil
	{
		// http://stackoverflow.com/questions/222598/how-do-i-clone-a-generic-list-in-c
		public static List<T> CloneList<T>(List<T> original)
		{
			return new List<T>(original);
		}

		public static int Length<T>(List<T> data)
		{
			return data.Count;
		}

		public static int Length(ArrayList elements)
		{
			return elements.Count;
		}

		public static int Length(string text)
		{
			return text.Length;
		}

		public static void Clear<T>(List<T> items)
		{
			items.Clear();
		}

		/**
		 * I wish C# API were as simple as JavaScript and Python:
		 * http://stackoverflow.com/questions/1126915/how-do-i-split-a-string-by-a-multi-character-delimiter-in-c
		 */
		public static List<string> Split(string text, string delimiter)
		{
			if ("" == delimiter) {
				return SplitString(text);
			}
			else {
				string[] delimiters = new string[] {delimiter};
				string[] parts = text.Split(delimiters, StringSplitOptions.None);
				List<string> list = new List<string>(parts);
				return list;
			}
		}

		/**
		 * This was the most concise way I found to split a string without depending on a library.
		 * In ActionScript splitting a string is concise:  s.split("");
	 * C# has characters, which would be more efficient, though less portable.
		 */
		public static List<string> SplitString(string text)
		{
			List<string> letters = new List<string>();
			char[] characters = text.ToCharArray();
			for (int i = 0; i < characters.Length; i++) {
				letters.Add(characters[i].ToString());
			}
			return letters;
		}

		public static string Join(List<string> texts, string delimiter)
		{
			string[] parts = (string[]) texts.ToArray();
			string joined = string.Join(delimiter, parts);
			return joined;
		}


		public static T Pop<T>(List<T> items)
		{
			T item = (T)items[items.Count - 1];
			items.RemoveAt(items.Count - 1);
			return item;
		}
	}
}
