using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MaintainScrollPosition
{
    public class Behaviours : Behavior<SfListView>
    {
        private SfListView listView;
        private SearchBar searchBar = null;
        ExtendedScrollView scrollview;
        double position;
        protected override void OnAttachedTo(BindableObject bindable)
        {
            listView = bindable as SfListView;
            searchBar = (bindable as SfListView).FindByName<SearchBar>("filterText");
            searchBar.TextChanged += SearchBar_TextChanged;
            scrollview = listView.GetScrollView();
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(BindableObject bindable)
        {
            listView = null;
            searchBar = null;
            searchBar.TextChanged -= SearchBar_TextChanged;
            base.OnDetachingFrom(bindable);
        }
        #region Private Methods
        private bool FilterContacts(object obj)
        {
            if (searchBar == null || searchBar.Text == null)
                return true;

            var contacts = obj as Contacts;
            if (contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower())
                || contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower()))
                return true;
            else
                return false;
        }

        #endregion

        #region CallBacks


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchBar.Text != "")
                position = scrollview.ScrollY;

            searchBar = (sender as SearchBar);
            if (listView.DataSource != null)
            {
                this.listView.DataSource.Filter = FilterContacts;
                this.listView.DataSource.RefreshFilter();
            }
            if (searchBar.Text == "")
                listView.ScrollTo(position);
            else if (searchBar.Text == "")
                listView.ScrollTo(position);
        }
        #endregion

    }
}
