---
layout: post
title: Exporting Filtered Data in ##Platform_Name## Grid Component
description: Learn here all about Exporting Filtered Data in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Filtered Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Filtered Data Only

You can export the filtered data by defining the resulted data in **exportProperties.dataSource** before export.

In the below Pdf exporting demo, We have gotten the filtered data by applying filter query to the grid data and then defines the resulted data in **exportProperties.dataSource** and pass it to **pdfExport** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-filtered-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filtered-data.cs" %}
{% include code-snippet/grid/how-to/export-filtered-data/export-filtered-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-filtered-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Export-filtered-data.cs" %}
{% include code-snippet/grid/how-to/export-filtered-data/export-filtered-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

