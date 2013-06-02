Imports GeradorPDF

Public Class RptOrdens

    Function relatorioOrdens(ByVal ordem As Ordem, ByVal cliente As String) As Boolean

        Try
            Dim temp As String = cliente
            Dim acessoOrdemModel As New OrdemModel
            Dim acessoClienteModel As New clienteModel
            Dim rptOrdens As New PDF()
            Dim dr As OleDb.OleDbDataReader
            Dim intNpag As Integer = 0
            Dim intAux As Integer = 0
            Dim datHoje As DateTime = DateTime.Now
            Dim cont As Integer = 0


            temp = acessoClienteModel.getClienteById(ordem.cliente_id).nome

            dr = acessoOrdemModel.getOrdensRpt(ordem, temp)

            rptOrdens.Autor = "André Peil"
            rptOrdens.Titulo = "S-Ordem - Sistema de Gerenciamento de Ordens de Serviço"
            rptOrdens.AdicionarPG()

            rptOrdens.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptOrdens.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptOrdens.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)
            rptOrdens.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
            rptOrdens.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

            rptOrdens.InserirIMG(intNpag, Application.StartupPath & "\imagens\paper.jpg", 30, 180, 48, 48, 100)
            rptOrdens.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
            rptOrdens.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
            rptOrdens.DesenharTexto(intNpag, 100, 135, "RELATÓRIO DE ORDENS DE SERVIÇO", 16)
            rptOrdens.DesenharTexto(intNpag, 100, 155, "Data: " & Format(datHoje, "dd-MM-yyyy"), 10)
            rptOrdens.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
            rptOrdens.DesenharLinha(intNpag, 24, 190, 570, 190, 1)


            rptOrdens.DesenharTexto(intNpag, 20, 215, "NR.", 10)
            rptOrdens.DesenharTexto(intNpag, 50, 215, "CLIENTE", 10)
            rptOrdens.DesenharTexto(intNpag, 160, 215, "ESTADO", 10)
            rptOrdens.DesenharTexto(intNpag, 250, 215, "DT. ENT.", 10)
            rptOrdens.DesenharTexto(intNpag, 315, 215, "DT. SAIDA", 10)
            rptOrdens.DesenharTexto(intNpag, 385, 215, "MARCA", 10)
            rptOrdens.DesenharTexto(intNpag, 440, 215, "MODELO", 10)
            rptOrdens.DesenharTexto(intNpag, 490, 215, "TAXA", 10)
            rptOrdens.DesenharTexto(intNpag, 525, 215, "USUARIO", 10)
            rptOrdens.DesenharLinha(intNpag, 20, 230, 570, 230, 1)


            If dr.HasRows Then
                intAux = 240
                While dr.Read
                    If (cont Mod 2) = 0 Then
                        rptOrdens.DesenharRetangulo(intNpag, 20, intAux, 550, 18, 1, "", Color.LightGray, Color.LightGray)
                    End If
                    rptOrdens.DesenharTexto(intNpag, 25, intAux, dr.Item("nr_ordem"), 10)
                    rptOrdens.DesenharTexto(intNpag, 50, intAux, dr.Item("cliente"), 10)
                    rptOrdens.DesenharTexto(intNpag, 160, intAux, dr.Item("estado"), 10)
                    rptOrdens.DesenharTexto(intNpag, 250, intAux, dr.Item("dt_entrada"), 10)
                    rptOrdens.DesenharTexto(intNpag, 315, intAux, dr.Item("dt_saida"), 10)
                    rptOrdens.DesenharTexto(intNpag, 385, intAux, dr.Item("marca"), 10)
                    rptOrdens.DesenharTexto(intNpag, 440, intAux, dr.Item("modelo"), 10)
                    rptOrdens.DesenharTexto(intNpag, 490, intAux, dr.Item("preco_concerto"), 10)
                    rptOrdens.DesenharTexto(intNpag, 525, intAux, dr.Item("usuario"), 10)
                    intAux = intAux + 20
                    cont = cont + 1
                    If intAux > 750 Then
                        rptOrdens.AdicionarPG()
                        intNpag = intNpag + 1

                        rptOrdens.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
                        rptOrdens.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
                        rptOrdens.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)
                        rptOrdens.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
                        rptOrdens.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

                        rptOrdens.InserirIMG(intNpag, Application.StartupPath & "\imagens\paper.jpg", 30, 180, 48, 48, 100)
                        rptOrdens.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
                        rptOrdens.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
                        rptOrdens.DesenharTexto(intNpag, 100, 135, "RELATÓRIO DE ORDENS DE SERVIÇO", 16)
                        rptOrdens.DesenharTexto(intNpag, 100, 155, "Data: " & Format(datHoje, "dd-MM-yyyy"), 10)
                        rptOrdens.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
                        rptOrdens.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

                        rptOrdens.DesenharTexto(intNpag, 25, 215, "NR.", 10)
                        rptOrdens.DesenharTexto(intNpag, 50, 215, "CLIENTE", 10)
                        rptOrdens.DesenharTexto(intNpag, 160, 215, "ESTADO", 10)
                        rptOrdens.DesenharTexto(intNpag, 250, 215, "DT. ENT.", 10)
                        rptOrdens.DesenharTexto(intNpag, 315, 215, "DT. SAIDA", 10)
                        rptOrdens.DesenharTexto(intNpag, 385, 215, "MARCA", 10)
                        rptOrdens.DesenharTexto(intNpag, 440, 215, "MODELO", 10)
                        rptOrdens.DesenharTexto(intNpag, 490, 215, "TAXA", 10)
                        rptOrdens.DesenharTexto(intNpag, 525, 215, "USUARIO", 10)
                        rptOrdens.DesenharLinha(intNpag, 20, 230, 570, 230, 1)

                        intAux = 220
                    End If

                    rptOrdens.DesenharTexto(intNpag, 550, 780, intNpag + 1, 8)
                    rptOrdens.DesenharLinha(intNpag, 420, 795, 570, 795, 1)
                    rptOrdens.DesenharTexto(intNpag, 430, 800, "* Criado por Peil , contato: andreguipeil@gmail.com", 6)
                End While

                rptOrdens.DesenharLinha(intNpag, 20, intAux, 570, intAux, 1)
                rptOrdens.DesenharLinha(intNpag, 20, intAux + 2, 570, intAux + 2, 1)
                rptOrdens.DesenharTexto(intNpag, 20, intAux + 12, "Total de Ordens: ", 8)
                rptOrdens.DesenharTexto(intNpag, 90, intAux + 12, cont, 8)
            End If
            acessoClienteModel.Desconectar()


            rptOrdens.GerarArquivo(System.Windows.Forms.Application.StartupPath & "\rptOrdens.pdf")
            rptOrdens.Dispose()

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\rptOrdens.pdf")

            Return True
        Catch ex As Exception ' se gera erro pega  descricao do erro na variavel ex
            MsgBox("Erro ao abrir PDF : " & ex.ToString()) ' mostra na tela
        End Try

        Return False
    End Function


    Private rptOrdem As New PDF()
    Public Function relatorioOrdem(ByVal ordemId As Integer) As Boolean
        Dim acessoClienteModel As New clienteModel
        Dim cliente As New Cliente
        Dim acessoOrdemModel As New OrdemModel
        Dim ordem As New Ordem
        Dim marca As String
        Dim estado As String
        Dim acessoUsuarioModel As New usuarioModel
        Dim usuario As New Usuario

        ordem = acessoOrdemModel.getOrdemById(ordemId)
        cliente = acessoClienteModel.getClienteById(ordem.cliente_id)
        estado = acessoOrdemModel.getOrdemEstado(ordem.ordem_estado_id)
        marca = acessoOrdemModel.getMarca(ordem.marca_id)
        usuario = acessoUsuarioModel.getUsuarioById(ordem.usuario_id)


        Try

            Dim intNpag As Integer = 0
            Dim intAux As Integer = 0
            Dim datHoje As DateTime = DateTime.Now


            rptOrdem.Autor = "André Peil"
            rptOrdem.Titulo = "S-Ordem - Sistema de Gerenciamento de Ordens de Serviço"
            rptOrdem.AdicionarPG()
            'rptClientes.InserirIMG(intNpag, Application.StartupPath & "\imagens\celulares2.jpg", 35, 105, 69, 64, 100)

            'rptClientes.DesenharLinha(intNpag, 25, 52, 570, 52, 1)
            rptOrdem.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptOrdem.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptOrdem.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)
            rptOrdem.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
            rptOrdem.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

            rptOrdem.InserirIMG(intNpag, Application.StartupPath & "\imagens\paper.jpg", 30, 180, 48, 48, 100)
            rptOrdem.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
            rptOrdem.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
            rptOrdem.DesenharTexto(intNpag, 100, 135, "ORDEM DE SERVIÇO: Nr. " & ordem.id, 16)
            rptOrdem.DesenharTexto(intNpag, 100, 155, "Data de Entrada: " & ordem.dt_entrada & " - Data de Saida: " & ordem.dt_saida, 10)
            rptOrdem.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
            rptOrdem.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

            rptOrdem.DesenharTexto(intNpag, 45, 200, "CLIENTE", 12)
            rptOrdem.DesenharLinha(intNpag, 40, 215, 200, 215, 1)
            rptOrdem.DesenharTexto(intNpag, 65, 225, "Nome: ", 8)
            rptOrdem.DesenharTexto(intNpag, 95, 225, "" & cliente.nome, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 245, "RG: ", 8)
            rptOrdem.DesenharTexto(intNpag, 95, 245, "" & cliente.rg, 8)

            rptOrdem.DesenharTexto(intNpag, 45, 260, "CONTATO", 12)
            rptOrdem.DesenharLinha(intNpag, 40, 275, 200, 275, 1)
            rptOrdem.DesenharTexto(intNpag, 65, 285, "Telefone 1: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 285, "(" & cliente.ddd_1 & ")" & cliente.telefone_1, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 305, "Telefone 2: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 305, "(" & cliente.ddd_2 & ")" & cliente.telefone_2, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 325, "Telefone 3: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 325, "(" & cliente.ddd_3 & ")" & cliente.telefone_3, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 345, "Email: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 345, "" & cliente.email, 8)

            rptOrdem.DesenharTexto(intNpag, 300, 200, "ORDEM DE SERVIÇO", 12)
            rptOrdem.DesenharLinha(intNpag, 295, 215, 455, 215, 1)
            rptOrdem.DesenharLinha(intNpag, 295, 217, 455, 217, 1)
            rptOrdem.DesenharTexto(intNpag, 315, 225, "Marca: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 225, "" & marca, 8)
            rptOrdem.DesenharTexto(intNpag, 315, 245, "Modelo: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 245, "" & ordem.modelo, 8)
            rptOrdem.DesenharTexto(intNpag, 315, 266, "Estado da Ordem: ", 8)
            rptOrdem.DesenharTexto(intNpag, 385, 266, "" & estado, 8)

            rptOrdem.DesenharTexto(intNpag, 315, 285, "Defeito: ", 8)
            ordem.defeito = Replace(ordem.defeito, vbCrLf, " ")
            If ordem.defeito.Length > 50 Then
                validaCampoGrande(ordem.defeito, 285)
            Else
                rptOrdem.DesenharTexto(intNpag, 345, 285, "" & ordem.defeito, 8)
            End If
            
            rptOrdem.DesenharTexto(intNpag, 315, 305, "Laudo: ", 8)
            ordem.laudo = Replace(ordem.laudo, vbCrLf, " ")
            If ordem.laudo.Length > 50 Then
                validaCampoGrande(ordem.laudo, 305)
            Else
                rptOrdem.DesenharTexto(intNpag, 345, 305, "" & ordem.laudo, 8)
            End If

            rptOrdem.DesenharTexto(intNpag, 315, 325, "Taxa: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 325, " R$ " & ordem.preco_concerto, 8)

            rptOrdem.DesenharTexto(intNpag, 315, 345, "Observação: ", 8)
            ordem.observacao = Replace(ordem.observacao, vbCrLf, " ")
            If ordem.observacao.Length > 50 Then
                validaCampoGrande(ordem.observacao, 345)
            Else
                rptOrdem.DesenharTexto(intNpag, 365, 345, ordem.observacao, 8)
            End If



            '
            '=========================================================
            '

            rptOrdem.DesenharTexto(intNpag, 80, 465, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptOrdem.DesenharTexto(intNpag, 80, 485, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptOrdem.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 510, 48, 48, 100)
            rptOrdem.DesenharLinha(intNpag, 25, 510, 570, 510, 1)
            rptOrdem.DesenharLinha(intNpag, 25, 512, 570, 512, 1)

            rptOrdem.InserirIMG(intNpag, Application.StartupPath & "\imagens\paper.jpg", 30, 580, 48, 48, 100)
            rptOrdem.DesenharLinha(intNpag, 85, 540, 85, 590, 1)
            rptOrdem.DesenharLinha(intNpag, 90, 540, 90, 590, 1)
            rptOrdem.DesenharTexto(intNpag, 100, 545, "ORDEM DE SERVIÇO: Nr. " & ordem.id, 16)
            rptOrdem.DesenharTexto(intNpag, 100, 565, "Data de Entrada: " & ordem.dt_entrada & " - Data de Saida: " & ordem.dt_saida, 10)
            rptOrdem.DesenharLinha(intNpag, 24, 595, 570, 595, 1)
            rptOrdem.DesenharLinha(intNpag, 24, 600, 570, 600, 1)

            rptOrdem.DesenharTexto(intNpag, 45, 610, "CLIENTE", 12)
            rptOrdem.DesenharLinha(intNpag, 40, 625, 200, 625, 1)
            rptOrdem.DesenharTexto(intNpag, 65, 635, "Nome: ", 8)
            rptOrdem.DesenharTexto(intNpag, 95, 635, "" & cliente.nome, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 655, "RG: ", 8)
            rptOrdem.DesenharTexto(intNpag, 95, 655, "" & cliente.rg, 8)

            rptOrdem.DesenharTexto(intNpag, 45, 670, "CONTATO", 12)
            rptOrdem.DesenharLinha(intNpag, 40, 685, 200, 685, 1)
            rptOrdem.DesenharTexto(intNpag, 65, 695, "Telefone 1: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 695, "(" & cliente.ddd_1 & ")" & cliente.telefone_1, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 715, "Telefone 2: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 715, "(" & cliente.ddd_2 & ")" & cliente.telefone_2, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 735, "Telefone 3: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 735, "(" & cliente.ddd_3 & ")" & cliente.telefone_3, 8)
            rptOrdem.DesenharTexto(intNpag, 65, 755, "Email: ", 8)
            rptOrdem.DesenharTexto(intNpag, 115, 755, "" & cliente.email, 8)

            rptOrdem.DesenharTexto(intNpag, 300, 610, "ORDEM DE SERVIÇO", 12)
            rptOrdem.DesenharLinha(intNpag, 295, 625, 455, 625, 1)
            rptOrdem.DesenharLinha(intNpag, 295, 627, 455, 627, 1)

            rptOrdem.DesenharTexto(intNpag, 315, 635, "Marca: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 635, "" & marca, 8)
            rptOrdem.DesenharTexto(intNpag, 315, 655, "Modelo: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 655, "" & ordem.modelo, 8)
            rptOrdem.DesenharTexto(intNpag, 315, 676, "Estado da Ordem: ", 8)
            rptOrdem.DesenharTexto(intNpag, 385, 676, "" & estado, 8)

            rptOrdem.DesenharTexto(intNpag, 315, 695, "Defeito: ", 8)
            If ordem.defeito.Length > 50 Then
                validaCampoGrande(ordem.defeito, 695)
            Else
                rptOrdem.DesenharTexto(intNpag, 345, 695, "" & ordem.defeito, 8)
            End If

            rptOrdem.DesenharTexto(intNpag, 315, 715, "Laudo: ", 8)
            If ordem.laudo.Length > 50 Then
                validaCampoGrande(ordem.laudo, 715)
            Else
                rptOrdem.DesenharTexto(intNpag, 345, 715, "" & ordem.laudo, 8)
            End If

            rptOrdem.DesenharTexto(intNpag, 315, 735, "Taxa: ", 8)
            rptOrdem.DesenharTexto(intNpag, 345, 735, " R$ " & ordem.preco_concerto, 8)

            rptOrdem.DesenharTexto(intNpag, 315, 755, "Observação: ", 8)
            If ordem.observacao.Length > 50 Then
                validaCampoGrande(ordem.observacao, 755)
            Else
                rptOrdem.DesenharTexto(intNpag, 365, 755, ordem.observacao, 8)
            End If


            'rptCliente.DesenharTexto(intNpag, 65, 535, "ALTERAÇÃO", 12)
            'rptCliente.DesenharLinha(intNpag, 40, 550, 200, 550, 1)
            'rptCliente.DesenharTexto(intNpag, 90, 570, "Data de Cadastro: ", 8)
            'rptCliente.DesenharTexto(intNpag, 160, 570, "" & ordem.dt_cadastro, 8)
            'rptCliente.DesenharTexto(intNpag, 90, 590, "Data de Alteração: ", 8)
            'rptCliente.DesenharTexto(intNpag, 160, 590, "" & ordem.dt_alteracao, 8)
            'rptCliente.DesenharTexto(intNpag, 90, 610, "Usuário: ", 8)
            'rptCliente.DesenharTexto(intNpag, 130, 610, "" & usuario.username, 8)

            'rptCliente.DesenharTexto(intNpag, 550, 780, intNpag + 1, 8)
            'rptCliente.DesenharLinha(intNpag, 420, 795, 570, 795, 1)
            'rptCliente.DesenharTexto(intNpag, 430, 800, "* Criado por Peil , contato: andreguipeil@gmail.com", 6)

            rptOrdem.GerarArquivo(System.Windows.Forms.Application.StartupPath & "\rptOrdem-" & ordem.id & ".pdf")
            rptOrdem.Dispose()

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\rptOrdem-" & ordem.id & ".pdf")
            Return True
        Catch ex As Exception ' se gera erro pega  descricao do erro na variavel ex
            MsgBox("Erro ao abrir PDF : " & ex.ToString()) ' mostra na tela
        End Try

        Return False

    End Function

    Public Sub validaCampoGrande(ByVal campo As String, ByVal l As Integer)

        Dim tam As Integer
        Dim i As Integer
        Dim j As Integer
        Dim aux As String = ""
        Dim linha As Integer = l
        tam = Int(campo.Length / 50)
        tam = tam

        Dim obsSplit As String() = Split(campo, " ")
        Dim temp As Integer
        i = 0
        j = 0
        While i <= tam
            While aux.Length < 50
                temp = aux.Length + obsSplit(j).Length()
                If (temp > 50) Then
                    Exit While
                End If
                If ((obsSplit.Length - 1) = j) Then
                    aux = aux & obsSplit(j) & " "
                    Exit While
                End If
                aux = aux & obsSplit(j) & " "
                j = j + 1
                temp = 0
            End While
            rptOrdem.DesenharTexto(0, 365, linha, aux, 8)
            linha = linha + 10
            aux = ""
            i = i + 1
        End While

    End Sub

End Class
