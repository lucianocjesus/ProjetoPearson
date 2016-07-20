<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mensagem.aspx.cs" Inherits="ProjetoTestePerson.WebForms.Mensagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Avaliação Pearson</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/animate.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link rel="shortcut icon" type="image/x-icon" href="favicon.ico" />
    <script type="text/javascript">
        function fCheck() {
            var msg = "";
            if (document.getElementById('<%= txtNome.ID%>').value == '') {
                msg = msg + '   * Nome\n';
            }

            if (document.getElementById('<%= txtEmail.ID%>').value == '') {
                msg = msg + '   * E-mail\n';
            }

            if (document.getElementById('<%= txtDDD.ID%>').value == '') {
                msg = msg + '   * DDD\n';
            }

            if (document.getElementById('<%= txtTelefone.ID%>').value == '') {
                msg = msg + '   * Telefone\n';
            }

            if (document.getElementById('<%= ddlAssuntos.ID%>').value == 0) {
                msg = msg + '   * Assunto\n';
            }

            if (document.getElementById('<%= txtMensagem.ID%>').value == '') {
                msg = msg + '   * Mensagem\n';
            }

            if (msg != "") {
                alert('Os seguintes campos são obrigatórios:\n\n' + msg);
                return false;
            }
        }
    </script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container animated rollIn">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
        </div>
    </div>

    <div class="container text-center animated slideInUp">
        <div class="row">
            <div class="col-sm-2"></div>
            <div class="col-sm-8 text-left">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label>Nome:</label>
                        <asp:TextBox class="form-control input-lg" ID="txtNome" placeholder="Nome" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>E-mail:</label>
                        <asp:TextBox class="form-control input-lg" ID="txtEmail" placeholder="E-mail" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>Telefone:</label>
                        <div class="form-inline">
                            <asp:TextBox class="form-control input-lg" ID="txtDDD" placeholder="DDD" runat="server"></asp:TextBox>
                            <asp:TextBox class="form-control input-lg" ID="txtTelefone" placeholder="Telefone" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <label>Assunto:</label>
                        <asp:DropDownList class="form-control input-lg" ID="ddlAssuntos" runat="server"></asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label>Mensagem:</label>
                        <asp:TextBox class="form-control input-lg" ID="txtMensagem" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                    </div>

                    <asp:Button ID="btnEnviarDados" class="btn btn-danger" runat="server" Text="Enviar" OnClick="btnEnviarDados_Click" />
                </form>
            </div>
            <div class="col-sm-2"></div>
        </div>
    </div>
    <footer class="container text-center">
        <p>
            <asp:Label ID="lblRetorno" runat="server" Text="" />
        </p>
    </footer>
</body>
</html>
