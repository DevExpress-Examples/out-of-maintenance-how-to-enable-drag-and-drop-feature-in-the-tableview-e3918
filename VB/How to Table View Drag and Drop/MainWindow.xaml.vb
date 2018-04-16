Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Collections.ObjectModel

Namespace How_to_Table_View_Drag_and_Drop
	Partial Public Class MainWindow
		Inherits Window
		Public Class Employee
			Private privateID As Integer
			Public Property ID() As Integer
				Get
					Return privateID
				End Get
				Set(ByVal value As Integer)
					privateID = value
				End Set
			End Property
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
			Private privatePosition As String
			Public Property Position() As String
				Get
					Return privatePosition
				End Get
				Set(ByVal value As String)
					privatePosition = value
				End Set
			End Property
			Private privateDepartment As String
			Public Property Department() As String
				Get
					Return privateDepartment
				End Get
				Set(ByVal value As String)
					privateDepartment = value
				End Set
			End Property
			Public Overrides Function ToString() As String
				Return Name
			End Function
		End Class

		Public NotInheritable Class Stuff
			Private Sub New()
			End Sub
			Public Shared Function GetStuff() As ObservableCollection(Of Employee)
				Dim stuff As New ObservableCollection(Of Employee)()
				stuff.Add(New Employee() With {.ID = 1, .Name = "Gregory S. Price", .Department = "", .Position = "President"})
				stuff.Add(New Employee() With {.ID = 2, .Name = "Irma R. Marshall", .Department = "Marketing", .Position = "Vice President"})
				stuff.Add(New Employee() With {.ID = 3, .Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"})
				stuff.Add(New Employee() With {.ID = 4, .Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"})
				stuff.Add(New Employee() With {.ID = 5, .Name = "Karen J. Kelly", .Department = "Finance", .Position = "Vice President"})

				stuff.Add(New Employee() With {.ID = 6, .Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 7, .Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 8, .Name = "Angel M. Wilson", .Department = "Marketing", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 9, .Name = "Bryan R. Henderson", .Department = "Marketing", .Position = "Manager"})

				stuff.Add(New Employee() With {.ID = 10, .Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 11, .Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 12, .Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 13, .Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"})

				stuff.Add(New Employee() With {.ID = 14, .Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 15, .Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 16, .Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"})

				stuff.Add(New Employee() With {.ID = 17, .Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"})
				stuff.Add(New Employee() With {.ID = 18, .Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"})
				Return stuff
			End Function
		End Class
		Public Sub New()
			InitializeComponent()
			gridControl.ItemsSource = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
