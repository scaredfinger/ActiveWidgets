
using System;
using System.Collections.Generic;
using CG.Controls.NavigationBar;
using NUnit.Framework;

namespace PfGrid.Boundaries
{
	[TestFixture]
	public class NavigationBarFixture
	{
		private ExNavigationBar _navBar ;
		
		[SetUp]
		public void Setup()
		{
			_navBar = new ExNavigationBar();
		}
		
		[Test]
		public void Can_create_instances()
		{
			Assert.That(_navBar, Is.Not.Null);
		}
		
		[Test]
		public void Starts_with_no_childre()
		{
			Assert.That(_navBar.HasChildren, Is.False);
		}
		
		[Test]
		public void Add_a_panel_sets_has_children_to_true()
		{
			_navBar.AddPanel(new ExNavigationPanel()) ;
			
			Assert.That(_navBar.HasChildren, Is.True);
		}
		
		[Test]
		public void Remove_()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() =>	
				_navBar.RemovePanelAt(0));
		}
	}
}