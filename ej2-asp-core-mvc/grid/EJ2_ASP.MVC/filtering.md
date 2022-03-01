---
layout: post
title: Filtering in ##Platform_Name## Grid Component
description: Learn here all about Filtering in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---


# Filtering

Filtering allows you to view particular records based on filter criteria. To enable filtering in the Grid, set the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to true. Filtering options can be configured through [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) property.

<!---
Grid supports two types of filter, they are:
* Filter bar
* Excel
-->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filter/filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filter/filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can apply and clear filtering by using [`filterByColumn`](https://ej2.syncfusion.com/documentation/api/grid/#filterbycolumn) and [`clearFiltering`](https://ej2.syncfusion.com/documentation/api/grid/#clearfiltering) methods.
> To disable filtering for a particular column, set
[`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) to false.

## Initial filter

To apply the filter at initial rendering, set the filter **Predicate** object in
[`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/initialfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initialfilter.cs" %}
{% include code-snippet/grid/filtering/initialfilter/initialfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/initialfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialfilter.cs" %}
{% include code-snippet/grid/filtering/initialfilter/initialfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Filter operators

The filter operator for a column can be defined in the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) property of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html).

The available operators and its supported data types are:

Operator |Description |Supported Types
-----|-----|-----
startswith |Checks whether the value begins with the specified value. |String
endswith |Checks whether the value ends with the specified value. |String
contains |Checks whether the value contains the specified value. |String
equal |Checks whether the value is equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
notequal |Checks for values not equal to the specified value. |String &#124; Number &#124; Boolean &#124; Date
greaterthan |Checks whether the value is greater than the specified value. |Number &#124; Date
greaterthanorequal|Checks whether a value is greater than or equal to the specified value. |Number &#124; Date
lessthan |Checks whether the value is less than the specified value. |Number &#124; Date
lessthanorequal |Checks whether the value is less than or equal to the specified value. |Number &#124; Date

> By default, the [`Operators`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Operators) value is **equal**.

## Filter bar

By setting the [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to true, the filter bar row will render next to the header, which allows you to filter data. You can filter the records with different expressions depending upon the column type.

 **Filter bar expressions:**

 You can enter the following filter expressions (operators) manually in the filter bar.

Expression |Example |Description |Column Type
-----|-----|-----|-----
= |=value |equal |Number
!= |!=value |notequal |Number
> |>value |greaterthan |Number
< |<value |lessthan |Number
>= |>=value |greaterthanorequal |Number
<=|<=value|lessthanorequal |Number
* |*value |startswith |String
% |%value |endswith |String
N/A |N/A | `equal` operator will always be used for date filter. |Date
N/A |N/A |`equal` operator will always be used for Boolean filter. |Boolean

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Filter bar template with custom component

The [`FilterBarTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) is used to add a custom component for a particular column and this contains the following functions.

* **create** – It is used for creating custom components.
* **read** – It is used to read the Filter value selected.
* **write** - It is used to wire events for custom components.

In the following sample dropdown is used  as custom component in EmployeeID column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filterbartemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbartemplate.cs" %}
{% include code-snippet/grid/filtering/filterbartemplate/filterbartemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filterbartemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filterbartemplate.cs" %}
{% include code-snippet/grid/filtering/filterbartemplate/filterbartemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Change default filterbar operator

You can change the default filter operator by extending filterOperators property in [`DataBound`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataBound) event. In the following sample,
we have changed the default operator for string typed columns as **contains** from **startsWith**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filteroptr/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filteroptr/filter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filteroptr/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter.cs" %}
{% include code-snippet/grid/filtering/filteroptr/filter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Filter menu

You can enable filter menu by setting the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) as **Menu**. The filter menu UI will be rendered based on its column type, which allows you to filter data.
You can filter the records with different operators.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filtermenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtermenu.cs" %}
{% include code-snippet/grid/filtering/filtermenu/filtermenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) must be set as true to enable filter menu.
> Setting [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_AllowFiltering) of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) as false will prevent filter menu rendering for a particular column.

### Enable different filter for a column

You can use both **Menu** and **CheckBox** filter in a same Grid. To do so, set the
[`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) of [`FilterSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html) as **Menu** and **CheckBox** in [`Filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

In the following sample menu filter is enabled by default and checkbox filter is enabled for the CustomerID column using the [`Filter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Filter) property of [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Diffcolumnfilter.cs" %}
{% include code-snippet/grid/filtering/diffcolumnfilter/diffcolumnfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Excel like filter

You can enable Excel like filter by defining [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as **Excel**. The excel menu contains an option such as Sorting, Clear filter, Sub menu for advanced filtering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/excelfilter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Excelfilter.cs" %}
{% include code-snippet/grid/filtering/excelfilter/excelfilter.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Customizing filter menu operators list](./how-to/customizing-filter-menu-operators-list)
* [Customizing Filter Dialog by using an additional parameter](./how-to/add-params-for-filtering)
* [Hide sorting options on Excel filter Dialog](./how-to/hide-sorting-in-excel-filter)