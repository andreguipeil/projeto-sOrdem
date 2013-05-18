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
            Dim rptCliente As New PDF()
            Dim intNpag As Integer = 0
            Dim intAux As Integer = 0
            Dim datHoje As DateTime = DateTime.Now


            rptCliente.Autor = "André Peil"
            rptCliente.Titulo = "S-Ordem - Sistema de Gerenciamento de Ordens de Serviço"
            rptCliente.AdicionarPG()
            'rptClientes.InserirIMG(intNpag, Application.StartupPath & "\imagens\celulares2.jpg", 35, 105, 69, 64, 100)

            'rptClientes.DesenharLinha(intNpag, 25, 52, 570, 52, 1)
            rptCliente.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptCliente.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptCliente.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)
            rptCliente.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
            rptCliente.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

            rptCliente.InserirIMG(intNpag, Application.StartupPath & "\imagens\paper.jpg", 30, 180, 48, 48, 100)
            rptCliente.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
            rptCliente.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
            rptCliente.DesenharTexto(intNpag, 100, 135, "ORDEM DE SERVIÇO: Nr. " & ordem.id, 16)
            rptCliente.DesenharTexto(intNpag, 100, 155, "Data de Entrada: " & ordem.dt_entrada & " - Data de Saida: " & ordem.dt_saida, 10)
            rptCliente.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
            rptCliente.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

            rptCliente.DesenharTexto(intNpag, 65, 200, "CLIENTE", 12)
            rptCliente.DesenharLinha(intNpag, 40, 215, 200, 215, 1)
            rptCliente.DesenharTexto(intNpag, 90, 225, "Nome: ", 8)
            rptCliente.DesenharTexto(intNpag, 120, 225, "" & cliente.nome, 8)
            rptCliente.DesenharTexto(intNpag, 90, 245, "RG: ", 8)
            rptCliente.DesenharTexto(intNpag, 120, 245, "" & cliente.rg, 8)

            rptCliente.DesenharTexto(intNpag, 65, 260, "CONTATO", 12)
            rptCliente.DesenharLinha(intNpag, 40, 275, 200, 275, 1)
            rptCliente.DesenharTexto(intNpag, 90, 285, "Telefone 1: ", 8)
            rptCliente.DesenharTexto(intNpag, 140, 285, "(" & cliente.ddd_1 & ")" & cliente.telefone_1, 8)
            rptCliente.DesenharTexto(intNpag, 90, 305, "Telefone 2: ", 8)
            rptCliente.DesenharTexto(intNpag, 140, 305, "(" & cliente.ddd_2 & ")" & cliente.telefone_2, 8)
            rptCliente.DesenharTexto(intNpag, 90, 325, "Telefone 3: ", 8)
            rptCliente.DesenharTexto(intNpag, 140, 325, "(" & cliente.ddd_3 & ")" & cliente.telefone_3, 8)
            rptCliente.DesenharTexto(intNpag, 90, 345, "Email: ", 8)
            rptCliente.DesenharTexto(intNpag, 120, 345, "" & cliente.email, 8)

            rptCliente.DesenharTexto(intNpag, 65, 360, "ORDEM DE SERVIÇO", 12)
            rptCliente.DesenharLinha(intNpag, 40, 375, 400, 375, 1)
            rptCliente.DesenharLinha(intNpag, 40, 377, 400, 377, 1)

            rptCliente.DesenharTexto(intNpag, 90, 400, "Marca: ", 8)
            rptCliente.DesenharTexto(intNpag, 120, 400, "" & marca, 8)
            rptCliente.DesenharTexto(intNpag, 90, 420, "Modelo: ", 8)
            rptCliente.DesenharTexto(intNpag, 125, 420, "" & ordem.modelo, 8)
            rptCliente.DesenharTexto(intNpag, 90, 440, "Estado da Ordem: ", 8)
            rptCliente.DesenharTexto(intNpag, 160, 440, "" & estado, 8)
            rptCliente.DesenharTexto(intNpag, 90, 460, "Defeito: ", 8)
            rptCliente.DesenharTexto(intNpag, 125, 460, "" & ordem.defeito, 8)
            rptCliente.DesenharTexto(intNpag, 90, 480, "Laudo: ", 8)
            rptCliente.DesenharTexto(intNpag, 120, 480, "" & ordem.laudo, 8)
            rptCliente.DesenharTexto(intNpag, 90, 500, "Taxa: ", 8)
            rptCliente.DesenharTexto(intNpag, 110, 500, " R$ " & ordem.preco_concerto, 8)
            rptCliente.DesenharTexto(intNpag, 90, 520, "Observação: ", 8)
            rptCliente.DesenharTexto(intNpag, 140, 520, "" & ordem.observacao, 8)

            rptCliente.DesenharTexto(intNpag, 65, 535, "ALTERAÇÃO", 12)
            rptCliente.DesenharLinha(intNpag, 40, 550, 200, 550, 1)
            rptCliente.DesenharTexto(intNpag, 90, 570, "Data de Cadastro: ", 8)
            rptCliente.DesenharTexto(intNpag, 160, 570, "" & ordem.dt_cadastro, 8)
            rptCliente.DesenharTexto(intNpag, 90, 590, "Data de Alteração: ", 8)
            rptCliente.DesenharTexto(intNpag, 160, 590, "" & ordem.dt_alteracao, 8)
            rptCliente.DesenharTexto(intNpag, 90, 610, "Usuário: ", 8)
            rptCliente.DesenharTexto(intNpag, 130, 610, "" & usuario.username, 8)

            rptCliente.DesenharTexto(intNpag, 550, 780, intNpag + 1, 8)
            rptCliente.DesenharLinha(intNpag, 420, 795, 570, 795, 1)
            rptCliente.DesenharTexto(intNpag, 430, 800, "* Criado por Peil , contato: andreguipeil@gmail.com", 6)

            rptCliente.GerarArquivo(System.Windows.Forms.Application.StartupPath & "\rptOrdem-" & ordem.id & ".pdf")
            rptCliente.Dispose()

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\rptOrdem-" & ordem.id & ".pdf")
            Return True
        Catch ex As Exception ' se gera erro pega  descricao do erro na variavel ex
            MsgBox("Erro ao abrir PDF : " & ex.ToString()) ' mostra na tela
        End Try

        Return False

    End Function

End Class
