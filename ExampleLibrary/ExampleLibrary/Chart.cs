using XPlot.Plotly;

namespace ExampleLibrary
{
    public static class Chart
    {
        public static PlotlyChart ChartSeries(List<double> y, string title)
        {
            var layout = new Layout.Layout
            {
                title = title
            };

            var scatter = new Scatter
            {
                x = Enumerable.Range(0, y.Count),
                y = y
            };

            return XPlot.Plotly.Chart.Plot(scatter, layout);
        }
    }
}