Imports System.ComponentModel

Public Class Ingreso_pruebas
    'Variables globales 
    Dim activo, recuperado, muerto As Integer
    Dim activo1, recuperado1, muerto1 As Integer
    Dim activo2, recuperado2, muerto2 As Integer
    Dim activo3, recuperado3, muerto3 As Integer
    Dim activo4, recuperado4, muerto4 As Integer
    Dim activo5, recuperado5, muerto5 As Integer
    Dim activo6, recuperado6, muerto6 As Integer
    Dim activo7, recuperado7, muerto7 As Integer
    Dim activo8, recuperado8, muerto8 As Integer
    Dim activo9, recuperado9, muerto9 As Integer
    Dim activo10, recuperado10, muerto10 As Integer
    Dim activo11, recuperado11, muerto11 As Integer
    Dim activo12, recuperado12, muerto12 As Integer
    Dim activo13, recuperado13, muerto13 As Integer
    Dim activo14, recuperado14, muerto14 As Integer
    Dim activo15, recuperado15, muerto15 As Integer
    Dim activo16, recuperado16, muerto16 As Integer
    Dim activo17, recuperado17, muerto17 As Integer

    Private Sub btnLingreso_Click(sender As Object, e As EventArgs) Handles btnLingreso.Click
        txtNombre.Text = ""
        txtEdad.Text = ""
        cmbDepto.Text = ""
        txtMunicipio.Text = ""
        cmbPrueba.Text = ""
        chkActivo.Checked = False
        chkMuerto.Checked = False
        chkRecuperado.Checked = False
        txtDescripcion.Text = ""
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        txtNombre.Text = ""
        txtEdad.Text = ""
        cmbDepto.Text = ""
        txtMunicipio.Text = ""
        cmbPrueba.Text = ""
        chkActivo.Checked = False
        chkMuerto.Checked = False
        chkRecuperado.Checked = False
        txtDescripcion.Text = ""
        cmbdeptoR.Text = ""
        lstHistorial.Items.Clear()
        txtActivo.Text = ""
        txtMuertos.Text = ""
        txtRecuperados.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Ingreso_pruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkActivo.Enabled = False
        chkMuerto.Enabled = False
        chkRecuperado.Enabled = False
    End Sub

    Private Sub cmbPrueba_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrueba.SelectedIndexChanged
        If cmbPrueba.Text = "Positivo" Then
            chkActivo.Enabled = True
            chkMuerto.Enabled = True
            chkRecuperado.Enabled = False
        ElseIf cmbPrueba.Text = "Negativo" Then
            chkRecuperado.Enabled = True
            chkActivo.Enabled = False
            chkMuerto.Enabled = False
        End If
    End Sub
    'Sugerencias del programa
    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingrese un valor entero (0)")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese el municipio en el que reside el paciente")
        ToolTip1.ToolTipTitle = "Municipio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPrueba_MouseHover(sender As Object, e As EventArgs) Handles cmbPrueba.MouseHover
        ToolTip1.SetToolTip(cmbPrueba, "Seleccione una opción")
        ToolTip1.ToolTipTitle = "Resultado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Agregue una pequeña descripción del estado del paciente")
        ToolTip1.ToolTipTitle = "Descripción"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepto_MouseHover(sender As Object, e As EventArgs) Handles cmbDepto.MouseHover
        ToolTip1.SetToolTip(cmbDepto, "Ingrese el departamento en el que reside el paciente")
        ToolTip1.ToolTipTitle = "Departamento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    'Proceso
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtMunicipio.Text <> String.Empty Then
                If cmbDepto.Text = "Santa Bárbara" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo = activo + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado = recuperado + 1
                        Else
                            muerto = muerto + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Olancho" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo1 = activo1 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado1 = recuperado1 + 1
                        Else
                            muerto1 = muerto1 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Gracias a Dios" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo2 = activo2 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado2 = recuperado2 + 1
                        Else
                            muerto2 = muerto2 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "El Paraiso" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo3 = activo3 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado3 = recuperado3 + 1
                        Else
                            muerto3 = muerto3 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Ocotepeque" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo4 = activo4 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado4 = recuperado4 + 1
                        Else
                            muerto4 = muerto4 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Lempira" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo5 = activo5 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado5 = recuperado5 + 1
                        Else
                            muerto5 = muerto5 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Intibucá" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo6 = activo6 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado6 = recuperado6 + 1
                        Else
                            muerto6 = muerto6 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Comayagua" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo7 = activo7 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado7 = recuperado7 + 1
                        Else
                            muerto7 = muerto7 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Colón" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo8 = activo8 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado8 = recuperado8 + 1
                        Else
                            muerto8 = muerto8 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Atlántida" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo9 = activo9 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado9 = recuperado9 + 1
                        Else
                            muerto9 = muerto9 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Choluteca" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo10 = activo10 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado10 = recuperado10 + 1
                        Else
                            muerto10 = muerto10 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Francisco Morazán" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo11 = activo11 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado11 = recuperado11 + 1
                        Else
                            muerto11 = muerto11 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Cortés" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo12 = activo12 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado12 = recuperado12 + 1
                        Else
                            muerto12 = muerto12 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Valle" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo13 = activo13 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado13 = recuperado13 + 1
                        Else
                            muerto13 = muerto13 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Copán" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo14 = activo14 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado14 = recuperado14 + 1
                        Else
                            muerto14 = muerto14 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Yoro" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo15 = activo15 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado15 = recuperado15 + 1
                        Else
                            muerto15 = muerto15 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "Islas de la Bahía" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo16 = activo16 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado16 = recuperado16 + 1
                        Else
                            muerto16 = muerto16 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
                If cmbDepto.Text = "La Paz" Then
                    If cmbPrueba.Text = "Positivo" Or cmbPrueba.Text = "Negativo" Then
                        If chkActivo.Checked = True Then
                            activo17 = activo17 + 1
                        ElseIf chkRecuperado.Checked = True Then
                            recuperado17 = recuperado17 + 1
                        Else
                            muerto17 = muerto17 + 1
                        End If
                    End If
                    lstHistorial.Items.Add(txtNombre.Text)
                    lstHistorial.Items.Add(cmbDepto.SelectedItem)
                    lstHistorial.Items.Add(cmbPrueba.SelectedItem)
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbdeptoR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeptoR.SelectedIndexChanged
        If cmbdeptoR.Text = "Santa Bárbara" Then
            txtActivo.Text = activo
            txtMuertos.Text = muerto
            txtRecuperados.Text = recuperado
        End If
        If cmbdeptoR.Text = "Olancho" Then
            txtActivo.Text = activo1
            txtMuertos.Text = muerto1
            txtRecuperados.Text = recuperado1
        End If
        If cmbdeptoR.Text = "Gracias a Dios" Then
            txtActivo.Text = activo3
            txtMuertos.Text = muerto3
            txtRecuperados.Text = recuperado3
        End If
        If cmbdeptoR.Text = "Ocotepeque" Then
            txtActivo.Text = activo4
            txtMuertos.Text = muerto4
            txtRecuperados.Text = recuperado4
        End If
        If cmbdeptoR.Text = "Lempira" Then
            txtActivo.Text = activo5
            txtMuertos.Text = muerto5
            txtRecuperados.Text = recuperado5
        End If
        If cmbdeptoR.Text = "Intibucá" Then
            txtActivo.Text = activo6
            txtMuertos.Text = muerto6
            txtRecuperados.Text = recuperado6
        End If
        If cmbdeptoR.Text = "Comayagua" Then
            txtActivo.Text = activo7
            txtMuertos.Text = muerto7
            txtRecuperados.Text = recuperado7
        End If
        If cmbdeptoR.Text = "Coloón" Then
            txtActivo.Text = activo8
            txtMuertos.Text = muerto8
            txtRecuperados.Text = recuperado8
        End If
        If cmbdeptoR.Text = "Atlántida" Then
            txtActivo.Text = activo9
            txtMuertos.Text = muerto9
            txtRecuperados.Text = recuperado9
        End If
        If cmbdeptoR.Text = "Choluteca" Then
            txtActivo.Text = activo10
            txtMuertos.Text = muerto10
            txtRecuperados.Text = recuperado10
        End If
        If cmbdeptoR.Text = "Francisco Morazán" Then
            txtActivo.Text = activo11
            txtMuertos.Text = muerto11
            txtRecuperados.Text = recuperado11
        End If
        If cmbdeptoR.Text = "Cortés" Then
            txtActivo.Text = activo12
            txtMuertos.Text = muerto12
            txtRecuperados.Text = recuperado12
        End If
        If cmbdeptoR.Text = "Valle" Then
            txtActivo.Text = activo13
            txtMuertos.Text = muerto13
            txtRecuperados.Text = recuperado13
        End If
        If cmbdeptoR.Text = "Copán" Then
            txtActivo.Text = activo14
            txtMuertos.Text = muerto14
            txtRecuperados.Text = recuperado14
        End If
        If cmbdeptoR.Text = "Yoro" Then
            txtActivo.Text = activo15
            txtMuertos.Text = muerto15
            txtRecuperados.Text = recuperado15
        End If
        If cmbdeptoR.Text = "Islas de la Bahía" Then
            txtActivo.Text = activo16
            txtMuertos.Text = muerto16
            txtRecuperados.Text = recuperado16
        End If
        If cmbdeptoR.Text = "La Paz" Then
            txtActivo.Text = activo17
            txtMuertos.Text = muerto17
            txtRecuperados.Text = recuperado17
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class