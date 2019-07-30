Imports System.Collections.ObjectModel
Imports System.Windows

Namespace FunnelChart
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateData As ObservableCollection(Of DataPoint)
		Public Property Data() As ObservableCollection(Of DataPoint)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As ObservableCollection(Of DataPoint))
				privateData = value
			End Set
		End Property
		Public Sub New()
			Data = New ObservableCollection(Of DataPoint) From {
				New DataPoint("Visited a Website", 9152),
				New DataPoint("Downloaded a Trial", 6870),
				New DataPoint("Contacted to Support", 5121),
				New DataPoint("Subscribed", 2224),
				New DataPoint("Renewed", 1670)
			}
		End Sub
		Public Class DataPoint
			Private privateArgument As String
			Public Property Argument() As String
				Get
					Return privateArgument
				End Get
				Private Set(ByVal value As String)
					privateArgument = value
				End Set
			End Property
			Private privateValue As Double
			Public Property Value() As Double
				Get
					Return privateValue
				End Get
				Private Set(ByVal value As Double)
					privateValue = value
				End Set
			End Property
			Public Sub New(ByVal argument As String, ByVal value As Double)
				Me.Argument = argument
				Me.Value = value
			End Sub
		End Class
	End Class
End Namespace
