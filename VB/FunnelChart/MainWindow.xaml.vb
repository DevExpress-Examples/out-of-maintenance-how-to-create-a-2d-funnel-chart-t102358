Imports System.Collections.ObjectModel
Imports System.Windows

Namespace FunnelChart

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ChartViewModel

        Private _Data As ObservableCollection(Of FunnelChart.ChartViewModel.DataPoint)

        Public Property Data As ObservableCollection(Of DataPoint)
            Get
                Return _Data
            End Get

            Private Set(ByVal value As ObservableCollection(Of DataPoint))
                _Data = value
            End Set
        End Property

        Public Sub New()
            Data = New ObservableCollection(Of DataPoint) From {New DataPoint("Visited a Website", 9152), New DataPoint("Downloaded a Trial", 6870), New DataPoint("Contacted to Support", 5121), New DataPoint("Subscribed", 2224), New DataPoint("Renewed", 1670)}
        End Sub

        Public Class DataPoint

            Private _Argument As String, _Value As Double

            Public Property Argument As String
                Get
                    Return _Argument
                End Get

                Private Set(ByVal value As String)
                    _Argument = value
                End Set
            End Property

            Public Property Value As Double
                Get
                    Return _Value
                End Get

                Private Set(ByVal value As Double)
                    _Value = value
                End Set
            End Property

            Public Sub New(ByVal argument As String, ByVal value As Double)
                Me.Argument = argument
                Me.Value = value
            End Sub
        End Class
    End Class
End Namespace
