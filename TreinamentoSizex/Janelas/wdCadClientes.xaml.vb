Public Class wdCadClientes

    Dim objCliente As Cliente
    Dim srcContatos As CollectionViewSource
    Dim srcCliente As CollectionViewSource
    Dim objContato As ClienteContatos
    Dim lstCliente As List(Of Cliente)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(tipo As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If tipo = "C" Then
            TituloLbl.Content = "- Cadastro de Clientes"
        Else
            TituloLbl.Content = "- Cadastro de Fornecedores"
            FotoCt.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub
#Region "Métodos - SUB - FUNCTION"
    Private Sub LimpaCampos(tipo As String)
        If tipo = "C" Or tipo = "T" Then
            NomeTxt.Text = ""
            CpfTxt.Text = ""
            RgTxt.Text = ""
            DataTxt.Text = ""
            InativoChk.IsChecked = False
            EndTxt.Text = ""
            BairroTxt.Text = ""
            CidadeTxt.Text = ""
            UfCmb.Text = ""
            CompleTxt.Text = ""
            objCliente = Nothing

        End If

        If tipo = "CT" Or tipo = "T" Then
            TipoTxt.Text = ""
            DadosTxt.Text = ""
            ObsTxt.Text = ""
            objContato = Nothing

        End If

    End Sub
    Private Function GravaCliente(Optional ByRef retorno As String = "") As Boolean

        retorno = "1-Validando campos"

        'Bloco If
        If CpfTxt.Text = "" Then
            MsgBox("CPF não informado, vefique!", MsgBoxStyle.Information, "Validação")
            CpfTxt.Focus()
            Return False
        ElseIf Not IsDate(DataTxt.Text) Then
            MsgBox("Data do cadastro não é válida, verifique !", MsgBoxStyle.Information, "Validação")
            DataTxt.Focus()
            Return False

        ElseIf NomeTxt.Text = "" Then
            MsgBox("Nome não informado, verifique !", MsgBoxStyle.Information, "Validação")
            NomeTxt.Focus()
            Return False

        End If
        retorno = "2-Inserindo objeto"
        If objCliente Is Nothing Then
            objCliente = New Cliente
            objCliente.Contatos = New List(Of ClienteContatos)
            lstCliente.Add(objCliente)
        End If
        retorno = "3-Gravando campos cliente"
        objCliente.Cpf = CpfTxt.Text
        objCliente.Rg = RgTxt.Text
        objCliente.Nome = NomeTxt.Text
        objCliente.Numero = NumTxt.Text
        objCliente.DataCadastro = DataTxt.Text
        objCliente.Inativo = InativoChk.IsChecked
        objCliente.Endereco = EndTxt.Text
        objCliente.Bairro = BairroTxt.Text
        objCliente.Cidade = CidadeTxt.Text
        objCliente.UfCmb = UfCmb.Text
        objCliente.Complemento = CompleTxt.Text


        objCliente.Usuario = InputBox("Informe o seu nome para gravação do cliente", "Auditoria", "")
        objCliente.DataCadastro = Date.Now
        retorno = "4-Concluída gravação"
        Return True

    End Function
#End Region

    Private Sub SairBtn_Click(sender As Object, e As RoutedEventArgs) Handles SairBtn.Click
        Me.Close()
    End Sub

    Private Sub Window_Loaded_1(sender As Object, e As RoutedEventArgs)
        FotoCt.Content = New ucCadFotos
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As RoutedEventArgs) Handles AddBtn.Click
        Dim retorno As String = ""
        Try
            If GravaCliente(retorno) = False Then
                Exit Sub
            End If
            If objContato Is Nothing Then
                objContato = New ClienteContatos
                objCliente.Contatos.Add(objContato)
            End If
            objContato.TipoContato = TipoTxt.Text
            objContato.DadosContato = DadosTxt.Text
            objContato.Obs = ObsTxt.Text
            'Concatenação & 
            'Pular linha vbNewLine
            Dim mensagem As String = "Contato salvo com sucesso !" & vbNewLine & "Total de registros: " & objCliente.Contatos.Count
            MsgBox(mensagem, MsgBoxStyle.Information, "Parabéns")
            'ViewSource
            srcContatos.Source = objCliente.Contatos.ToList

            LimpaCampos("CT")
        Catch ex As Exception
            MsgBox(retorno & vbNewLine & "Ocorreu um erro no sistema, entre em contato com a SIZEX!" & vbNewLine & "(" & ex.Message, MsgBoxStyle.Critical & ")", "Gravar Cliente")
        End Try

    End Sub

    Private Sub SalvarBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalvarBtn.Click

        If GravaCliente() = False Then
            Exit Sub
        End If
        srcCliente.Source = lstCliente.ToList

        MsgBox("Registro salvo com sucesso !", MsgBoxStyle.Information, "Parabéns")
        LimpaCampos("T")
        RgTxt.Focus()
    End Sub

    Private Sub NovoBtn_Click(sender As Object, e As RoutedEventArgs) Handles NovoBtn.Click
        LimpaCampos("T")
    End Sub

    Private Sub ExcluirBtn_Click(sender As Object, e As RoutedEventArgs) Handles ExcluirBtn.Click
        LimpaCampos("C")
    End Sub

    Private Sub wdCadClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.Key
            Case Key.F2
                NovoBtn_Click(Nothing, Nothing)
            Case Key.F3
                SalvarBtn_Click(Nothing, Nothing)
            Case Key.F4
                ExcluirBtn_Click(Nothing, Nothing)
            Case Key.Escape
                SairBtn_Click(Nothing, Nothing)
        End Select

    End Sub

    Private Sub wdCadClientes_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        srcContatos = CType(Me.FindResource("ClienteContatosViewSource"), CollectionViewSource)
        srcCliente = CType(Me.FindResource("ClienteViewSource"), CollectionViewSource)
        lstCliente = New List(Of Cliente)
        DataTxt.Text = Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub DataGrid_MouseDoubleClick_1(sender As Object, e As MouseButtonEventArgs) Handles ContatosDataGrid.MouseDoubleClick
        If sender.selecteditem IsNot Nothing Then
            objContato = CType(sender.selecteditem, ClienteContatos)
            TipoTxt.Text = objContato.TipoContato
            DadosTxt.Text = objContato.DadosContato
            ObsTxt.Text = objContato.Obs

        End If

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As RoutedEventArgs) Handles CancelBtn.Click
        If objCliente Is Nothing Then
            MsgBox("Nenhum cliente selecionado para a exclusão!", MsgBoxStyle.Information, "Exclusão de Contato")
            Exit Sub
        ElseIf objContato Is Nothing Then
            MsgBox("Nenhum cliente selecionado para a exclusão!", MsgBoxStyle.Information, "Exclusão de Contato")
            Exit Sub
        End If
        objCliente.Contatos.Remove(objContato)
        srcContatos.Source = objCliente.Contatos.ToList

        MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information, "Parabéns")
        LimpaCampos("CT")
    End Sub


    Private Sub ClienteDataGrid_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles ClienteDataGrid.MouseDoubleClick
        If sender.selecteditem IsNot Nothing Then
            objCliente = sender.selecteditem
            RgTxt.Text = objCliente.Rg
            CpfTxt.Text = objCliente.Cpf
            NomeTxt.Text = objCliente.Nome
            BairroTxt.Text = objCliente.Bairro
            CidadeTxt.Text = objCliente.Cidade
            EndTxt.Text = objCliente.Endereco
            NumTxt.Text = objCliente.Numero
            UfCmb.Text = objCliente.UfCmb
            CompleTxt.Text = objCliente.Complemento
            DataTxt.Text = objCliente.DataCadastro
            InativoChk.IsChecked = objCliente.Inativo

            srcContatos.Source = objCliente.Contatos.ToList

            PrincipalTb.SelectedItem = CadTb
            e.Handled = True
        End If

    End Sub
End Class
