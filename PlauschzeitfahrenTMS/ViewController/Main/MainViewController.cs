#region "Internal Libraries"
using Foundation;
using UIKit;
using System;
using System.Collections.Generic;
#endregion
#region "Importet Libraries"
#endregion
#region "Own Classes"
#endregion

namespace PlauschzeitfahrenTMS
{
	partial class MainViewController : UIViewController
	{
		#region "### Properties #############################################"
		private DatabaseModel _database;
		#endregion

		#region "### Constructors #############################################"
		public MainViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region "### Deconstructors #############################################"
		#endregion

		#region "### UI Methods #############################################"
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Console.WriteLine("MainViewController.ViewDidLoad()");
			_database = new DatabaseModel ();


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
			


		partial void btnInitDatabase_touchUpInside (UIButton sender)
		{
			_database.deleteDatabase();
			_database = new DatabaseModel ();
	
		}

		partial void btnLoadCompetitors_touchUpInside (UIButton sender)
		{
			var participants = new List<Person>(); 
			participants.Add(new Person(true));
			participants.Add(new Person(true));
			participants.Add(new Person(true));


			_database.connect();
			foreach(Person paticipant in participants)
			{
				_database._connection.Insert(paticipant);
			}
			_database.disconnect();

		}

		#endregion

		#region "### Private Methods #############################################"
		#endregion


		#region "### Public Methods #############################################"
		#endregion
	}
}




