<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarTecnico.aspx.cs" Inherits="TP3_LACIOPPA.ModificarTecnico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form>
    <h2>MODIFICAR TECNICO</h2>
     <div class="form-row">
    <div class="form-group col-md-6">
        <asp:Label Text="Buscar Tecnico (solo dni)" runat="server" />
        <asp:TextBox ID="txtBuscarUsuario" runat="server" class="form-control" Width="150px"></asp:TextBox>
        <asp:Button ID="btnBuscarTecn" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarTecn_Click" />
    </div>
  </div>
  <div class="form-row">
    <div class="form-group col-md-6">
            <asp:Label Text="Usuario" runat="server" />
        <asp:TextBox ID="txtUser" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Nombre" runat="server" />
            <asp:TextBox ID="txtnombre" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
            <asp:Label Text="Apellido" runat="server" />
            <asp:TextBox ID="txtApellido" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
            <asp:Label Text="DNI" runat="server" />
            <asp:TextBox ID="txtDNI" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Sueldo $" runat="server" />
        <asp:TextBox ID="txtsueldo" runat="server" class="form-control" type="text" Width="150px"></asp:TextBox>
        <asp:Label Text="Perfil" runat="server" />
        <br />
        <asp:DropDownList ID="dwPerfil" runat="server" class="btn btn-secondary btn-sm dropdown-toggle"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnModificarCliente" runat="server" Text="Modificar" class="btn btn-warning" OnClick="btnModificarCliente_Click" />
    </div>
  </div>
</form>
</asp:Content>
