using System;
using Xamarin.Forms;

namespace GameStoreMobileApp
{
	public class SearchGame:ContentPage
	{
		public SearchGame(){
			this.BackgroundImage = "33.jpg";

			this.Title="Search";
			var label = new Label { 
				Text = "This is background check"
			};

			var layout = new StackLayout ();

			layout.Children.Add (new BoxView {Color = Color.Transparent, HeightRequest = 50});
			layout.Children.Add (label);

			Content = layout;
		}
	}

}

