<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569039/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T102358)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/FunnelChart/MainWindow.xaml)**
<!-- default file list end -->
# How to create a 2D Funnel chart


<p>The following example demonstrates how to create a 2D Funnel chart.</p>
<p>For this, it's necessary to create a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsChartControltopic"><u>ChartControl</u></a>, choose a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsSimpleDiagram2Dtopic"><u>SimpleDiagram2D</u></a> object as its diagram and put <strong> FunnelSeries2D</strong> into its <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsDiagram_Seriestopic"><u>Series</u></a> collection. Each point of a funnel series should contain an argument and a value.</p>
<p>Note that in this sample the label's <strong>TextPattern</strong> and<strong> LegendTextPattern</strong> properties are set to "{}{A}: {VP: ##.##%}", which allows showing a point's argument and its percentage value separated by a colon. The available placeholders are detailed below.<br /><strong>{A}</strong>     Use it to display a series point's arguments.</p>
<p><strong>{VP}</strong>   Use it to display a series point's values as percent.</p>
<p><strong>{S}</strong>     Use it to display the series name.</p>

<br/>


