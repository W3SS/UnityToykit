using NUnit.Framework;
using System.Collections.Generic;

namespace Finegamedesign.Utils
{
	[TestFixture]
	public sealed class TestLevelSelectModel
	{
		public static void Configure(LevelSelectModel model)
		{
			model.levelCount = 2939;
			model.levelUnlocked = 109;
			model.menus = new List<int>(){8, 20, 20};
			model.menuNames = new List<string>(){
				"chapterSelect",
				"levelSelect",
				"wordSelect",
				"play"
			};
		}

		[Test]
		public void Select107of109Unlocked()
		{
			LevelSelectModel model = new LevelSelectModel();
			Configure(model);
			model.Setup();
			Assert.AreEqual(1, model.levelsPerItem[2]);
			Assert.AreEqual(20, model.levelsPerItem[1]);
			Assert.AreEqual(400, model.levelsPerItem[0]);
			AssertSelect107(model);
			AssertExit(model);
			AssertSelect107(model);
			AssertExit(model);
		}

		private void AssertSelect107(LevelSelectModel model)
		{
			Assert.AreEqual(0, model.menuIndex);
			Assert.AreEqual("chapterSelect", model.menuName);
			Assert.AreEqual(false, model.Select(1));
			Assert.AreEqual(0, model.menuIndex);
			Assert.AreEqual("chapterSelect", model.menuName);
			Assert.AreEqual(true, model.Select(0));
			Assert.AreEqual(1, model.menuIndex);
			Assert.AreEqual(0, model.context);
			Assert.AreEqual(0, model.requested);
			Assert.AreEqual("levelSelect", model.menuName);
			Assert.AreEqual(false, model.Select(6));
			Assert.AreEqual(1, model.menuIndex);
			Assert.AreEqual(120, model.requested);
			Assert.AreEqual(true, model.Select(5));
			Assert.AreEqual(2, model.menuIndex);
			Assert.AreEqual(100, model.requested);
			Assert.AreEqual("wordSelect", model.menuName);
			Assert.AreEqual(false, model.Select(10));
			Assert.AreEqual(2, model.menuIndex);
			Assert.AreEqual(true, model.Select(7));
			Assert.AreEqual(3, model.menuIndex);
			Assert.AreEqual(107, model.levelSelected);
			Assert.AreEqual(107, model.requested);
			Assert.AreEqual("play", model.menuName);
		}

		private void AssertExit(LevelSelectModel model)
		{
			model.Exit();
			Assert.AreEqual(2, model.menuIndex);
			Assert.AreEqual(100, model.context);
			Assert.AreEqual("wordSelect", model.menuName);
			model.Exit();
			Assert.AreEqual(1, model.menuIndex);
			Assert.AreEqual(0, model.context);
			Assert.AreEqual("levelSelect", model.menuName);
			model.Exit();
			model.Exit();
		}
	}
}
