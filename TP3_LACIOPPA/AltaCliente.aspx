<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="TP3_LACIOPPA.AltaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>  
        <h2>AGREGAR NUEVO CLIENTE</h2>
    </center>
<form>
  <div class="form-row">
    <div class="form-group col-md-6">
            <asp:Label Text="Nombre" runat="server" />
            <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
            <asp:Label Text="Apellido" runat="server" />
            <asp:TextBox ID="txtApellido" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
            <asp:Label Text="DNI" runat="server" />
            <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
    </div>
  </div>
  <div class="form-group">
    <asp:Label Text="Direccion" runat="server" />
            <asp:TextBox ID="txtDireccion" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
            <asp:Label Text="Localidad" runat="server" />
            <asp:TextBox ID="txtLocalidad" runat="server" class="form-control" type="text" Width="250px"></asp:TextBox>
            <asp:Label Text="Telefono" runat="server" />
            <asp:TextBox ID="txtTelefono" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
            <asp:Label Text="Mail" runat="server" />
            <asp:TextBox ID="txtMail" runat="server" class="form-control" type="text" Width="300px"></asp:TextBox>
  </div>
  <asp:Button ID="btnAgregarCliente" runat="server" class="btn btn-primary" Text="Cargar Cliente" OnClick="btnAgregarCliente_Click" />
</form>

</asp:Content>
