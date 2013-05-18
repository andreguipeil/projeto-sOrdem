Imports GeradorPDF

Public Class RptClientes

    'x inicial = 0
    'y inicial = 0
    'x final = 595
    'y final = 840

    Public Function relatorioClientes(ByVal cliente As Cliente) As Boolean

        Try
            Dim acessoClienteModel As New clienteModel
            Dim rptClientes As New PDF()
            Dim dr As OleDb.OleDbDataReader
            Dim intNpag As Integer = 0
            Dim intAux As Integer = 0
            Dim datHoje As DateTime = DateTime.Now
            Dim cont As Integer = 0

            dr = acessoClienteModel.getClientesRpt(cliente)

            rptClientes.Autor = "André Peil"
            rptClientes.Titulo = "S-Ordem - Sistema de Gerenciamento de Ordens de Serviço"
            rptClientes.AdicionarPG()
           
            rptClientes.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptClientes.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptClientes.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)



            rptClientes.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
            rptClientes.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

            rptClientes.InserirIMG(intNpag, Application.StartupPath & "\imagens\person.jpg", 30, 180, 48, 48, 100)
            rptClientes.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
            rptClientes.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
            rptClientes.DesenharTexto(intNpag, 100, 135, "RELATÓRIO DE CLIENTES", 16)
            rptClientes.DesenharTexto(intNpag, 100, 155, "Data: " & Format(datHoje, "dd-MM-yyyy"), 10)
            rptClientes.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
            rptClientes.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

            rptClientes.DesenharTexto(intNpag, 25, 215, "ID", 10)
            rptClientes.DesenharTexto(intNpag, 40, 215, "NOME", 10)
            rptClientes.DesenharTexto(intNpag, 160, 215, "RG", 10)
            rptClientes.DesenharTexto(intNpag, 230, 215, "CPF", 10)
            rptClientes.DesenharTexto(intNpag, 305, 215, "TELEFONE 1", 10)
            rptClientes.DesenharTexto(intNpag, 380, 215, "TELEFONE 2", 10)
            rptClientes.DesenharTexto(intNpag, 455, 215, "TELEFONE 3", 10)
            rptClientes.DesenharTexto(intNpag, 525, 215, "USUARIO", 10)
            rptClientes.DesenharLinha(intNpag, 20, 230, 570, 230, 1)

            If dr.HasRows Then
                intAux = 240
                While dr.Read
                    If (cont Mod 2) = 0 Then
                        rptClientes.DesenharRetangulo(intNpag, 20, intAux, 550, 18, 1, "", Color.LightGray, Color.LightGray)
                    End If

                    rptClientes.DesenharTexto(intNpag, 25, intAux, dr.Item("id"), 10)
                    rptClientes.DesenharTexto(intNpag, 40, intAux, dr.Item("nome"), 10)
                    rptClientes.DesenharTexto(intNpag, 160, intAux, dr.Item("rg"), 10)
                    rptClientes.DesenharTexto(intNpag, 230, intAux, dr.Item("cpf"), 10)
                    rptClientes.DesenharTexto(intNpag, 305, intAux, dr.Item("telefone_1"), 10)
                    rptClientes.DesenharTexto(intNpag, 380, intAux, dr.Item("telefone_2"), 10)
                    rptClientes.DesenharTexto(intNpag, 455, intAux, dr.Item("telefone_3"), 10)
                    rptClientes.DesenharTexto(intNpag, 525, intAux, dr.Item("usuario"), 10)
                    intAux = intAux + 20
                    cont = cont + 1
                    If intAux > 750 Then
                        rptClientes.AdicionarPG()
                        intNpag = intNpag + 1

                        rptClientes.DesenharLinha(intNpag, 25, 45, 570, 45, 1)
                        rptClientes.DesenharTexto(intNpag, 200, 55, "Assitência Técnica em Celulares & Acessórios ", 18)
                        rptClientes.DesenharTexto(intNpag, 305, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
                        rptClientes.DesenharLinha(intNpag, 25, 100, 570, 100, 1)

                        rptClientes.DesenharLinha(intNpag, 25, 130, 25, 180, 1)
                        rptClientes.DesenharLinha(intNpag, 30, 130, 30, 180, 1)
                        rptClientes.DesenharTexto(intNpag, 40, 135, "RELATÓRIO DE CLIENTES", 16)
                        rptClientes.DesenharTexto(intNpag, 40, 155, "Data: " & Format(datHoje, "dd-MM-yyyy"), 10)
                        rptClientes.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
                        rptClientes.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

                        rptClientes.DesenharTexto(intNpag, 25, 200, "ID", 10)
                        rptClientes.DesenharTexto(intNpag, 40, 200, "NOME", 10)
                        rptClientes.DesenharTexto(intNpag, 160, 200, "RG", 10)
                        rptClientes.DesenharTexto(intNpag, 230, 200, "CPF", 10)
                        rptClientes.DesenharTexto(intNpag, 305, 200, "TELEFONE 1", 10)
                        rptClientes.DesenharTexto(intNpag, 380, 200, "TELEFONE 2", 10)
                        rptClientes.DesenharTexto(intNpag, 455, 200, "TELEFONE 3", 10)
                        rptClientes.DesenharTexto(intNpag, 525, 200, "USUARIO", 10)
                        rptClientes.DesenharLinha(intNpag, 25, 215, 570, 215, 1)
                        intAux = 220
                    End If

                    rptClientes.DesenharTexto(intNpag, 550, 780, intNpag + 1, 8)
                    rptClientes.DesenharLinha(intNpag, 420, 795, 570, 795, 1)
                    rptClientes.DesenharTexto(intNpag, 430, 800, "* Criado por Peil , contato: andreguipeil@gmail.com", 7)
                End While

                rptClientes.DesenharLinha(intNpag, 25, intAux, 570, intAux, 1)
                rptClientes.DesenharLinha(intNpag, 25, intAux + 2, 570, intAux + 2, 1)
                rptClientes.DesenharTexto(intNpag, 25, intAux + 12, "TOTAL DE CLIENTES: ", 10)
                rptClientes.DesenharTexto(intNpag, 140, intAux + 12, cont, 10)
            End If
            acessoClienteModel.Desconectar()

            rptClientes.GerarArquivo(System.Windows.Forms.Application.StartupPath & "\rptClientes.pdf")
            rptClientes.Dispose()

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\rptClientes.pdf")
            Return True
        Catch ex As Exception ' se gera erro pega  descricao do erro na variavel ex
            MsgBox("Erro ao abrir PDF : " & ex.ToString()) ' mostra na tela
        End Try

        Return False
    End Function

    Public Function relatorioCliente(ByVal clienteId As Integer) As Boolean
        Dim cliente As New Cliente
        Dim acessoClienteModel As New clienteModel
        Dim usuario As New Usuario
        Dim acessoUsuarioModel As New usuarioModel

        cliente = acessoClienteModel.getClienteById(clienteId)
        usuario = acessoUsuarioModel.getUsuarioById(cliente.usuario_id)


        Try
            Dim rptCliente As New PDF()
            Dim intNpag As Integer = 0
            Dim intAux As Integer = 0
            Dim datHoje As DateTime = DateTime.Now


            rptCliente.Autor = "André Peil"
            rptCliente.Titulo = "S-Ordem - Sistema de Gerenciamento de Ordens de Serviço"
            rptCliente.AdicionarPG()

            rptCliente.DesenharTexto(intNpag, 80, 55, "BOZÓ Assitência Técnica em Celulares & Acessórios ", 18)
            rptCliente.DesenharTexto(intNpag, 80, 75, "Telefone: 3305-0975 - Contato: facebook.com/bozo.celulares", 10)
            rptCliente.InserirIMG(intNpag, Application.StartupPath & "\imagens\concerto.jpg", 30, 100, 48, 48, 100)
            rptCliente.DesenharLinha(intNpag, 25, 100, 570, 100, 1)
            rptCliente.DesenharLinha(intNpag, 25, 102, 570, 102, 1)

            rptCliente.InserirIMG(intNpag, Application.StartupPath & "\imagens\person.jpg", 30, 180, 48, 48, 100)
            rptCliente.DesenharLinha(intNpag, 85, 130, 85, 180, 1)
            rptCliente.DesenharLinha(intNpag, 90, 130, 90, 180, 1)
            rptCliente.DesenharTexto(intNpag, 100, 135, "CLIENTE: " & cliente.nome, 16)
            rptCliente.DesenharTexto(intNpag, 100, 155, "Data de cadastro: " & cliente.dt_cadastro, 10)
            rptCliente.DesenharLinha(intNpag, 24, 185, 570, 185, 1)
            rptCliente.DesenharLinha(intNpag, 24, 190, 570, 190, 1)

            rptCliente.DesenharTexto(intNpag, 65, 210, "DOCUMENTOS", 10)
            rptCliente.DesenharLinha(intNpag, 60, 225, 250, 225, 1)
            rptCliente.DesenharTexto(intNpag, 90, 230, "RG: ", 10)
            rptCliente.DesenharTexto(intNpag, 120, 230, "" & cliente.rg, 10)
            rptCliente.DesenharTexto(intNpag, 90, 250, "CPF: ", 10)
            rptCliente.DesenharTexto(intNpag, 120, 250, "" & cliente.cpf, 10)

            rptCliente.DesenharTexto(intNpag, 65, 270, "CONTATO", 10)
            rptCliente.DesenharLinha(intNpag, 60, 285, 250, 285, 1)
            rptCliente.DesenharTexto(intNpag, 90, 290, "Telefone 1: ", 10)
            rptCliente.DesenharTexto(intNpag, 150, 290, "(" & cliente.ddd_1 & ")" & cliente.telefone_1, 10)
            rptCliente.DesenharTexto(intNpag, 90, 310, "Telefone 2: ", 10)
            rptCliente.DesenharTexto(intNpag, 150, 310, "(" & cliente.ddd_2 & ")" & cliente.telefone_2, 10)
            rptCliente.DesenharTexto(intNpag, 90, 330, "Telefone 3: ", 10)
            rptCliente.DesenharTexto(intNpag, 150, 330, "(" & cliente.ddd_3 & ")" & cliente.telefone_3, 10)
            rptCliente.DesenharTexto(intNpag, 90, 350, "Email: ", 10)
            rptCliente.DesenharTexto(intNpag, 125, 350, "" & cliente.email, 10)

            rptCliente.DesenharTexto(intNpag, 65, 370, "LOCAL", 10)
            rptCliente.DesenharLinha(intNpag, 60, 385, 250, 385, 1)
            rptCliente.DesenharTexto(intNpag, 90, 390, "Endereço: ", 10)
            rptCliente.DesenharTexto(intNpag, 150, 390, "" & cliente.endereco, 10)
            rptCliente.DesenharTexto(intNpag, 90, 410, "CEP: ", 10)
            rptCliente.DesenharTexto(intNpag, 130, 410, "" & cliente.cep, 10)

            rptCliente.DesenharTexto(intNpag, 65, 430, "INFORMAÇÕES DO SISTEMA", 10)
            rptCliente.DesenharLinha(intNpag, 60, 445, 250, 445, 1)
            rptCliente.DesenharTexto(intNpag, 90, 450, "Data de Cadastro: ", 10)
            rptCliente.DesenharTexto(intNpag, 180, 450, "" & cliente.dt_cadastro, 10)
            rptCliente.DesenharTexto(intNpag, 90, 470, "Data de Alteração: ", 10)
            rptCliente.DesenharTexto(intNpag, 180, 470, "" & cliente.dt_alteracao, 10)
            rptCliente.DesenharTexto(intNpag, 90, 490, "Usuário: ", 10)
            rptCliente.DesenharTexto(intNpag, 135, 490, "" & usuario.username, 10)

            rptCliente.DesenharTexto(intNpag, 550, 780, intNpag + 1, 8)
            rptCliente.DesenharLinha(intNpag, 420, 795, 570, 795, 1)
            rptCliente.DesenharTexto(intNpag, 430, 800, "* Criado por Peil , contato: andreguipeil@gmail.com", 6)

            rptCliente.GerarArquivo(System.Windows.Forms.Application.StartupPath & "\rptCliente-" & cliente.nome & ".pdf")
            rptCliente.Dispose()

            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath & "\rptCliente-" & cliente.nome & ".pdf")
            Return True
        Catch ex As Exception ' se gera erro pega  descricao do erro na variavel ex
            MsgBox("Erro ao abrir PDF : " & ex.ToString()) ' mostra na tela
        End Try

        Return False


    End Function

End Class
