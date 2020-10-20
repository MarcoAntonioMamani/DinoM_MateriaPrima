
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class F_CrearCliente
    Public ClienteId As Integer = 0
    Public NombreCliente As String = ""
    Public bandera As Boolean = False
    Private Sub _prIniciarTodo()

        Me.Text = "CREAR CLIENTES"


        Dim blah As New Bitmap(New Bitmap(My.Resources.man_18), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico


    End Sub
    Private Sub F_CrearCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
        tbNombre.Focus()
    End Sub

    Private Sub btnEgresos_Click(sender As Object, e As EventArgs) Handles btnEgresos.Click
        If (tbNombre.Text = String.Empty) Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El  campo Nombre es requerido".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            tbNombre.Focus()
            Return

        End If

        Dim res As DataTable = L_fnGrabarCLiente02("", "", tbNombre.Text, tbNombre.Text, 1, 1, 1, "0", tbDireccion.Text, tbTelf1.Text, tbTelf2.Text, 1, 1, 0, 0, tbObs.Text, Now.Date.ToString("yyyy/MM/dd"), tbNombre.Text, 1, "0", "0", "0", Now.Date.ToString("yyyy/MM/dd"), Now.Date.ToString("yyyy/MM/dd"), "", 1)


        If res.Rows.Count > 0 Then

            ClienteId = res.Rows(0).Item("ydnumi")
            NombreCliente = res.Rows(0).Item("yddesc")
            bandera = True
            Me.Close()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "El Cliente no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            bandera = False

        End If

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        bandera = False
        Me.Close()

    End Sub
End Class