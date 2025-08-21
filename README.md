# Maintain the scroll position of ListView after clearing the filter
This example demonstrates how to maintain the scroll position when applying and clearing the filter of items at runtime.

## Sample

```xaml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="50"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <SearchBar x:Name="filterText"
        Placeholder="Search here to filter"
        Grid.Row="0" />

    <listView:SfListView x:Name="listView" ItemSize="70" Grid.Row="1" GroupHeaderSize="60" ItemTemplate="{StaticResource ItemTemplate}" GroupHeaderTemplate="{StaticResource GroupHeaderTemplate}"
                    ItemsSource="{Binding ContactsInfo}" ItemSpacing="0,0,5,0" AllowGroupExpandCollapse="True">
        <listView:SfListView.Behaviors>
            <local:Behaviours/>
        </listView:SfListView.Behaviors>
    </listView:SfListView>
</Grid>
```

See [How to maintain the scroll position of ListView after clearing the filter](https://www.syncfusion.com/kb/9535/how-to-maintain-the-scroll-position-of-listview-after-clearing-the-filter-at-runtime) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
