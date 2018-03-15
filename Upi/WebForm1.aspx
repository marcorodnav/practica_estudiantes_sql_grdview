<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Upi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="grdViewEstudiante" runat="server">
        </asp:GridView>
        <br />
        CODIGO:&nbsp; <asp:TextBox ID="txtCodigoEstudiante" runat="server" CausesValidation="True"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorCodigo" runat="server" ControlToValidate="txtCodigoEstudiante" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        NOMBRE:
        <asp:TextBox ID="txtNombreEstudiante" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validatorNombre" runat="server" ControlToValidate="txtNombreEstudiante" ErrorMessage="Campo requerido" ForeColor="Red">Campo requerido</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnIngresarEstudiante" runat="server" OnClick="btnIngresarEstudiante_Click" Text="Ingresar" />
        <br />
        <br />
        <asp:Button ID="btnBorrarEstudiante" runat="server" OnClick="btnBorrarEstudiante_Click" Text="Borrar" />
        <br />
        <br />
        <asp:Button ID="btnActualizarEstudiante" runat="server" OnClick="btnActualizarEstudiante_Click" Text="Actualizar" />
        <br />
        <br />
        <asp:Label ID="lblEstadoInsertar" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
