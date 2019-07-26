using System.Collections.ObjectModel;
using System.Windows;

namespace FunnelChart {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public ObservableCollection<DataPoint> Data { get; private set; }
        public ChartViewModel() {
            Data = new ObservableCollection<DataPoint> {
                        new DataPoint ("Visited a Website", 9152),
                        new DataPoint ("Downloaded a Trial", 6870),
                        new DataPoint ("Contacted to Support", 5121),
                        new DataPoint ("Subscribed", 2224),
                        new DataPoint ("Renewed", 1670)
            };
        }
        public class DataPoint {
            public string Argument { get; private set; }
            public double Value { get; private set; }
            public DataPoint(string argument, double value) {
                Argument = argument;
                Value = value;
            }
        }
    }
}
