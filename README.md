# Maintain the scroll position of ListView after clearing the filter
This example demonstrates how to maintain the scroll position when applying and clearing the filter of items at runtime.

## Sample

```xaml
<Grid>
    <SearchBar x:Name="filterText"
        Placeholder="Search here to filter"
        Grid.Row="0" />

    <listView:SfListView x:Name="listView" Grid.Row="1"
                         ItemTemplate="{StaticResource ItemTemplate}"
                         ItemsSource="{Binding ContactsInfo}">
        <listView:SfListView.Behaviors>
            <local:Behaviours/>
        </listView:SfListView.Behaviors>
    </listView:SfListView>
</Grid>

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
```

See [How to maintain the scroll position of ListView after clearing the filter](https://www.syncfusion.com/kb/9535/how-to-maintain-the-scroll-position-of-listview-after-clearing-the-filter-at-runtime) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
